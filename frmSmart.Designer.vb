<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmart
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.lblSavings = New System.Windows.Forms.Label()
        Me.lblAverageSavings = New System.Windows.Forms.Label()
        Me.lblMaxSavings = New System.Windows.Forms.Label()
        Me.btnStatistics = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SmartHomeApplication.My.Resources.Resources.smarthome
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 276)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(321, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 58)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Smart Home" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electric Savings"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboMonths
        '
        Me.cboMonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(326, 185)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(195, 32)
        Me.cboMonths.TabIndex = 2
        '
        'lblSavings
        '
        Me.lblSavings.AutoSize = True
        Me.lblSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavings.Location = New System.Drawing.Point(93, 295)
        Me.lblSavings.Name = "lblSavings"
        Me.lblSavings.Size = New System.Drawing.Size(333, 20)
        Me.lblSavings.TabIndex = 3
        Me.lblSavings.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'lblAverageSavings
        '
        Me.lblAverageSavings.AutoSize = True
        Me.lblAverageSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageSavings.Location = New System.Drawing.Point(93, 410)
        Me.lblAverageSavings.Name = "lblAverageSavings"
        Me.lblAverageSavings.Size = New System.Drawing.Size(333, 20)
        Me.lblAverageSavings.TabIndex = 4
        Me.lblAverageSavings.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'lblMaxSavings
        '
        Me.lblMaxSavings.AutoSize = True
        Me.lblMaxSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxSavings.Location = New System.Drawing.Point(93, 449)
        Me.lblMaxSavings.Name = "lblMaxSavings"
        Me.lblMaxSavings.Size = New System.Drawing.Size(333, 20)
        Me.lblMaxSavings.TabIndex = 5
        Me.lblMaxSavings.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStatistics.Location = New System.Drawing.Point(162, 338)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(212, 53)
        Me.btnStatistics.TabIndex = 6
        Me.btnStatistics.Text = "Display Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = False
        '
        'frmSmart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(565, 511)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.lblMaxSavings)
        Me.Controls.Add(Me.lblAverageSavings)
        Me.Controls.Add(Me.lblSavings)
        Me.Controls.Add(Me.cboMonths)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmSmart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SmartHomeApplication"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents lblSavings As Label
    Friend WithEvents lblAverageSavings As Label
    Friend WithEvents lblMaxSavings As Label
    Friend WithEvents btnStatistics As Button
End Class
