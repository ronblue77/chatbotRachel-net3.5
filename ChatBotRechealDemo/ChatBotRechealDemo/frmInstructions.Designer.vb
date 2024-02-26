<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInstructions
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
        Me.rtbInstructiions = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtbInstructiions
        '
        Me.rtbInstructiions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbInstructiions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.rtbInstructiions.Location = New System.Drawing.Point(0, 0)
        Me.rtbInstructiions.Name = "rtbInstructiions"
        Me.rtbInstructiions.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbInstructiions.Size = New System.Drawing.Size(685, 626)
        Me.rtbInstructiions.TabIndex = 0
        Me.rtbInstructiions.Text = ""
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 626)
        Me.Controls.Add(Me.rtbInstructiions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(701, 665)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(701, 665)
        Me.Name = "frmInstructions"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbInstructiions As RichTextBox
End Class
