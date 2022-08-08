<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIndexScreen
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
        Me.PnlValue = New System.Windows.Forms.Panel()
        Me.TxtValue = New System.Windows.Forms.TextBox()
        Me.PnlInput = New System.Windows.Forms.Panel()
        Me.TxtIndex = New System.Windows.Forms.TextBox()
        Me.BtnInput = New System.Windows.Forms.Button()
        Me.BtnChange = New System.Windows.Forms.Button()
        Me.BtnCompute = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.LblIndex = New System.Windows.Forms.Label()
        Me.LblValue = New System.Windows.Forms.Label()
        Me.LblData = New System.Windows.Forms.Label()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.TxtData = New System.Windows.Forms.TextBox()
        Me.pbxNPDC = New System.Windows.Forms.PictureBox()
        Me.BtnShowNPDC = New System.Windows.Forms.Button()
        Me.PnlNPDC = New System.Windows.Forms.Panel()
        Me.LblNPDC = New System.Windows.Forms.Label()
        Me.PnlValue.SuspendLayout()
        Me.PnlInput.SuspendLayout()
        Me.PnlData.SuspendLayout()
        CType(Me.pbxNPDC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlNPDC.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlValue
        '
        Me.PnlValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PnlValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlValue.Controls.Add(Me.TxtValue)
        Me.PnlValue.Enabled = False
        Me.PnlValue.Location = New System.Drawing.Point(101, 43)
        Me.PnlValue.Name = "PnlValue"
        Me.PnlValue.Size = New System.Drawing.Size(150, 36)
        Me.PnlValue.TabIndex = 0
        '
        'TxtValue
        '
        Me.TxtValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TxtValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtValue.ForeColor = System.Drawing.Color.Black
        Me.TxtValue.Location = New System.Drawing.Point(10, 10)
        Me.TxtValue.Name = "TxtValue"
        Me.TxtValue.Size = New System.Drawing.Size(130, 16)
        Me.TxtValue.TabIndex = 0
        Me.TxtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnlInput
        '
        Me.PnlInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlInput.Controls.Add(Me.TxtIndex)
        Me.PnlInput.Enabled = False
        Me.PnlInput.Location = New System.Drawing.Point(25, 43)
        Me.PnlInput.Name = "PnlInput"
        Me.PnlInput.Size = New System.Drawing.Size(70, 36)
        Me.PnlInput.TabIndex = 1
        '
        'TxtIndex
        '
        Me.TxtIndex.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TxtIndex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIndex.ForeColor = System.Drawing.Color.Black
        Me.TxtIndex.Location = New System.Drawing.Point(10, 10)
        Me.TxtIndex.Name = "TxtIndex"
        Me.TxtIndex.Size = New System.Drawing.Size(50, 16)
        Me.TxtIndex.TabIndex = 0
        Me.TxtIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnInput
        '
        Me.BtnInput.Location = New System.Drawing.Point(257, 43)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(150, 36)
        Me.BtnInput.TabIndex = 2
        Me.BtnInput.Text = "&Input"
        Me.BtnInput.UseVisualStyleBackColor = True
        '
        'BtnChange
        '
        Me.BtnChange.Enabled = False
        Me.BtnChange.Location = New System.Drawing.Point(413, 43)
        Me.BtnChange.Name = "BtnChange"
        Me.BtnChange.Size = New System.Drawing.Size(150, 36)
        Me.BtnChange.TabIndex = 3
        Me.BtnChange.Text = "C&hange"
        Me.BtnChange.UseVisualStyleBackColor = True
        '
        'BtnCompute
        '
        Me.BtnCompute.Enabled = False
        Me.BtnCompute.Location = New System.Drawing.Point(56, 454)
        Me.BtnCompute.Name = "BtnCompute"
        Me.BtnCompute.Size = New System.Drawing.Size(150, 36)
        Me.BtnCompute.TabIndex = 4
        Me.BtnCompute.Text = "&Compute"
        Me.BtnCompute.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Enabled = False
        Me.BtnReset.Location = New System.Drawing.Point(212, 454)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(150, 36)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "&Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'LblIndex
        '
        Me.LblIndex.AutoSize = True
        Me.LblIndex.Location = New System.Drawing.Point(25, 25)
        Me.LblIndex.Name = "LblIndex"
        Me.LblIndex.Size = New System.Drawing.Size(39, 15)
        Me.LblIndex.TabIndex = 6
        Me.LblIndex.Text = "Index:"
        '
        'LblValue
        '
        Me.LblValue.AutoSize = True
        Me.LblValue.Location = New System.Drawing.Point(98, 25)
        Me.LblValue.Name = "LblValue"
        Me.LblValue.Size = New System.Drawing.Size(38, 15)
        Me.LblValue.TabIndex = 7
        Me.LblValue.Text = "Value:"
        '
        'LblData
        '
        Me.LblData.AutoSize = True
        Me.LblData.Location = New System.Drawing.Point(25, 97)
        Me.LblData.Name = "LblData"
        Me.LblData.Size = New System.Drawing.Size(34, 15)
        Me.LblData.TabIndex = 8
        Me.LblData.Text = "Data:"
        '
        'PnlData
        '
        Me.PnlData.BackColor = System.Drawing.Color.White
        Me.PnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlData.Controls.Add(Me.TxtData)
        Me.PnlData.Enabled = False
        Me.PnlData.Location = New System.Drawing.Point(25, 115)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(538, 318)
        Me.PnlData.TabIndex = 2
        '
        'TxtData
        '
        Me.TxtData.BackColor = System.Drawing.Color.White
        Me.TxtData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtData.Location = New System.Drawing.Point(10, 10)
        Me.TxtData.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtData.Multiline = True
        Me.TxtData.Name = "TxtData"
        Me.TxtData.ReadOnly = True
        Me.TxtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtData.Size = New System.Drawing.Size(516, 296)
        Me.TxtData.TabIndex = 0
        '
        'pbxNPDC
        '
        Me.pbxNPDC.BackColor = System.Drawing.Color.White
        Me.pbxNPDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxNPDC.Location = New System.Drawing.Point(588, 115)
        Me.pbxNPDC.Name = "pbxNPDC"
        Me.pbxNPDC.Size = New System.Drawing.Size(538, 318)
        Me.pbxNPDC.TabIndex = 9
        Me.pbxNPDC.TabStop = False
        '
        'BtnShowNPDC
        '
        Me.BtnShowNPDC.Enabled = False
        Me.BtnShowNPDC.Location = New System.Drawing.Point(368, 454)
        Me.BtnShowNPDC.Name = "BtnShowNPDC"
        Me.BtnShowNPDC.Size = New System.Drawing.Size(150, 36)
        Me.BtnShowNPDC.TabIndex = 10
        Me.BtnShowNPDC.Text = "&Show NPDC"
        Me.BtnShowNPDC.UseVisualStyleBackColor = True
        '
        'PnlNPDC
        '
        Me.PnlNPDC.BackColor = System.Drawing.Color.PaleGreen
        Me.PnlNPDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlNPDC.Controls.Add(Me.LblNPDC)
        Me.PnlNPDC.Location = New System.Drawing.Point(588, 43)
        Me.PnlNPDC.Name = "PnlNPDC"
        Me.PnlNPDC.Size = New System.Drawing.Size(538, 36)
        Me.PnlNPDC.TabIndex = 1
        '
        'LblNPDC
        '
        Me.LblNPDC.Location = New System.Drawing.Point(133, 10)
        Me.LblNPDC.Name = "LblNPDC"
        Me.LblNPDC.Size = New System.Drawing.Size(272, 16)
        Me.LblNPDC.TabIndex = 11
        Me.LblNPDC.Text = "Normal Probability Distribution Curve (NPDC)"
        Me.LblNPDC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmIndexScreen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1153, 514)
        Me.Controls.Add(Me.PnlNPDC)
        Me.Controls.Add(Me.BtnShowNPDC)
        Me.Controls.Add(Me.pbxNPDC)
        Me.Controls.Add(Me.PnlData)
        Me.Controls.Add(Me.LblData)
        Me.Controls.Add(Me.LblValue)
        Me.Controls.Add(Me.LblIndex)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnCompute)
        Me.Controls.Add(Me.BtnChange)
        Me.Controls.Add(Me.BtnInput)
        Me.Controls.Add(Me.PnlInput)
        Me.Controls.Add(Me.PnlValue)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmIndexScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Basic Statistics"
        Me.PnlValue.ResumeLayout(False)
        Me.PnlValue.PerformLayout()
        Me.PnlInput.ResumeLayout(False)
        Me.PnlInput.PerformLayout()
        Me.PnlData.ResumeLayout(False)
        Me.PnlData.PerformLayout()
        CType(Me.pbxNPDC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlNPDC.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlValue As Panel
    Friend WithEvents TxtValue As TextBox
    Friend WithEvents PnlInput As Panel
    Friend WithEvents TxtIndex As TextBox
    Friend WithEvents BtnInput As Button
    Friend WithEvents BtnChange As Button
    Friend WithEvents BtnCompute As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents LblIndex As Label
    Friend WithEvents LblValue As Label
    Friend WithEvents LblData As Label
    Friend WithEvents PnlData As Panel
    Friend WithEvents TxtData As TextBox
    Friend WithEvents pbxNPDC As PictureBox
    Friend WithEvents BtnShowNPDC As Button
    Friend WithEvents PnlNPDC As Panel
    Friend WithEvents LblNPDC As Label
End Class
