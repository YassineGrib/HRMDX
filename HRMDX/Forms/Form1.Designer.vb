Partial Public Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateOfJoining = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SvgImageBox3 = New DevExpress.XtraEditors.SvgImageBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SvgImageBox2 = New DevExpress.XtraEditors.SvgImageBox()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationFrame1.SuspendLayout()
        Me.NavigationPage2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SvgImageBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SvgImageBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 60
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.Empty
        Me.Guna2Shapes1.BorderThickness = 0
        Me.Guna2Shapes1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Guna2Shapes1.LineThickness = 1
        Me.Guna2Shapes1.Location = New System.Drawing.Point(62, 0)
        Me.Guna2Shapes1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.RoundedRadius = 40
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded
        Me.Guna2Shapes1.Size = New System.Drawing.Size(962, 550)
        Me.Guna2Shapes1.TabIndex = 2
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 100
        '
        'NavigationFrame1
        '
        Me.NavigationFrame1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.NavigationFrame1.Appearance.Options.UseBackColor = True
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage1)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage2)
        Me.NavigationFrame1.Location = New System.Drawing.Point(79, 12)
        Me.NavigationFrame1.Name = "NavigationFrame1"
        Me.NavigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationFrame1.SelectedPage = Me.NavigationPage1
        Me.NavigationFrame1.Size = New System.Drawing.Size(933, 526)
        Me.NavigationFrame1.TabIndex = 3
        Me.NavigationFrame1.Text = "NavigationFrame1"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.NavigationPage1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.NavigationPage1.Appearance.Options.UseBackColor = True
        Me.NavigationPage1.Appearance.Options.UseBorderColor = True
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(933, 526)
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.NavigationPage2.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.NavigationPage2.Appearance.Options.UseBackColor = True
        Me.NavigationPage2.Appearance.Options.UseBorderColor = True
        Me.NavigationPage2.Controls.Add(Me.GridControl1)
        Me.NavigationPage2.Controls.Add(Me.SvgImageBox3)
        Me.NavigationPage2.Controls.Add(Me.Label18)
        Me.NavigationPage2.Controls.Add(Me.Guna2Button1)
        Me.NavigationPage2.Controls.Add(Me.Guna2Button4)
        Me.NavigationPage2.Controls.Add(Me.Guna2Button5)
        Me.NavigationPage2.Controls.Add(Me.Guna2Button6)
        Me.NavigationPage2.Controls.Add(Me.Guna2Button7)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(933, 526)
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Query"
        Me.GridControl1.DataSource = Me.SqlDataSource1
        Me.GridControl1.Location = New System.Drawing.Point(3, 130)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(927, 339)
        Me.GridControl1.TabIndex = 160
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "HEMDB.mdf"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "Query"
        CustomSqlQuery1.Sql = "select EmployeeID, CONCAT(FirstName, ' ', LastName) AS FullName    , Phone, Depar" &
    "tment, Designation, DateOfJoining, Status, Salary from Employees_TBL"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmployeeID, Me.colFullName, Me.colPhone, Me.colDepartment, Me.colDesignation, Me.colDateOfJoining, Me.colStatus, Me.colSalary})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colEmployeeID
        '
        Me.colEmployeeID.FieldName = "EmployeeID"
        Me.colEmployeeID.Name = "colEmployeeID"
        Me.colEmployeeID.Visible = True
        Me.colEmployeeID.VisibleIndex = 0
        '
        'colFullName
        '
        Me.colFullName.FieldName = "FullName"
        Me.colFullName.Name = "colFullName"
        Me.colFullName.Visible = True
        Me.colFullName.VisibleIndex = 1
        '
        'colPhone
        '
        Me.colPhone.FieldName = "Phone"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.Visible = True
        Me.colPhone.VisibleIndex = 2
        '
        'colDepartment
        '
        Me.colDepartment.FieldName = "Department"
        Me.colDepartment.Name = "colDepartment"
        Me.colDepartment.Visible = True
        Me.colDepartment.VisibleIndex = 3
        '
        'colDesignation
        '
        Me.colDesignation.FieldName = "Designation"
        Me.colDesignation.Name = "colDesignation"
        Me.colDesignation.Visible = True
        Me.colDesignation.VisibleIndex = 4
        '
        'colDateOfJoining
        '
        Me.colDateOfJoining.FieldName = "DateOfJoining"
        Me.colDateOfJoining.Name = "colDateOfJoining"
        Me.colDateOfJoining.Visible = True
        Me.colDateOfJoining.VisibleIndex = 5
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 7
        '
        'colSalary
        '
        Me.colSalary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSalary.FieldName = "Salary"
        Me.colSalary.Name = "colSalary"
        Me.colSalary.Visible = True
        Me.colSalary.VisibleIndex = 6
        '
        'SvgImageBox3
        '
        Me.SvgImageBox3.BackColor = System.Drawing.Color.Transparent
        Me.SvgImageBox3.Location = New System.Drawing.Point(1, 18)
        Me.SvgImageBox3.Name = "SvgImageBox3"
        Me.SvgImageBox3.Size = New System.Drawing.Size(25, 25)
        Me.SvgImageBox3.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom
        Me.SvgImageBox3.SvgImage = CType(resources.GetObject("SvgImageBox3.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SvgImageBox3.TabIndex = 159
        Me.SvgImageBox3.Text = "SvgImageBox3"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Tw Cen MT Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(31, 19)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 22)
        Me.Label18.TabIndex = 158
        Me.Label18.Text = "Emloyees "
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Guna2Button1.BorderRadius = 15
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(533, 2)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(153, 57)
        Me.Guna2Button1.TabIndex = 157
        Me.Guna2Button1.Text = "Add employee"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Guna2Button4.BorderRadius = 10
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Tw Cen MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Image = CType(resources.GetObject("Guna2Button4.Image"), System.Drawing.Image)
        Me.Guna2Button4.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button4.Location = New System.Drawing.Point(690, 2)
        Me.Guna2Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(57, 57)
        Me.Guna2Button4.TabIndex = 156
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Animated = True
        Me.Guna2Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Guna2Button5.BorderRadius = 10
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Button5.Font = New System.Drawing.Font("Tw Cen MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.Image = CType(resources.GetObject("Guna2Button5.Image"), System.Drawing.Image)
        Me.Guna2Button5.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button5.Location = New System.Drawing.Point(751, 2)
        Me.Guna2Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(57, 57)
        Me.Guna2Button5.TabIndex = 155
        '
        'Guna2Button6
        '
        Me.Guna2Button6.Animated = True
        Me.Guna2Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Guna2Button6.BorderRadius = 10
        Me.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button6.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Guna2Button6.Font = New System.Drawing.Font("Tw Cen MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.White
        Me.Guna2Button6.Image = CType(resources.GetObject("Guna2Button6.Image"), System.Drawing.Image)
        Me.Guna2Button6.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button6.Location = New System.Drawing.Point(873, 2)
        Me.Guna2Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(57, 57)
        Me.Guna2Button6.TabIndex = 154
        '
        'Guna2Button7
        '
        Me.Guna2Button7.Animated = True
        Me.Guna2Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Guna2Button7.BorderRadius = 10
        Me.Guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button7.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Button7.Font = New System.Drawing.Font("Tw Cen MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button7.ForeColor = System.Drawing.Color.White
        Me.Guna2Button7.Image = CType(resources.GetObject("Guna2Button7.Image"), System.Drawing.Image)
        Me.Guna2Button7.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button7.Location = New System.Drawing.Point(812, 2)
        Me.Guna2Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button7.Name = "Guna2Button7"
        Me.Guna2Button7.Size = New System.Drawing.Size(57, 57)
        Me.Guna2Button7.TabIndex = 153
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton2.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Appearance.Options.UseBorderColor = True
        Me.SimpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton2.ImageOptions.SvgImageSize = New System.Drawing.Size(40, 40)
        Me.SimpleButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SimpleButton2.Location = New System.Drawing.Point(7, 136)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SimpleButton2.Size = New System.Drawing.Size(50, 50)
        Me.SimpleButton2.TabIndex = 4
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton3.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Appearance.Options.UseBorderColor = True
        Me.SimpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton3.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton3.ImageOptions.SvgImageSize = New System.Drawing.Size(40, 40)
        Me.SimpleButton3.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.SimpleButton3.Location = New System.Drawing.Point(7, 488)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SimpleButton3.Size = New System.Drawing.Size(50, 50)
        Me.SimpleButton3.TabIndex = 5
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton4.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton4.Appearance.Options.UseBackColor = True
        Me.SimpleButton4.Appearance.Options.UseBorderColor = True
        Me.SimpleButton4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton4.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton4.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton4.ImageOptions.SvgImageSize = New System.Drawing.Size(40, 40)
        Me.SimpleButton4.Location = New System.Drawing.Point(7, 361)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SimpleButton4.Size = New System.Drawing.Size(50, 50)
        Me.SimpleButton4.TabIndex = 6
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton5.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton5.Appearance.Options.UseBackColor = True
        Me.SimpleButton5.Appearance.Options.UseBorderColor = True
        Me.SimpleButton5.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton5.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton5.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton5.ImageOptions.SvgImageSize = New System.Drawing.Size(40, 40)
        Me.SimpleButton5.Location = New System.Drawing.Point(7, 305)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SimpleButton5.Size = New System.Drawing.Size(50, 50)
        Me.SimpleButton5.TabIndex = 7
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton6.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton6.Appearance.Options.UseBackColor = True
        Me.SimpleButton6.Appearance.Options.UseBorderColor = True
        Me.SimpleButton6.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton6.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton6.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton6.ImageOptions.SvgImageSize = New System.Drawing.Size(40, 40)
        Me.SimpleButton6.Location = New System.Drawing.Point(7, 248)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SimpleButton6.Size = New System.Drawing.Size(50, 50)
        Me.SimpleButton6.TabIndex = 8
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton7.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton7.Appearance.Options.UseBackColor = True
        Me.SimpleButton7.Appearance.Options.UseBorderColor = True
        Me.SimpleButton7.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton7.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton7.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton7.ImageOptions.SvgImageSize = New System.Drawing.Size(40, 40)
        Me.SimpleButton7.Location = New System.Drawing.Point(7, 192)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SimpleButton7.Size = New System.Drawing.Size(50, 50)
        Me.SimpleButton7.TabIndex = 9
        '
        'SvgImageBox2
        '
        Me.SvgImageBox2.BackColor = System.Drawing.Color.White
        Me.SvgImageBox2.ForeColor = System.Drawing.Color.Transparent
        Me.SvgImageBox2.Location = New System.Drawing.Point(7, 12)
        Me.SvgImageBox2.Name = "SvgImageBox2"
        Me.SvgImageBox2.Size = New System.Drawing.Size(50, 50)
        Me.SvgImageBox2.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom
        Me.SvgImageBox2.SvgImage = CType(resources.GetObject("SvgImageBox2.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SvgImageBox2.TabIndex = 161
        Me.SvgImageBox2.Text = "SvgImageBox2"
        '
        'Form1
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1024, 550)
        Me.Controls.Add(Me.SvgImageBox2)
        Me.Controls.Add(Me.SimpleButton7)
        Me.Controls.Add(Me.SimpleButton6)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.NavigationFrame1)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IconOptions.SvgImage = CType(resources.GetObject("Form1.IconOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationFrame1.ResumeLayout(False)
        Me.NavigationPage2.ResumeLayout(False)
        Me.NavigationPage2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SvgImageBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SvgImageBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SvgImageBox3 As DevExpress.XtraEditors.SvgImageBox
    Friend WithEvents Label18 As Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateOfJoining As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SvgImageBox2 As DevExpress.XtraEditors.SvgImageBox

#End Region

End Class
