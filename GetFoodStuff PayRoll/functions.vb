Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Security.Cryptography
Module functions
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim query As String
    'for connection to the db
    Function connection()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=payroll_db")
        Return conn
    End Function
    'to count users in and from the database
    Function countId(ByVal counter_id As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("UPDATE counters_tab SET counter_value=counter_value+1 WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        connection.Close()

        connection.Open()
        command = New MySqlCommand("SELECT counter_value FROM counters_tab WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        reader.Read()
        Dim counter_value = reader("counter_value")
        connection.Close()
        Return counter_value
    End Function
    'To count all record of user from the database
    Public Sub GetRecordCount()
        Dim connection = functions.connection
        Dim query As String

        connection.Open()
        query = "SELECT COUNT(*) FROM staffs_tab"
        command = New MySqlCommand(query, connection)
        admin_dashboard.total_employee_lbl.Text = command.ExecuteScalar()
        connection.Close()
    End Sub

    Public Sub GetRecordCountBranch()
        Dim connection = functions.connection
        Dim querie As String

        connection.Open()
        querie = "SELECT COUNT(*) FROM branch_tab"
        command = New MySqlCommand(querie, connection)
        admin_dashboard.branch_count_lbl.Text = command.ExecuteScalar()
        connection.Close()
    End Sub
    'passport
    Function passport()
        Dim msstream As New System.IO.MemoryStream()
        register_staff_form.passport.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()
        Return arrimage
    End Function
     'to check email_address in good mail format
    Public Function IsValidEmail(ByVal email As String) As Boolean
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|ng|edu)$"
        Return Regex.IsMatch(email, emailPattern)
    End Function
    'check if email exist in the table
    Function StaffemailCheck(ByVal email_address As String)
        Dim connection = functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT * FROM staffs_tab WHERE email_address=@email_address", connection)
        command.Parameters.AddWithValue("@email_address", email_address)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function
    'to insert into the database
    Public Sub Registration()
        'allow passport to save
        functions.passport()

        Dim staffId = "STAFF" + Now.ToString("yyyyMMddss") & functions.countId("STAFF")

        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "INSERT INTO staffs_tab (staff_id, fullname, email_address, phone_number, passport, role_id, status_id, branch_id, department_id, job_grade_id, created_time) VALUES (@staff_id, @fullname, @email_address, @phone_number, @passport, @role_id, @status_id,  @branch_id, @department_id, @job_grade_id, NOW())"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@staff_id", staffId)
            Command.Parameters.AddWithValue("@fullname", register_staff_form.fullname_txt.Text.ToUpper())
            Command.Parameters.AddWithValue("@email_address", register_staff_form.email_address_txt.Text)
            Command.Parameters.AddWithValue("@phone_number", register_staff_form.phone_number_txt.Text)
            Command.Parameters.AddWithValue("@passport", arrimage)
            Command.Parameters.AddWithValue("@role_id", register_staff_form.role_combo.SelectedValue)
            Command.Parameters.AddWithValue("@status_id", register_staff_form.status_combo.SelectedValue)
            Command.Parameters.AddWithValue("@branch_id", register_staff_form.branch_combo.SelectedValue)
            Command.Parameters.AddWithValue("@department_id", register_staff_form.department_combo.SelectedValue)
            Command.Parameters.AddWithValue("@job_grade_id", register_staff_form.job_grade_combo.SelectedValue)

            reader = Command.ExecuteReader
            connection.Close()

            MsgBox("User Registration successful!")

            'GetRecordCount()
            clearFunction()
            getStaffID()

        Catch ex As Exception
            MsgBox("User Registration failed: " & ex.Message)
        End Try
    End Sub
    'to fetch role 
    Public Sub getRole()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_role_tab WHERE role_id IN (1,2);", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("role_id") = 0
            defaultRow("role_name") = "SELECT ROLE"
            DT.Rows.InsertAt(defaultRow, 0)

            register_staff_form.role_combo.DataSource = DT
            register_staff_form.role_combo.DisplayMember = "role_name"
            register_staff_form.role_combo.ValueMember = "role_id"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'to fetch status
    Public Sub getStatus()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_status_tab WHERE status_id IN (1,2);", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("status_id") = 0
            defaultRow("status_name") = "SELECT STATUS"
            DT.Rows.InsertAt(defaultRow, 0)

            register_staff_form.status_combo.DataSource = DT
            register_staff_form.status_combo.DisplayMember = "status_name"
            register_staff_form.status_combo.ValueMember = "status_id"

            add_branch_form.status_combo.DataSource = DT
            add_branch_form.status_combo.DisplayMember = "status_name"
            add_branch_form.status_combo.ValueMember = "status_id"

            add_department.status_combo.DataSource = DT
            add_department.status_combo.DisplayMember = "status_name"
            add_department.status_combo.ValueMember = "status_id"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'to fetch status
    Public Sub getJobGrade()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM job_grade_tab;", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("job_grade_id") = 0
            defaultRow("job_grade_name") = "SELECT JOB GRADE"
            DT.Rows.InsertAt(defaultRow, 0)

            register_staff_form.job_grade_combo.DataSource = DT
            register_staff_form.job_grade_combo.DisplayMember = "job_grade_name"
            register_staff_form.job_grade_combo.ValueMember = "job_grade_id"

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'to fetch branch
    Public Sub getBranch()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM branch_tab;", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("branch_id") = 0
            defaultRow("branch_name") = "SELECT BRANCH"
            DT.Rows.InsertAt(defaultRow, 0)

            register_staff_form.branch_combo.DataSource = DT
            register_staff_form.branch_combo.DisplayMember = "branch_name"
            register_staff_form.branch_combo.ValueMember = "branch_id"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'to fetch department
    Public Sub getDepartment()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM department_tab;", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("department_id") = 0
            defaultRow("department_name") = "SELECT DEPARTMENT"
            DT.Rows.InsertAt(defaultRow, 0)

            register_staff_form.department_combo.DataSource = DT
            register_staff_form.department_combo.DisplayMember = "department_name"
            register_staff_form.department_combo.ValueMember = "department_id"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading department: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub getYear()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_year_tab;", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("year_id") = 0
            defaultRow("year_name") = "SELECT YEAR"
            DT.Rows.InsertAt(defaultRow, 0)

            staffs_payroll_form.year_combo.DataSource = DT
            staffs_payroll_form.year_combo.DisplayMember = "year_name"
            staffs_payroll_form.year_combo.ValueMember = "year_id"

            view_payment_breakdown.year_combo.DataSource = DT
            view_payment_breakdown.year_combo.DisplayMember = "year_name"
            view_payment_breakdown.year_combo.ValueMember = "year_id"


        Catch ex As Exception
            MessageBox.Show("An error occurred while loading year: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'to clear all inputs
    Public Sub clearFunction()
        'clear for staff
        register_staff_form.fullname_txt.Clear()
        register_staff_form.email_address_txt.Clear()
        register_staff_form.phone_number_txt.Clear()
        register_staff_form.status_combo.Text = "SELECT STATUS"
        register_staff_form.role_combo.Text = "SELECT ROLE"
        register_staff_form.branch_combo.Text = "SELECT BRANCH"
        register_staff_form.department_combo.Text = "SELECT DEPARTMENT"
        register_staff_form.job_grade_combo.Text = "SELECT JOB GRADE"
        register_staff_form.profile_id_combo.Text = "SELECT STAFF"
        register_staff_form.passport.Image = Nothing


        'clear for branches
        add_branch_form.branch_name_txt.Clear()
        add_branch_form.branch_email_address_txt.Clear()
        add_branch_form.branch_phone_number.Clear()
        add_branch_form.branch_address.Clear()
        add_branch_form.status_combo.Text = "SELECT STATUS"
        add_branch_form.branch_id_combo.Text = "SELECT BRANCH"

        'clear department
        add_department.dept_name_txt.Clear()
        add_department.status_combo.Text = "SELECT STATUS"
        add_department.dept_id_combo.Text = "SELECT DEPARTMENT"

        'clear payment details
        
        staffs_payroll_form.month_combo.Text = "SELECT MONTH"
        staffs_payroll_form.year_combo.Text = "SELECT YEAR"
        staffs_payroll_form.total_txt.Clear()


        'clear job grade
        add_job_grade.job_id_combo.Text = "SELECT JOB GRADE"
        add_job_grade.job_grade_name_txt.Clear()
        add_job_grade.basic_salary_txt.Clear()
        add_job_grade.allowance_txt.Clear()
        add_job_grade.bonus_txt.Clear()
        add_job_grade.commission_txt.Clear()
        add_job_grade.total_txt.Clear()
        add_job_grade.tax_txt.Clear()

        add_department.dept_name_txt.Clear()
        add_department.dept_id_combo.Text = "SELECT DEPARTMENT"
        add_department.status_combo.Text = "SELECT STATUS"




    End Sub

    Public Sub clearFunction2()
        register_staff_form.fullname_txt.Clear()
        register_staff_form.email_address_txt.Clear()
        register_staff_form.phone_number_txt.Clear()
        register_staff_form.status_combo.Text = "SELECT STATUS"
        register_staff_form.role_combo.Text = "SELECT ROLE"
        register_staff_form.branch_combo.Text = "SELECT BRANCH"
        register_staff_form.department_combo.Text = "SELECT DEPARTMENT"
        register_staff_form.job_grade_combo.Text = "SELECT JOB GRADE"
        register_staff_form.passport.Image = Nothing


        'clear for branches
        add_branch_form.branch_name_txt.Clear()
        add_branch_form.branch_email_address_txt.Clear()
        add_branch_form.branch_phone_number.Clear()
        add_branch_form.branch_address.Clear()
        add_branch_form.status_combo.Text = "SELECT STATUS"

        'clear department
        add_department.dept_name_txt.Clear()
        add_department.status_combo.Text = "SELECT STATUS"


        'clear payment records
        staffs_payroll_form.month_combo.Text = "SELECT MONTH"

        'clear job grade
        add_job_grade.job_grade_name_txt.Clear()
        add_job_grade.basic_salary_txt.Clear()
        add_job_grade.allowance_txt.Clear()
        add_job_grade.bonus_txt.Clear()
        add_job_grade.commission_txt.Clear()
        add_job_grade.total_txt.Clear()
        add_job_grade.total_txt.Clear()
        add_job_grade.tax_txt.Clear()

    End Sub
    'to protect password
    Public Function HashPassword(ByVal defaultPassword As String) As String
        Using md5 As Security.Cryptography.MD5 = Security.Cryptography.MD5.Create()
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(defaultPassword)
            Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)
            Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        End Using
    End Function

    Function getStaffProfile(ByVal staff_id As String)
        Dim connection = functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT a.fullname, a.last_login, a.passport, b.role_name  FROM staffs_tab a, setup_role_tab b WHERE staff_id=@staff_id AND a.role_id=b.role_id", connection)
        command.Parameters.AddWithValue("@staff_id", staff_id)
        reader = command.ExecuteReader
        reader.Read()

        Dim role_name = reader("role_name")
        Dim fullname = reader("fullname")
        Dim last_login = reader("last_login")
        Dim arrimage() As Byte = reader("passport")
        connection.close()
        Return Tuple.Create(fullname, last_login, arrimage, role_name)
    End Function

    Public Sub fetchStaffrenumeration()
        Try
            Dim connection = functions.connection
            connection.Open()

            query = "SELECT a.fullname, a.passport, b.basic_salary,c.transport_allowance, c.bonus, c.commission FROM staffs_tab a, job_grade_tab b , staff_payment_tab c, setup_months_tab d WHERE a.staff_id=@staff_id AND a.job_grade_id=b.job_grade_id AND a.staff_id=c.staff_id  AND c.month_id=@month_id;"
            Dim Command = New MySqlCommand(query, connection)
            'Command.Parameters.AddWithValue("@staff_id", staffs_payroll_form.profile_id_combo.SelectedValue)
            Command.Parameters.AddWithValue("@month_id", staffs_payroll_form.month_combo.SelectedValue)
            reader = Command.ExecuteReader
            reader.Read()

            Dim basic_salary, bonus, commission, tax_percentage, tax_amount, allowance, total_payment As Decimal

            basic_salary = reader("basic_salary")
            bonus = reader("bonus")
            commission = reader("commission")
            allowance = reader("transport_allowance")
            'tax = reader("tax")
            tax_percentage = 10 / 100
            tax_amount = basic_salary * tax_percentage
            total_payment = ((basic_salary + bonus + commission + allowance) - tax_amount)


            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub fetchTotalPay()
        Try
            Dim connection = functions.connection
            connection.Open()

            query = "SELECT total_payment FROM payroll_tab WHERE month_id=@month_id AND year_id = @year_id;"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@year_id", staffs_payroll_form.year_combo.SelectedValue)
            Command.Parameters.AddWithValue("@month_id", staffs_payroll_form.month_combo.SelectedValue)
            reader = Command.ExecuteReader
            reader.Read()

            staffs_payroll_form.total_txt.Text = reader("total_payment")
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub fetchStaffrenumeration2()
        Try
            Dim connection = functions.connection
            connection.Open()


            query = "SELECT a.fullname, a.passport, b.basic_salary, c.transport_allowance, c.bonus, c.commission FROM staffs_tab a, job_grade_tab b , staff_payment_tab c WHERE a.staff_id=@staff_id AND a.job_grade_id=b.job_grade_id AND a.staff_id=c.staff_id;"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@staff_id", staff_login_form.login_staff_id)
            reader = Command.ExecuteReader
            reader.Read()


            Dim basic_salary, bonus, commission, tax_percentage, tax_amount, allowance As Decimal

            basic_salary = reader("basic_salary")
            bonus = reader("bonus")
            commission = reader("commission")
            allowance = reader("transport_allowance")
            'tax = reader("tax")
            tax_percentage = 10 / 100
            tax_amount = basic_salary * tax_percentage



            view_self_payment.basic_salary_txt.Text = basic_salary.ToString
            view_self_payment.bonus_txt.Text = bonus.ToString
            view_self_payment.commission_txt.Text = commission.ToString
            view_self_payment.tax_amount_txt.Text = tax_amount.ToString
            view_self_payment.allowance_txt.Text = allowance.ToString

            view_self_payment.total_txt.Text = ((basic_salary + bonus + commission + allowance) - tax_amount).ToString

            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub loginClearFunction()
        login_form.email_address_txt.Clear()
        login_form.password_txt.Clear()
    End Sub

    Public Sub getStaffID()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM staffs_tab WHERE role_id < @role_id", connection)
        command.Parameters.AddWithValue("@role_id", login_form.login_role_id)
        DT.Load(command.ExecuteReader)
        reader = command.ExecuteReader
        reader.Read()

        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("staff_id") = ""
        defaultRow("role_id") = 0
        defaultRow("status_id") = 0
        defaultRow("fullname") = "SELECT STAFF"
        defaultRow("email_address") = ""
        defaultRow("phone_number") = ""
        defaultRow("branch_id") = ""
        defaultRow("department_id") = ""
        defaultRow("phone_number") = ""

        defaultRow("password") = ""
        defaultRow("otp") = 0
        DT.Rows.InsertAt(defaultRow, 0)

        register_staff_form.profile_id_combo.DataSource = DT
        register_staff_form.profile_id_combo.DisplayMember = "fullname"
        register_staff_form.profile_id_combo.ValueMember = "staff_id"

        
    End Sub

    Public Sub getBranchID()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM branch_tab  ", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("branch_id") = ""
        defaultRow("branch_name") = "SELECT BRANCH"
        defaultRow("branch_email_address") = ""
        defaultRow("branch_phone_number") = ""
        defaultRow("branch_address") = ""
        DT.Rows.InsertAt(defaultRow, 0)

        add_branch_form.branch_id_combo.DataSource = DT
        add_branch_form.branch_id_combo.DisplayMember = "branch_name"
        add_branch_form.branch_id_combo.ValueMember = "branch_id"

    End Sub

    Public Sub getJobGradeID()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM job_grade_tab  ", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("job_grade_id") = ""
        defaultRow("job_grade_name") = "SELECT JOB GRADE"
        defaultRow("basic_salary") = 0.0

        DT.Rows.InsertAt(defaultRow, 0)

        add_job_grade.job_id_combo.DataSource = DT
        add_job_grade.job_id_combo.DisplayMember = "job_grade_name"
        add_job_grade.job_id_combo.ValueMember = "job_grade_id"

    End Sub

    Public Sub getMonth()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM setup_months_tab  ", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("month_id") = 0
        defaultRow("month_name") = "SELECT MONTH"

        DT.Rows.InsertAt(defaultRow, 0)

        staffs_payroll_form.month_combo.DataSource = DT
        staffs_payroll_form.month_combo.DisplayMember = "month_name"
        staffs_payroll_form.month_combo.ValueMember = "month_id"



        view_payment_breakdown.month_combo.DataSource = DT
        view_payment_breakdown.month_combo.DisplayMember = "month_name"
        view_payment_breakdown.month_combo.ValueMember = "month_id"

    End Sub

    Public Sub getDeptID()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM department_tab  ", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("department_id") = ""
        defaultRow("department_name") = "SELECT DEPARTMENT"
        DT.Rows.InsertAt(defaultRow, 0)

        add_department.dept_id_combo.DataSource = DT
        add_department.dept_id_combo.DisplayMember = "department_name"
        add_department.dept_id_combo.ValueMember = "department_id"

    End Sub
    'to fetch staff
    Public Sub StaffFetching()
        Try
            Dim connection = functions.connection
            connection.Open()

            query = "SELECT a.*, b.role_name, c.status_name,d.branch_name, e.department_name FROM staffs_tab a, setup_role_tab b, setup_status_tab c,branch_tab d, department_tab e WHERE a.status_id=c.status_id AND a.role_id=b.role_id AND a.branch_id=d.branch_id AND a.department_id= e.department_id AND staff_id=@staff_id;"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@staff_id", register_staff_form.profile_id_combo.SelectedValue)
            reader = Command.ExecuteReader
            reader.Read()

            Dim arrimage() As Byte

            register_staff_form.fullname_txt.Text = reader("fullname")
            register_staff_form.phone_number_txt.Text = reader("phone_number")
            register_staff_form.email_address_txt.Text = reader("email_address")
            register_staff_form.role_combo.Text = (reader("role_name"))
            register_staff_form.role_combo.SelectedValue = reader("role_id")
            register_staff_form.status_combo.Text = (reader("status_name"))
            register_staff_form.status_combo.SelectedValue = reader("status_id")
            register_staff_form.branch_combo.Text = (reader("branch_name"))
            register_staff_form.branch_combo.SelectedValue = reader("branch_id")
            register_staff_form.department_combo.Text = (reader("department_name"))
            register_staff_form.department_combo.SelectedValue = reader("department_id")
            register_staff_form.job_grade_combo.SelectedValue = reader("job_grade_id")

            arrimage = reader("passport")

            Dim mstream = New MemoryStream(arrimage)
            register_staff_form.passport.Image = Image.FromStream(mstream)
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'reset password 
    Function OtpResetFetch(ByVal emaill As String)
        Dim email As String = reset_password.email_address_txt.Text
        Dim connection = functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT fullname, email_address FROM staffs_tab WHERE email_address =@email_address;", connection)
        command.Parameters.AddWithValue("@email_address", email)
        reader = command.ExecuteReader
        reader.Read()

        Dim fullname = reader("fullname")
        Dim email_address = reader("email_address")
        connection.close()
        Return Tuple.Create(fullname, email_address)
    End Function

    Public Sub otpFam()
        Dim result = functions.OtpResetFetch(reset_password.email_address_txt.Text)
        reset_finish.full_name_txt.Text = result.item1.ToString.ToUpper
        reset_finish.email_address_txt.Text = result.item2.ToString
    End Sub
    'to fetch branch
    Public Sub FetchBranch()
        Try
            Dim connection = functions.connection
            connection.Open()

            query = "SELECT a.*, b.status_name FROM branch_tab a, setup_status_tab b WHERE a.status_id=b.status_id AND branch_id=@branch_id;"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@branch_id", add_branch_form.branch_id_combo.SelectedValue)
            reader = Command.ExecuteReader
            reader.Read()

            add_branch_form.branch_name_txt.Text = reader("branch_name")
            add_branch_form.branch_email_address_txt.Text = reader("branch_email_address")
            add_branch_form.branch_phone_number.Text = reader("branch_phone_number")
            add_branch_form.branch_address.Text = reader("branch_address")
            add_branch_form.status_combo.Text = (reader("status_name"))
            add_branch_form.status_combo.SelectedValue = reader("status_id")


            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'to fetch job grade
    Public Sub FetchJobGrade()
        Try
            Dim connection = functions.connection
            connection.Open()

            query = "SELECT job_grade_name, basic_salary, allowance, bonus, commission, tax, total_payment FROM job_grade_tab WHERE job_grade_id=@job_grade_id;"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@job_grade_id", add_job_grade.job_id_combo.SelectedValue)
            reader = Command.ExecuteReader
            reader.Read()

            add_job_grade.job_grade_name_txt.Text = reader("job_grade_name")
            add_job_grade.basic_salary_txt.Text = reader("basic_salary")
            add_job_grade.allowance_txt.Text = reader("allowance")
            add_job_grade.bonus_txt.Text = reader("bonus")
            add_job_grade.commission_txt.Text = reader("commission")
            add_job_grade.total_txt.Text = reader("total_payment")
            add_job_grade.tax_txt.Text = reader("tax")



            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'to fetch department
    Public Sub FetchDepartment()
        Try
            Dim connection = functions.connection
            connection.Open()

            query = "SELECT a.department_name, b.status_name FROM department_tab a, setup_status_tab b WHERE a.department_id=@department_id;"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@department_id", add_department.dept_id_combo.SelectedValue)
            reader = Command.ExecuteReader
            reader.Read()

            add_department.dept_name_txt.Text = reader("department_name")
            add_department.status_combo.Text = (reader("status_name"))



            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'to register branch
    Public Sub RegisterBranch()

        Dim branchId = "BRANCH" & functions.countId("BRANCH")

        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "INSERT INTO branch_tab (branch_id, branch_name, branch_email_address, branch_phone_number, branch_address, status_id) VALUES (@branch_id, @branch_name, @branch_email_address, @branch_phone_number, @branch_address, @status_id)"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@branch_id", branchId)
            Command.Parameters.AddWithValue("@branch_name", add_branch_form.branch_name_txt.Text.ToUpper())
            Command.Parameters.AddWithValue("@branch_email_address", add_branch_form.branch_email_address_txt.Text)
            Command.Parameters.AddWithValue("@branch_phone_number", add_branch_form.branch_phone_number.Text)
            Command.Parameters.AddWithValue("@branch_address", add_branch_form.branch_address.Text.ToUpper())
            Command.Parameters.AddWithValue("@status_id", add_branch_form.status_combo.SelectedValue)


            reader = Command.ExecuteReader
            connection.Close()

            MsgBox("Branch Registration successful !")

            'GetRecordCount()
            clearFunction()
            getBranchID()

        Catch ex As Exception
            MsgBox("Branch Registration failed: " & ex.Message)
        End Try
    End Sub
    'to register department
    Public Sub RegisterDept()

        Dim deptId = "DEPT00" & functions.countId("DEPT00")

        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "INSERT INTO department_tab (department_id, department_name, status_id) VALUES (@department_id, @department_name, @status_id)"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@department_id", deptId)
            Command.Parameters.AddWithValue("@department_name", add_department.dept_name_txt.Text.ToUpper())
            Command.Parameters.AddWithValue("@status_id", add_department.status_combo.SelectedValue)


            reader = Command.ExecuteReader
            connection.Close()

            MsgBox("Department Registration successful Registration successful!")

            clearFunction()
            getDeptID()

        Catch ex As Exception
            MsgBox("User Registration failed: " & ex.Message)
        End Try
    End Sub
    'REGISTER JOB GRDAE
    Public Sub RegisterJobgrade()

        Dim JobGradegId = "JG00" & functions.countId("JG00")

        Try
            Dim connection = functions.connection
            Dim query As String

            Dim basic_salary, bonus, commission, allowance, tax, total_payment, tax_rate As Decimal
            basic_salary = add_job_grade.basic_salary_txt.Text
            commission = add_job_grade.commission_txt.Text
            bonus = add_job_grade.bonus_txt.Text
            allowance = add_job_grade.allowance_txt.Text
            tax_rate = add_job_grade.tax_txt.Text
            tax = (tax_rate / 100) * basic_salary
            total_payment = (basic_salary + commission + bonus + allowance) - tax



            connection.Open()
            query = "INSERT INTO job_grade_tab (job_grade_id, job_grade_name, basic_salary, allowance, bonus, commission, tax, total_payment) VALUES (@job_grade_id, @job_grade_name, @basic_salary, @allowance, @bonus, @commission, @tax, @total_payment)"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@job_grade_id", JobGradegId)
            Command.Parameters.AddWithValue("@job_grade_name", add_job_grade.job_grade_name_txt.Text.ToUpper())
            Command.Parameters.AddWithValue("@basic_salary", basic_salary)
            Command.Parameters.AddWithValue("@allowance", allowance)
            Command.Parameters.AddWithValue("@bonus", bonus)
            Command.Parameters.AddWithValue("@commission", commission)
            Command.Parameters.AddWithValue("@tax", tax_rate)
            Command.Parameters.AddWithValue("@total_payment", total_payment)
            

            reader = Command.ExecuteReader
            connection.Close()

            MsgBox("Job Grade Registration successful !")

            'GetRecordCount()
            clearFunction()
            getJobGradeID()

        Catch ex As Exception
            MsgBox("Job Grade Registration failed: " & ex.Message)
        End Try
    End Sub
    'to update staff
    Public Sub UpdateStaff()
        functions.passport()
        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "UPDATE staffs_tab SET fullname=@fullname,email_address=@email_address,phone_number=@phone_number,role_id=@role_id,status_id=@status_id,branch_id=@branch_id,department_id=@department_id,job_grade_id=@job_grade_id,passport=@passport WHERE staff_id=@staff_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@staff_id", register_staff_form.profile_id_combo.SelectedValue)
            command.Parameters.AddWithValue("@fullname", register_staff_form.fullname_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@email_address", register_staff_form.email_address_txt.Text)
            command.Parameters.AddWithValue("@phone_number", register_staff_form.phone_number_txt.Text)
            command.Parameters.AddWithValue("@branch_id", register_staff_form.branch_combo.SelectedValue)
            command.Parameters.AddWithValue("@role_id", register_staff_form.role_combo.SelectedValue)
            command.Parameters.AddWithValue("@status_id", register_staff_form.status_combo.SelectedValue)
            command.Parameters.AddWithValue("@department_id", register_staff_form.department_combo.SelectedValue)
            command.Parameters.AddWithValue("@job_grade_id", register_staff_form.job_grade_combo.SelectedValue)
            command.Parameters.AddWithValue("@passport", arrimage)
            reader = command.ExecuteReader
            connection.Close()

            MsgBox("User Update Successful !")
            clearFunction()
            getStaffID()
        Catch ex As Exception
            MessageBox.Show("User Upadate Failed:: " & ex.Message)
        End Try
    End Sub
    'to update branch
    Public Sub UpdateBranch()

        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "UPDATE branch_tab SET branch_name=@branch_name, branch_email_address=@branch_email_address, branch_phone_number=@branch_phone_number,branch_address=@branch_address, status_id=@status_id WHERE branch_id=@branch_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@branch_id", add_branch_form.branch_id_combo.SelectedValue)
            command.Parameters.AddWithValue("@branch_name", add_branch_form.branch_name_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@branch_email_address", add_branch_form.branch_email_address_txt.Text)
            command.Parameters.AddWithValue("@branch_phone_number", add_branch_form.branch_phone_number.Text)
            command.Parameters.AddWithValue("@branch_address", add_branch_form.branch_address.Text.ToUpper)
            command.Parameters.AddWithValue("@status_id", add_branch_form.status_combo.SelectedValue)

            reader = command.ExecuteReader
            connection.Close()

            MsgBox("User Update Successful !")
            clearFunction()
            getBranchID()
        Catch ex As Exception
            MessageBox.Show("User Upadate Failed:: " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateJobGrade()

        Try
            Dim connection = functions.connection
            Dim query As String

            Dim basic_salary, bonus, commission, allowance, tax, total_payment, tax_rate As Decimal
            basic_salary = add_job_grade.basic_salary_txt.Text
            commission = add_job_grade.commission_txt.Text
            bonus = add_job_grade.bonus_txt.Text
            allowance = add_job_grade.allowance_txt.Text
            tax_rate = add_job_grade.tax_txt.Text
            tax = (tax_rate / 100) * basic_salary
            total_payment = (basic_salary + commission + bonus + allowance) - tax

            connection.Open()
            query = "UPDATE job_grade_tab SET job_grade_name=@job_grade_name, basic_salary=@basic_salary, allowance=@allowance,bonus=@bonus,commission=@commission,tax=@tax,total_payment =@total_payment  WHERE job_grade_id=@job_grade_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@job_grade_id", add_job_grade.job_id_combo.SelectedValue)
            command.Parameters.AddWithValue("@job_grade_name", add_job_grade.job_grade_name_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@basic_salary", basic_salary)
            command.Parameters.AddWithValue("@allowance", allowance)
            command.Parameters.AddWithValue("@bonus", bonus)
            command.Parameters.AddWithValue("@commission", commission)
            command.Parameters.AddWithValue("@tax", tax_rate)
            command.Parameters.AddWithValue("@total_payment", total_payment)

            reader = command.ExecuteReader
            connection.Close()

            MsgBox("Job Grade Update Successful !")
            clearFunction()
            getJobGradeID()
        Catch ex As Exception
            MessageBox.Show("Job Grade Upadate Failed:: " & ex.Message)
        End Try
    End Sub
    'to update department
    Public Sub UpdateDepartment()

        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "UPDATE department_tab SET department_name=@department_name, status_id=@status_id WHERE department_id=@department_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@department_id", add_department.dept_id_combo.SelectedValue)
            command.Parameters.AddWithValue("@department_name", add_department.dept_name_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@status_id", add_branch_form.status_combo.SelectedValue)

            reader = command.ExecuteReader
            connection.Close()

            MsgBox("Department Update Successful !")
            clearFunction()
            getDeptID()
        Catch ex As Exception
            MessageBox.Show("Department Upadate Failed:: " & ex.Message)
        End Try
    End Sub
    'check for email duplication or resuse during update
    Function UpdateemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM staffs_tab WHERE email_address=@email_address AND staff_id!=@staff_id", connection)
        command.Parameters.AddWithValue("@email_address", email)
        command.Parameters.AddWithValue("@staff_id", register_staff_form.profile_id_combo.SelectedValue)
        reader = command.ExecuteReader
        Dim validateEmail = reader.Read()
        connection.Close()
        Return validateEmail
    End Function

    Function branchUpdateemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM branch_tab WHERE branch_email_address=@branch_email_address AND branch_id!=@branch_id", connection)
        command.Parameters.AddWithValue("@branch_email_address", email)
        command.Parameters.AddWithValue("@branch_id", add_branch_form.branch_id_combo.SelectedValue)
        reader = command.ExecuteReader
        Dim validateEmail = reader.Read()
        connection.Close()
        Return validateEmail
    End Function

    Function RegistrationemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM staffs_tab WHERE email_address=@email_address", connection)
        command.Parameters.AddWithValue("@email_address", email)
        reader = command.ExecuteReader
        Dim validateEmail = reader.Read()
        connection.Close()
        Return validateEmail
    End Function

    Function branchemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM branch_tab WHERE branch_email_address=@branch_email_address", connection)
        command.Parameters.AddWithValue("@branch_email_address", email)
        reader = command.ExecuteReader
        Dim validateEmail = reader.Read()
        connection.Close()
        Return validateEmail
    End Function

    Function jobgradeCheck(ByVal name As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT job_grade_name FROM job_grade_tab WHERE job_grade_name = @job_grade_name", connection)
        command.Parameters.AddWithValue("@job_grade_name", name)
        reader = command.ExecuteReader
        Dim validateJB = reader.Read()
        connection.Close()
        Return validateJB
    End Function


    Function branchCheck(ByVal name As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT branch_name FROM branch_tab WHERE branch_name = @branch_name", connection)
        command.Parameters.AddWithValue("@branch_name", name)
        reader = command.ExecuteReader
        Dim validateJB = reader.Read()
        connection.Close()
        Return validateJB
    End Function

    Function DeptCheck(ByVal name As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT department_name FROM department_tab WHERE department_name = @department_name", connection)
        command.Parameters.AddWithValue("@department_name", name)
        reader = command.ExecuteReader
        Dim validateJB = reader.Read()
        connection.Close()
        Return validateJB
    End Function

    Function UpdateJobGradeCheck(ByVal name As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT job_grade_name FROM job_grade_tab WHERE job_grade_name=@job_grade_name AND job_grade_id!=@job_grade_id", connection)
        command.Parameters.AddWithValue("@job_grade_name", name)
        command.Parameters.AddWithValue("@job_grade_id", add_job_grade.job_id_combo.SelectedValue)
        reader = command.ExecuteReader
        Dim validateJB = reader.Read()
        connection.Close()
        Return validateJB
    End Function


    Function UpdateBranchCheck(ByVal name As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT branch_name FROM branch_tab WHERE branch_name=@branch_name AND branch_id!=@branch_id", connection)
        command.Parameters.AddWithValue("@branch_name", name)
        command.Parameters.AddWithValue("@branch_id", add_branch_form.branch_id_combo.SelectedValue)
        reader = command.ExecuteReader
        Dim validateJB = reader.Read()
        connection.Close()
        Return validateJB
    End Function

    Function UpdateDeptCheck(ByVal name As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT department_name FROM department_tab WHERE department_name=@department_name AND department_id!=@department_id", connection)
        command.Parameters.AddWithValue("@department_name", name)
        command.Parameters.AddWithValue("@department_id", add_department.dept_id_combo.SelectedValue)
        reader = command.ExecuteReader
        Dim validateJB = reader.Read()
        connection.Close()
        Return validateJB
    End Function

    Public Sub dashDetails()
        GetRecordCount()
        GetRecordCountBranch()

        Dim result = functions.getStaffProfile(login_form.login_staff_id)
        Dim arrimage() As Byte = result.item3
        admin_dashboard.role_id_lbl.Text = result.item4.ToString
        admin_dashboard.staff_fullname_lbl.Text = result.item1.ToString
        admin_dashboard.last_login_lbl.Text = "Last Login Date:" & " " & result.item2.ToString
        Dim mstream = New MemoryStream(arrimage)
        admin_dashboard.admin_passport.Image = Image.FromStream(mstream)

    End Sub

    Public Sub dashDetails2()


        Dim result = functions.getStaffProfile(staff_login_form.login_staff_id)
        Dim arrimage() As Byte = result.item3
        admin_dashboard.role_id_lbl.Text = result.item4.ToString
        admin_dashboard.staff_fullname_lbl.Text = result.item1.ToString
        admin_dashboard.last_login_lbl.Text = "Last Login Date:" & " " & result.item2.ToString
        Dim mstream = New MemoryStream(arrimage)
        admin_dashboard.admin_passport.Image = Image.FromStream(mstream)





        staff_dashboard.role_id_lbl.Text = result.item4.ToString
        staff_dashboard.staff_fullname_lbl.Text = result.item1.ToString
        staff_dashboard.last_login_lbl.Text = "Last Login Date:" & " " & result.item2.ToString
        staff_dashboard.admin_passport.Image = Image.FromStream(mstream)

    End Sub

    Public Sub payroll()
        Try
            Dim payroll_Id As String = "PAY00" & functions.countId("PAY00")

            Dim connection = functions.connection
            connection.Open()

            Dim month_id As Integer = staffs_payroll_form.month_combo.SelectedValue
            Dim year_id As Integer = staffs_payroll_form.year_combo.SelectedValue

            ' Security Check: Verify if payroll already exists for the selected month and year
            Dim checkQuery As String = "SELECT COUNT(*) FROM payroll_tab WHERE month_id = @month_id AND year_id = @year_id;"
            Dim checkCommand As New MySqlCommand(checkQuery, connection)
            checkCommand.Parameters.AddWithValue("@month_id", month_id)
            checkCommand.Parameters.AddWithValue("@year_id", year_id)

            Dim exists As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
            If exists > 0 Then
                MsgBox("Payroll already exists for the selected month and year.")
                connection.Close()
                Exit Sub
            End If

            ' Step 1: Fetch total sum of total_payment for active staff
            Dim sumQuery As String = "SELECT SUM(total_payment) FROM job_grade_tab a, staffs_tab b WHERE a.job_grade_id = b.job_grade_id AND b.status_id = 1;"
            Dim sumCommand As New MySqlCommand(sumQuery, connection)

            Dim totalSum As Object = sumCommand.ExecuteScalar()
            Dim totalPayment As Decimal = If(IsDBNull(totalSum), 0, Convert.ToDecimal(totalSum))

            ' Step 2: Insert into payroll_tab
            Dim insertQuery As String = "INSERT INTO payroll_tab (payroll_id, month_id, year_id, total_payment) VALUES (@payroll_id, @month_id, @year_id, @total_payment);"
            Dim Command As New MySqlCommand(insertQuery, connection)
            Command.Parameters.AddWithValue("@payroll_id", payroll_Id)
            Command.Parameters.AddWithValue("@month_id", month_id)
            Command.Parameters.AddWithValue("@year_id", year_id)
            Command.Parameters.AddWithValue("@total_payment", totalPayment)
            Command.ExecuteNonQuery()

            Dim statusUpdateQuery As String = "UPDATE payroll_tab SET status_id=@status_id WHERE payroll_id=@payroll_id"
            Dim Commands As New MySqlCommand(statusUpdateQuery, connection)
            Commands.Parameters.AddWithValue("@payroll_id", payroll_Id)
            Commands.Parameters.AddWithValue("@status_id", 4)

            Commands.ExecuteNonQuery()

            connection.Close()
            MsgBox("Payroll registration successful!")
            payHistoryTab()
            clearFunction()
            getJobGradeID()

        Catch ex As Exception
            MsgBox("Payroll registration failed: " & ex.Message)
        End Try
    End Sub

    Public Sub payHistoryTab()
        Try
            Dim connection = functions.connection
            connection.Open()

            Dim month_id As Integer = staffs_payroll_form.month_combo.SelectedValue
            Dim year_id As Integer = staffs_payroll_form.year_combo.SelectedValue

            Dim callquery As String = "SELECT a.payroll_id, a.month_id, a.year_id, a.status_id, b.staff_id, b.fullname, c.total_payment FROM payroll_tab a, staffs_tab b, job_grade_tab c WHERE a.month_id = @month_id AND a.year_id = @year_id AND b.job_grade_id = c.job_grade_id AND b.status_id = 1;"

            Dim callCommand As New MySqlCommand(callquery, connection)
            callCommand.Parameters.AddWithValue("@month_id", month_id)
            callCommand.Parameters.AddWithValue("@year_id", year_id)

            Dim reader As MySqlDataReader = callCommand.ExecuteReader()

            Dim payrollList As New List(Of Tuple(Of String, String, String, Integer, Decimal))

            While reader.Read()
                Dim payroll_id As String = reader("payroll_id").ToString()
                Dim staff_id As String = reader("staff_id").ToString()
                Dim fullname As String = reader("fullname").ToString()
                Dim status_id As Integer = reader("status_id").ToString()
                Dim total_payment As Decimal = Convert.ToDecimal(reader("total_payment"))

                payrollList.Add(Tuple.Create(payroll_id, staff_id, fullname, status_id, total_payment))
            End While

            reader.Close()

            For Each record In payrollList
                Dim insertQuery As String = "INSERT INTO payroll_breakdown (payroll_id, month_id, year_id, staff_id, fullname, status_id, total_payment) VALUES (@payroll_id, @month_id, @year_id, @staff_id, @fullname,@status_id, @total_payment);"

                Dim insertCommand As New MySqlCommand(insertQuery, connection)
                insertCommand.Parameters.AddWithValue("@payroll_id", record.Item1)
                insertCommand.Parameters.AddWithValue("@month_id", month_id)
                insertCommand.Parameters.AddWithValue("@year_id", year_id)
                insertCommand.Parameters.AddWithValue("@staff_id", record.Item2)
                insertCommand.Parameters.AddWithValue("@fullname", record.Item3)
                insertCommand.Parameters.AddWithValue("@status_id", record.Item4)
                insertCommand.Parameters.AddWithValue("@total_payment", record.Item5)

                insertCommand.ExecuteNonQuery()
            Next

            connection.Close()
            MsgBox("Payroll history records inserted successfully!")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub staffPaymentRecord()
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = functions.connection

            Dim command As New MySqlCommand("SELECT a.payroll_id, b.month_name, a.year_id, a.staff_id, a.fullname, a.total_payment, c.status_name FROM payroll_breakdown a, setup_months_tab b, setup_status_tab c WHERE a.month_id=b.month_id AND a.status_id=c.status_id AND a.month_id = @month_id AND a.year_id=@year_id;", connection)

            command.Parameters.AddWithValue("@month_id", view_payment_breakdown.month_combo.SelectedValue)
            command.Parameters.AddWithValue("@year_id", view_payment_breakdown.year_combo.SelectedValue)

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            view_payment_breakdown.view_breakdown_list.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("payroll_id").ToString())
                listItem.SubItems.Add(row("month_name").ToString())
                listItem.SubItems.Add(row("year_id").ToString())
                listItem.SubItems.Add(row("staff_id").ToString())
                listItem.SubItems.Add(row("fullname").ToString())
                listItem.SubItems.Add(row("total_payment").ToString())
                listItem.SubItems.Add(row("status_name").ToString())


                view_payment_breakdown.view_breakdown_list.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Public Sub PaymentOveride()
        Try
            Dim month_id As Integer = view_payment_breakdown.month_combo.SelectedValue
            Dim year_id As Integer = view_payment_breakdown.year_combo.SelectedValue

            Dim connection = functions.connection

            connection.Open()
            ' Step 1: Fetch total sum of total_payment for active staff
            Dim sumQuery As String = "SELECT SUM(total_payment) FROM job_grade_tab a, staffs_tab b WHERE a.job_grade_id = b.job_grade_id AND b.status_id = 1;"
            Dim sumCommand As New MySqlCommand(sumQuery, connection)
            Dim totalSum As Object = sumCommand.ExecuteScalar()
            Dim totalPayment As Decimal = If(IsDBNull(totalSum), 0, Convert.ToDecimal(totalSum))

            ' Step 2: Update into payroll_tab
            Dim updateQuery As String = "UPDATE payroll_tab SET total_payment = @total_payment WHERE month_id = @month_id AND year_id = @year_id;"

            Dim Command As New MySqlCommand(updateQuery, connection)
            Command.Parameters.AddWithValue("@month_id", month_id)
            Command.Parameters.AddWithValue("@year_id", year_id)
            Command.Parameters.AddWithValue("@total_payment", totalPayment)
            Command.ExecuteNonQuery()
            connection.close()


            ' Delete payroll_breakdown records for selected month and year
            connection.Open()
            Dim deleteCommand As New MySqlCommand("DELETE FROM payroll_breakdown WHERE month_id = @month_id AND year_id = @year_id", connection)
            deleteCommand.Parameters.AddWithValue("@month_id", month_id)
            deleteCommand.Parameters.AddWithValue("@year_id", year_id)
            deleteCommand.ExecuteNonQuery()
            connection.Close()


            ' Recreate the records and update the ListView
            connection.Open()
            Dim callquery As String = "SELECT a.payroll_id, a.month_id, a.year_id, a.status_id, b.staff_id, b.fullname, c.total_payment FROM payroll_tab a, staffs_tab b, job_grade_tab c WHERE a.month_id = @month_id AND a.year_id = @year_id AND b.job_grade_id = c.job_grade_id AND b.status_id = 1;"
            Dim callCommand As New MySqlCommand(callquery, connection)
            callCommand.Parameters.AddWithValue("@month_id", month_id)
            callCommand.Parameters.AddWithValue("@year_id", year_id)
            Dim reader As MySqlDataReader = callCommand.ExecuteReader()
            Dim payrollList As New List(Of Tuple(Of String, String, String, Integer, Decimal))

            While reader.Read()
                Dim payroll_id As String = reader("payroll_id").ToString()
                Dim staff_id As String = reader("staff_id").ToString()
                Dim fullname As String = reader("fullname").ToString()
                Dim status_id As Integer = reader("status_id").ToString()
                Dim total_payment As Decimal = Convert.ToDecimal(reader("total_payment"))

                payrollList.Add(Tuple.Create(payroll_id, staff_id, fullname, status_id, total_payment))
            End While

            reader.Close()

            For Each record In payrollList
                Dim insertQuery As String = "INSERT INTO payroll_breakdown (payroll_id, month_id, year_id, staff_id, fullname, status_id, total_payment) VALUES (@payroll_id, @month_id, @year_id, @staff_id, @fullname,@status_id, @total_payment);"

                Dim insertCommand As New MySqlCommand(insertQuery, connection)
                insertCommand.Parameters.AddWithValue("@payroll_id", record.Item1)
                insertCommand.Parameters.AddWithValue("@month_id", month_id)
                insertCommand.Parameters.AddWithValue("@year_id", year_id)
                insertCommand.Parameters.AddWithValue("@staff_id", record.Item2)
                insertCommand.Parameters.AddWithValue("@fullname", record.Item3)
                insertCommand.Parameters.AddWithValue("@status_id", record.Item4)
                insertCommand.Parameters.AddWithValue("@total_payment", record.Item5)

                insertCommand.ExecuteNonQuery()
            Next

            connection.Close()
            MsgBox("Payment records overridden successfully.")

            staffPaymentRecord()



        Catch ex As Exception
            MsgBox("Error overriding payment records: " & ex.Message)
        End Try
    End Sub


    Public Sub ViewAllStaffRecords()
        getStaffID()
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = functions.connection


            Dim command As New MySqlCommand("SELECT a.staff_id, a.fullname, b.role_name, c.status_name, d.branch_name, e.department_name, f.job_grade_name FROM staffs_tab a, setup_role_tab b, setup_status_tab c, branch_tab d, department_tab e, job_grade_tab f WHERE  a.role_id = b.role_id AND a.status_id = c.status_id AND a.branch_id = d.branch_id AND a.department_id = e.department_id AND a.job_grade_id = f.job_grade_id;", connection)



            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            view_staff_records.staff_record.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("staff_id").ToString())
                listItem.SubItems.Add(row("fullname").ToString())
                listItem.SubItems.Add(row("role_name").ToString())
                listItem.SubItems.Add(row("status_name").ToString())
                listItem.SubItems.Add(row("branch_name").ToString())
                listItem.SubItems.Add(row("department_name").ToString())
                listItem.SubItems.Add(row("job_grade_name").ToString())

                view_staff_records.staff_record.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function total_payment() As Object
        Throw New NotImplementedException
    End Function

End Module
