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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        Btn_entra = New Button()
        Label2 = New Label()
        Usuario = New Label()
        Text_contra = New TextBox()
        Text_usuario = New TextBox()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Btn_entra)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Usuario)
        Panel1.Controls.Add(Text_contra)
        Panel1.Controls.Add(Text_usuario)
        Panel1.Location = New Point(298, 97)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(283, 340)
        Panel1.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(104, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 30)
        Label1.TabIndex = 12
        Label1.Text = "LOGIN"
        ' 
        ' Btn_entra
        ' 
        Btn_entra.BackColor = Color.IndianRed
        Btn_entra.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Btn_entra.FlatAppearance.BorderSize = 0
        Btn_entra.FlatAppearance.CheckedBackColor = Color.Red
        Btn_entra.FlatStyle = FlatStyle.Flat
        Btn_entra.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_entra.ForeColor = SystemColors.ButtonHighlight
        Btn_entra.Location = New Point(90, 284)
        Btn_entra.Name = "Btn_entra"
        Btn_entra.Size = New Size(113, 31)
        Btn_entra.TabIndex = 11
        Btn_entra.Text = "INGRESAR"
        Btn_entra.TextAlign = ContentAlignment.TopCenter
        Btn_entra.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(26, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 21)
        Label2.TabIndex = 10
        Label2.Text = "CONTRASEÑA" & vbCrLf
        ' 
        ' Usuario
        ' 
        Usuario.AutoSize = True
        Usuario.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Usuario.ForeColor = Color.Navy
        Usuario.Location = New Point(26, 102)
        Usuario.Name = "Usuario"
        Usuario.Size = New Size(228, 21)
        Usuario.TabIndex = 9
        Usuario.Text = "NUMERO DE IDENTIFICACION"
        ' 
        ' Text_contra
        ' 
        Text_contra.Location = New Point(26, 223)
        Text_contra.Name = "Text_contra"
        Text_contra.PasswordChar = "*"c
        Text_contra.Size = New Size(228, 23)
        Text_contra.TabIndex = 8
        ' 
        ' Text_usuario
        ' 
        Text_usuario.Location = New Point(26, 138)
        Text_usuario.Name = "Text_usuario"
        Text_usuario.Size = New Size(228, 23)
        Text_usuario.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BackgroundImage = My.Resources.Resources.Screenshot_INGECOSMO
        Panel2.Location = New Point(360, 33)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(166, 93)
        Panel2.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(898, 588)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_entra As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Usuario As Label
    Friend WithEvents Text_contra As TextBox
    Friend WithEvents Text_usuario As TextBox
    Friend WithEvents Panel2 As Panel
End Class
