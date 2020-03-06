<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise2
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
        Me.lstGrades = New System.Windows.Forms.ListBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstGrades
        '
        Me.lstGrades.FormattingEnabled = True
        Me.lstGrades.ItemHeight = 25
        Me.lstGrades.Location = New System.Drawing.Point(114, 266)
        Me.lstGrades.Name = "lstGrades"
        Me.lstGrades.Size = New System.Drawing.Size(381, 304)
        Me.lstGrades.TabIndex = 3
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.DimGray
        Me.btnCalc.FlatAppearance.BorderSize = 0
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalc.Location = New System.Drawing.Point(114, 116)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(381, 90)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate Average"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'Exercise2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 671)
        Me.Controls.Add(Me.lstGrades)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "Exercise2"
        Me.Text = "For Loop with Sum"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstGrades As ListBox
    Friend WithEvents btnCalc As Button
End Class
