<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetVBData
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
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.cmdPress = New System.Windows.Forms.Button()
        Me.cmdShowCode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(12, 12)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.Size = New System.Drawing.Size(539, 381)
        Me.txtDisplay.TabIndex = 2
        '
        'cmdPress
        '
        Me.cmdPress.Location = New System.Drawing.Point(449, 399)
        Me.cmdPress.Name = "cmdPress"
        Me.cmdPress.Size = New System.Drawing.Size(102, 23)
        Me.cmdPress.TabIndex = 3
        Me.cmdPress.Text = "Get Data"
        Me.cmdPress.UseVisualStyleBackColor = True
        '
        'cmdShowCode
        '
        Me.cmdShowCode.Location = New System.Drawing.Point(449, 428)
        Me.cmdShowCode.Name = "cmdShowCode"
        Me.cmdShowCode.Size = New System.Drawing.Size(102, 23)
        Me.cmdShowCode.TabIndex = 4
        Me.cmdShowCode.Text = "Show Code"
        Me.cmdShowCode.UseVisualStyleBackColor = True
        '
        'frmGetVBData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 459)
        Me.Controls.Add(Me.cmdShowCode)
        Me.Controls.Add(Me.cmdPress)
        Me.Controls.Add(Me.txtDisplay)
        Me.Name = "frmGetVBData"
        Me.Text = "VB.net Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtDisplay As System.Windows.Forms.TextBox
    Private WithEvents cmdPress As System.Windows.Forms.Button
    Private WithEvents cmdShowCode As System.Windows.Forms.Button

End Class
