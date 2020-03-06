<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise4
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.IndianRed
        Me.btnGo.FlatAppearance.BorderSize = 0
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGo.Location = New System.Drawing.Point(181, 96)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(215, 75)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'lstOut
        '
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 25
        Me.lstOut.Location = New System.Drawing.Point(64, 229)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(440, 279)
        Me.lstOut.TabIndex = 3
        '
        'Exercise4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 625)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Exercise4"
        Me.Text = "Do Loops"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents lstOut As ListBox
End Class
