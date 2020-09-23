<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmdIngresarD = New System.Windows.Forms.Button()
        Me.cmdTerminar = New System.Windows.Forms.Button()
        Me.ListBoxNames = New System.Windows.Forms.ListBox()
        Me.TextBoxNames = New System.Windows.Forms.TextBox()
        Me.btnForm3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdIngresarD
        '
        Me.cmdIngresarD.Location = New System.Drawing.Point(222, 64)
        Me.cmdIngresarD.Name = "cmdIngresarD"
        Me.cmdIngresarD.Size = New System.Drawing.Size(95, 45)
        Me.cmdIngresarD.TabIndex = 0
        Me.cmdIngresarD.Text = "Ingresar Datos"
        Me.cmdIngresarD.UseVisualStyleBackColor = True
        '
        'cmdTerminar
        '
        Me.cmdTerminar.Location = New System.Drawing.Point(399, 64)
        Me.cmdTerminar.Name = "cmdTerminar"
        Me.cmdTerminar.Size = New System.Drawing.Size(95, 45)
        Me.cmdTerminar.TabIndex = 1
        Me.cmdTerminar.Text = "Terminar"
        Me.cmdTerminar.UseVisualStyleBackColor = True
        '
        'ListBoxNames
        '
        Me.ListBoxNames.FormattingEnabled = True
        Me.ListBoxNames.Location = New System.Drawing.Point(137, 208)
        Me.ListBoxNames.Name = "ListBoxNames"
        Me.ListBoxNames.ScrollAlwaysVisible = True
        Me.ListBoxNames.Size = New System.Drawing.Size(180, 173)
        Me.ListBoxNames.TabIndex = 2
        '
        'TextBoxNames
        '
        Me.TextBoxNames.Location = New System.Drawing.Point(399, 208)
        Me.TextBoxNames.Multiline = True
        Me.TextBoxNames.Name = "TextBoxNames"
        Me.TextBoxNames.ReadOnly = True
        Me.TextBoxNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxNames.Size = New System.Drawing.Size(170, 173)
        Me.TextBoxNames.TabIndex = 3
        '
        'btnForm3
        '
        Me.btnForm3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnForm3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnForm3.Location = New System.Drawing.Point(685, 31)
        Me.btnForm3.Name = "btnForm3"
        Me.btnForm3.Size = New System.Drawing.Size(81, 32)
        Me.btnForm3.TabIndex = 4
        Me.btnForm3.Text = "Formulario 2"
        Me.btnForm3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(685, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Formulario 3"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnForm3)
        Me.Controls.Add(Me.TextBoxNames)
        Me.Controls.Add(Me.ListBoxNames)
        Me.Controls.Add(Me.cmdTerminar)
        Me.Controls.Add(Me.cmdIngresarD)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdIngresarD As Button
    Friend WithEvents cmdTerminar As Button
    Friend WithEvents ListBoxNames As ListBox
    Friend WithEvents TextBoxNames As TextBox
    Friend WithEvents btnForm3 As Button
    Friend WithEvents Button1 As Button
End Class
