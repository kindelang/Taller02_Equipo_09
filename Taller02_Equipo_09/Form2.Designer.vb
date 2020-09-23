<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.container = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkNegrita = New System.Windows.Forms.CheckBox()
        Me.chkMayuscula = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optFuenteBlanco = New System.Windows.Forms.RadioButton()
        Me.optFuenteMagenta = New System.Windows.Forms.RadioButton()
        Me.optFuenteCyan = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optFondoAzul = New System.Windows.Forms.RadioButton()
        Me.optFondoRojo = New System.Windows.Forms.RadioButton()
        Me.optFondoVerde = New System.Windows.Forms.RadioButton()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.container.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'container
        '
        Me.container.BackColor = System.Drawing.SystemColors.Highlight
        Me.container.Controls.Add(Me.GroupBox3)
        Me.container.Controls.Add(Me.GroupBox2)
        Me.container.Controls.Add(Me.GroupBox1)
        Me.container.Location = New System.Drawing.Point(52, 65)
        Me.container.Name = "container"
        Me.container.Size = New System.Drawing.Size(693, 273)
        Me.container.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox3.Controls.Add(Me.chkNegrita)
        Me.GroupBox3.Controls.Add(Me.chkMayuscula)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(480, 50)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(147, 147)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones de Fuente"
        '
        'chkNegrita
        '
        Me.chkNegrita.AutoSize = True
        Me.chkNegrita.Location = New System.Drawing.Point(25, 67)
        Me.chkNegrita.Name = "chkNegrita"
        Me.chkNegrita.Size = New System.Drawing.Size(67, 17)
        Me.chkNegrita.TabIndex = 1
        Me.chkNegrita.Text = "Negrita"
        Me.chkNegrita.UseVisualStyleBackColor = True
        '
        'chkMayuscula
        '
        Me.chkMayuscula.AutoSize = True
        Me.chkMayuscula.Location = New System.Drawing.Point(25, 36)
        Me.chkMayuscula.Name = "chkMayuscula"
        Me.chkMayuscula.Size = New System.Drawing.Size(86, 17)
        Me.chkMayuscula.TabIndex = 0
        Me.chkMayuscula.Text = "Mayuscula"
        Me.chkMayuscula.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Menu
        Me.GroupBox2.Controls.Add(Me.optFuenteBlanco)
        Me.GroupBox2.Controls.Add(Me.optFuenteMagenta)
        Me.GroupBox2.Controls.Add(Me.optFuenteCyan)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(250, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(147, 147)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Color de Fuente"
        '
        'optFuenteBlanco
        '
        Me.optFuenteBlanco.Appearance = System.Windows.Forms.Appearance.Button
        Me.optFuenteBlanco.AutoSize = True
        Me.optFuenteBlanco.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.optFuenteBlanco.Location = New System.Drawing.Point(16, 104)
        Me.optFuenteBlanco.Name = "optFuenteBlanco"
        Me.optFuenteBlanco.Size = New System.Drawing.Size(56, 23)
        Me.optFuenteBlanco.TabIndex = 2
        Me.optFuenteBlanco.TabStop = True
        Me.optFuenteBlanco.Text = "Blanco"
        Me.optFuenteBlanco.UseVisualStyleBackColor = False
        '
        'optFuenteMagenta
        '
        Me.optFuenteMagenta.Appearance = System.Windows.Forms.Appearance.Button
        Me.optFuenteMagenta.AutoSize = True
        Me.optFuenteMagenta.BackColor = System.Drawing.Color.Fuchsia
        Me.optFuenteMagenta.Location = New System.Drawing.Point(16, 67)
        Me.optFuenteMagenta.Name = "optFuenteMagenta"
        Me.optFuenteMagenta.Size = New System.Drawing.Size(66, 23)
        Me.optFuenteMagenta.TabIndex = 1
        Me.optFuenteMagenta.TabStop = True
        Me.optFuenteMagenta.Text = "Magenta"
        Me.optFuenteMagenta.UseVisualStyleBackColor = False
        '
        'optFuenteCyan
        '
        Me.optFuenteCyan.Appearance = System.Windows.Forms.Appearance.Button
        Me.optFuenteCyan.AutoSize = True
        Me.optFuenteCyan.BackColor = System.Drawing.Color.Cyan
        Me.optFuenteCyan.Location = New System.Drawing.Point(16, 31)
        Me.optFuenteCyan.Name = "optFuenteCyan"
        Me.optFuenteCyan.Size = New System.Drawing.Size(45, 23)
        Me.optFuenteCyan.TabIndex = 0
        Me.optFuenteCyan.TabStop = True
        Me.optFuenteCyan.Text = "Cyan"
        Me.optFuenteCyan.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Controls.Add(Me.optFondoAzul)
        Me.GroupBox1.Controls.Add(Me.optFondoRojo)
        Me.GroupBox1.Controls.Add(Me.optFondoVerde)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color de Fondo"
        '
        'optFondoAzul
        '
        Me.optFondoAzul.AutoSize = True
        Me.optFondoAzul.ForeColor = System.Drawing.Color.Blue
        Me.optFondoAzul.Location = New System.Drawing.Point(16, 104)
        Me.optFondoAzul.Name = "optFondoAzul"
        Me.optFondoAzul.Size = New System.Drawing.Size(49, 17)
        Me.optFondoAzul.TabIndex = 2
        Me.optFondoAzul.TabStop = True
        Me.optFondoAzul.Text = "Azul"
        Me.optFondoAzul.UseVisualStyleBackColor = True
        '
        'optFondoRojo
        '
        Me.optFondoRojo.AutoSize = True
        Me.optFondoRojo.ForeColor = System.Drawing.Color.Red
        Me.optFondoRojo.Location = New System.Drawing.Point(16, 67)
        Me.optFondoRojo.Name = "optFondoRojo"
        Me.optFondoRojo.Size = New System.Drawing.Size(51, 17)
        Me.optFondoRojo.TabIndex = 1
        Me.optFondoRojo.TabStop = True
        Me.optFondoRojo.Text = "Rojo"
        Me.optFondoRojo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optFondoRojo.UseVisualStyleBackColor = True
        '
        'optFondoVerde
        '
        Me.optFondoVerde.AutoSize = True
        Me.optFondoVerde.BackColor = System.Drawing.Color.White
        Me.optFondoVerde.ForeColor = System.Drawing.Color.Green
        Me.optFondoVerde.Location = New System.Drawing.Point(16, 34)
        Me.optFondoVerde.Name = "optFondoVerde"
        Me.optFondoVerde.Size = New System.Drawing.Size(58, 17)
        Me.optFondoVerde.TabIndex = 0
        Me.optFondoVerde.TabStop = True
        Me.optFondoVerde.Text = "Verde"
        Me.optFondoVerde.UseVisualStyleBackColor = False
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(52, 22)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(292, 20)
        Me.txtTexto.TabIndex = 2
        Me.txtTexto.Text = "Texto a Cambiar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(491, 354)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Terminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(239, 354)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(687, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.container)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.container.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents container As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkNegrita As CheckBox
    Friend WithEvents chkMayuscula As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optFuenteBlanco As RadioButton
    Friend WithEvents optFuenteMagenta As RadioButton
    Friend WithEvents optFuenteCyan As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optFondoAzul As RadioButton
    Friend WithEvents optFondoRojo As RadioButton
    Friend WithEvents optFondoVerde As RadioButton
    Friend WithEvents txtTexto As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Button1 As Button
End Class
