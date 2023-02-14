<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_adultoRegistro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPolo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "dni"
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(190, 53)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 22)
        Me.txtDni.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(199, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(190, 122)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "nombres"
        '
        'txtCel
        '
        Me.txtCel.Location = New System.Drawing.Point(190, 190)
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(100, 22)
        Me.txtCel.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "celular"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(190, 265)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(100, 22)
        Me.txtDir.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "dirreccion"
        '
        'txtPolo
        '
        Me.txtPolo.Location = New System.Drawing.Point(190, 337)
        Me.txtPolo.Name = "txtPolo"
        Me.txtPolo.Size = New System.Drawing.Size(100, 22)
        Me.txtPolo.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "polo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 623)
        Me.Controls.Add(Me.txtPolo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDir As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPolo As TextBox
    Friend WithEvents Label5 As Label
End Class
