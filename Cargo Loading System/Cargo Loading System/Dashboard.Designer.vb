<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.sendCargoButton = New System.Windows.Forms.Button()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.SuspendLayout()
        '
        'logoutButton
        '
        Me.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutButton.ForeColor = System.Drawing.Color.Red
        Me.logoutButton.Location = New System.Drawing.Point(246, 11)
        Me.logoutButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(68, 27)
        Me.logoutButton.TabIndex = 0
        Me.logoutButton.Text = "Log-out"
        Me.logoutButton.UseVisualStyleBackColor = True
        '
        'sendCargoButton
        '
        Me.sendCargoButton.Font = New System.Drawing.Font("The Next Font", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendCargoButton.Location = New System.Drawing.Point(24, 77)
        Me.sendCargoButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.sendCargoButton.Name = "sendCargoButton"
        Me.sendCargoButton.Size = New System.Drawing.Size(290, 84)
        Me.sendCargoButton.TabIndex = 1
        Me.sendCargoButton.Text = "Send Cargo"
        Me.sendCargoButton.UseVisualStyleBackColor = True
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Century Gothic", 9.25!, System.Drawing.FontStyle.Bold)
        Me.nameLabel.ForeColor = System.Drawing.Color.White
        Me.nameLabel.Location = New System.Drawing.Point(35, 22)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(0, 16)
        Me.nameLabel.TabIndex = 2
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(336, 176)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.sendCargoButton)
        Me.Controls.Add(Me.logoutButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logoutButton As Button
    Friend WithEvents sendCargoButton As Button
    Friend WithEvents nameLabel As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
