<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNames
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
        Me.lblNames = New System.Windows.Forms.Label()
        Me.btnName = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNames
        '
        Me.lblNames.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNames.Location = New System.Drawing.Point(12, 9)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(408, 55)
        Me.lblNames.TabIndex = 0
        Me.lblNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnName
        '
        Me.btnName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnName.Location = New System.Drawing.Point(147, 67)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(139, 40)
        Me.btnName.TabIndex = 1
        Me.btnName.Text = "Give Me a Name"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'frmNames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 122)
        Me.Controls.Add(Me.btnName)
        Me.Controls.Add(Me.lblNames)
        Me.Name = "frmNames"
        Me.Text = "Random Name Generator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNames As System.Windows.Forms.Label
    Friend WithEvents btnName As System.Windows.Forms.Button

End Class
