<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise1
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
        Me.btnClick = New System.Windows.Forms.Button()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.Color.DimGray
        Me.btnClick.FlatAppearance.BorderSize = 0
        Me.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClick.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClick.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClick.Location = New System.Drawing.Point(131, 83)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(261, 70)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "Click Here"
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'lstOut
        '
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 25
        Me.lstOut.Location = New System.Drawing.Point(68, 223)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(381, 279)
        Me.lstOut.TabIndex = 1
        '
        'Exercise1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(526, 575)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.btnClick)
        Me.Name = "Exercise1"
        Me.Text = "For Loop Exercise"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClick As Button
    Friend WithEvents lstOut As ListBox
End Class
