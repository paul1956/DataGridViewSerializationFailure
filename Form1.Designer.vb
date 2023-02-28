<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    '<System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        DgvCareLinkUsers = New DataGridView()
        DataGridView2 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        CareLinkUserDataListBindingSource = New BindingSource(components)
        AutoLoginDataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        CareLinkPasswordDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        CareLinkUserNameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        CountryCodeDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        IDDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        UseLocalTimeZoneDataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        CType(DgvCareLinkUsers, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(CareLinkUserDataListBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvCareLinkUsers
        ' 
        DgvCareLinkUsers.AllowUserToAddRows = False
        DgvCareLinkUsers.AllowUserToResizeColumns = False
        DgvCareLinkUsers.AllowUserToResizeRows = False
        DgvCareLinkUsers.AutoGenerateColumns = False
        DgvCareLinkUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvCareLinkUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvCareLinkUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvCareLinkUsers.Columns.AddRange(New DataGridViewColumn() {AutoLoginDataGridViewCheckBoxColumn, CareLinkPasswordDataGridViewTextBoxColumn, CareLinkUserNameDataGridViewTextBoxColumn, CountryCodeDataGridViewTextBoxColumn, IDDataGridViewTextBoxColumn, UseLocalTimeZoneDataGridViewCheckBoxColumn})
        DgvCareLinkUsers.DataSource = CareLinkUserDataListBindingSource
        DgvCareLinkUsers.EditMode = DataGridViewEditMode.EditOnEnter
        DgvCareLinkUsers.Location = New Point(0, 0)
        DgvCareLinkUsers.Name = "DgvCareLinkUsers"
        DgvCareLinkUsers.RowTemplate.Height = 25
        DgvCareLinkUsers.SelectionMode = DataGridViewSelectionMode.CellSelect
        DgvCareLinkUsers.Size = New Size(800, 450)
        DataGridView2.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Column1"
        Column1.Name = "Column1" ' 
        ' Column2
        ' 
        Column2.HeaderText = "Column2"
        Column2.Name = "Column2" ' 
        ' CareLinkUserDataListBindingSource
        ' 
        CareLinkUserDataListBindingSource.DataSource = GetType(CareLinkUserDataList)
        ' 
        ' AutoLoginDataGridViewCheckBoxColumn
        ' 
        AutoLoginDataGridViewCheckBoxColumn.DataPropertyName = "AutoLogin"
        AutoLoginDataGridViewCheckBoxColumn.HeaderText = "Auto Login"
        AutoLoginDataGridViewCheckBoxColumn.Name = "AutoLoginDataGridViewCheckBoxColumn"
        AutoLoginDataGridViewCheckBoxColumn.Width = 72
        ' 
        ' CareLinkPasswordDataGridViewTextBoxColumn
        ' 
        CareLinkPasswordDataGridViewTextBoxColumn.DataPropertyName = "CareLinkPassword"
        CareLinkPasswordDataGridViewTextBoxColumn.HeaderText = "CareLink Password"
        CareLinkPasswordDataGridViewTextBoxColumn.Name = "CareLinkPasswordDataGridViewTextBoxColumn"
        CareLinkPasswordDataGridViewTextBoxColumn.Width = 120
        ' 
        ' CareLinkUserNameDataGridViewTextBoxColumn
        ' 
        CareLinkUserNameDataGridViewTextBoxColumn.DataPropertyName = "CareLinkUserName"
        CareLinkUserNameDataGridViewTextBoxColumn.HeaderText = "CareLink UserName"
        CareLinkUserNameDataGridViewTextBoxColumn.Name = "CareLinkUserNameDataGridViewTextBoxColumn"
        CareLinkUserNameDataGridViewTextBoxColumn.Width = 124
        ' 
        ' CountryCodeDataGridViewTextBoxColumn
        ' 
        CountryCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryCode"
        CountryCodeDataGridViewTextBoxColumn.HeaderText = "Country Code"
        CountryCodeDataGridViewTextBoxColumn.Name = "CountryCodeDataGridViewTextBoxColumn"
        CountryCodeDataGridViewTextBoxColumn.Width = 97
        ' 
        ' IDDataGridViewTextBoxColumn
        ' 
        IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        IDDataGridViewTextBoxColumn.HeaderText = "Id"
        IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        IDDataGridViewTextBoxColumn.ReadOnly = True
        IDDataGridViewTextBoxColumn.Width = 42
        ' 
        ' UseLocalTimeZoneDataGridViewCheckBoxColumn
        ' 
        UseLocalTimeZoneDataGridViewCheckBoxColumn.DataPropertyName = "UseLocalTimeZone"
        UseLocalTimeZoneDataGridViewCheckBoxColumn.HeaderText = "Use Local Time Zone"
        UseLocalTimeZoneDataGridViewCheckBoxColumn.Name = "UseLocalTimeZoneDataGridViewCheckBoxColumn"
        UseLocalTimeZoneDataGridViewCheckBoxColumn.Width = 86
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToResizeColumns = False
        DataGridView2.AllowUserToResizeRows = False
        DataGridView2.AutoGenerateColumns = False
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {AutoLoginDataGridViewCheckBoxColumn.Clone, CareLinkPasswordDataGridViewTextBoxColumn.Clone, CareLinkUserNameDataGridViewTextBoxColumn.Clone, CountryCodeDataGridViewTextBoxColumn.Clone, IDDataGridViewTextBoxColumn.Clone, UseLocalTimeZoneDataGridViewCheckBoxColumn.Clone})
        DataGridView2.DataSource = CareLinkUserDataListBindingSource
        DataGridView2.EditMode = DataGridViewEditMode.EditOnEnter
        DataGridView2.Location = New Point(0, 0)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect
        DataGridView2.Size = New Size(800, 450)
        DataGridView2.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView2)
        Controls.Add(DgvCareLinkUsers)
        Name = "Form1"
        Text = "Form1"
        CType(DgvCareLinkUsers, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(CareLinkUserDataListBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CareLinkUserDataRecordBindingSource As BindingSource
    Friend WithEvents DgvCareLinkUsers As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DgvCareLinkUsersUserID As DataGridViewTextBoxColumn
    Friend WithEvents DgvCareLinkUsersDeleteRow As DataGridViewButtonColumn
    Friend WithEvents DgvCareLinkUsersCareLinkUserName As DataGridViewTextBoxColumn
    Friend WithEvents DgvCareLinkUsersCareLinkPassword As DataGridViewTextBoxColumn
    Friend WithEvents DgvCareLinkUsersCountryCode As DataGridViewTextBoxColumn
    Friend WithEvents DgvCareLinkUsersUseLocalTimeZone As DataGridViewCheckBoxColumn
    Friend WithEvents DgvCareLinkUsersAutoLogin As DataGridViewCheckBoxColumn
    Friend WithEvents AutoLoginDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CareLinkPasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CareLinkUserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UseLocalTimeZoneDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CareLinkUserDataListBindingSource As BindingSource
End Class
