<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VTgiris
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VTgiris))
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_userId = New System.Windows.Forms.TextBox()
        Me.txt_database = New System.Windows.Forms.TextBox()
        Me.txt_server = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.nud_port = New System.Windows.Forms.NumericUpDown()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.nud_port, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(112, 92)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_password.Size = New System.Drawing.Size(114, 20)
        Me.txt_password.TabIndex = 14
        Me.txt_password.Text = "3553Eopy"
        '
        'txt_userId
        '
        Me.txt_userId.Location = New System.Drawing.Point(112, 66)
        Me.txt_userId.Name = "txt_userId"
        Me.txt_userId.Size = New System.Drawing.Size(114, 20)
        Me.txt_userId.TabIndex = 13
        Me.txt_userId.Text = "sa"
        '
        'txt_database
        '
        Me.txt_database.Location = New System.Drawing.Point(112, 40)
        Me.txt_database.Name = "txt_database"
        Me.txt_database.Size = New System.Drawing.Size(114, 20)
        Me.txt_database.TabIndex = 12
        Me.txt_database.Text = "ENTEGRENET"
        '
        'txt_server
        '
        Me.txt_server.Location = New System.Drawing.Point(112, 14)
        Me.txt_server.Name = "txt_server"
        Me.txt_server.Size = New System.Drawing.Size(114, 20)
        Me.txt_server.TabIndex = 6
        Me.txt_server.Text = "localhost"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(53, 95)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(53, 13)
        Me.label4.TabIndex = 7
        Me.label4.Text = "Password"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(65, 69)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(41, 13)
        Me.label3.TabIndex = 8
        Me.label3.Text = "User Id"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(53, 43)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(53, 13)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Database"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(38, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(68, 13)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Server / Port"
        '
        'nud_port
        '
        Me.nud_port.Location = New System.Drawing.Point(232, 14)
        Me.nud_port.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nud_port.Name = "nud_port"
        Me.nud_port.Size = New System.Drawing.Size(62, 20)
        Me.nud_port.TabIndex = 15
        Me.nud_port.Value = New Decimal(New Integer() {1433, 0, 0, 0})
        '
        'btn_connect
        '
        Me.btn_connect.Location = New System.Drawing.Point(112, 118)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(114, 29)
        Me.btn_connect.TabIndex = 16
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'VTgiris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(302, 153)
        Me.Controls.Add(Me.btn_connect)
        Me.Controls.Add(Me.nud_port)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_userId)
        Me.Controls.Add(Me.txt_database)
        Me.Controls.Add(Me.txt_server)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VTgiris"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Netsis Stok Kartı"
        CType(Me.nud_port, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txt_password As System.Windows.Forms.TextBox
    Private WithEvents txt_userId As System.Windows.Forms.TextBox
    Private WithEvents txt_database As System.Windows.Forms.TextBox
    Private WithEvents txt_server As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents nud_port As System.Windows.Forms.NumericUpDown
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents btn_connect As System.Windows.Forms.Button

End Class
