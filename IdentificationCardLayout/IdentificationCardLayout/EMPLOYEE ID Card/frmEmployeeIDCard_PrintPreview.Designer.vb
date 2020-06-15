<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeIDCard_PrintPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeIDCard_PrintPreview))
        Me.pnlNONE = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnlMoveForm = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.lblFormName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlMoveForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlNONE
        '
        Me.pnlNONE.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.pnlNONE.Location = New System.Drawing.Point(0, 0)
        Me.pnlNONE.Name = "pnlNONE"
        Me.pnlNONE.Size = New System.Drawing.Size(998, 30)
        Me.pnlNONE.TabIndex = 15
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IdentificationCardLayout.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 36)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(974, 531)
        Me.ReportViewer1.TabIndex = 16
        '
        'pnlMoveForm
        '
        Me.pnlMoveForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.pnlMoveForm.Controls.Add(Me.btnMinimize)
        Me.pnlMoveForm.Controls.Add(Me.lblFormName)
        Me.pnlMoveForm.Controls.Add(Me.btnExit)
        Me.pnlMoveForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMoveForm.Location = New System.Drawing.Point(0, 0)
        Me.pnlMoveForm.Name = "pnlMoveForm"
        Me.pnlMoveForm.Size = New System.Drawing.Size(998, 30)
        Me.pnlMoveForm.TabIndex = 17
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(896, -1)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(50, 31)
        Me.btnMinimize.TabIndex = 14
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'lblFormName
        '
        Me.lblFormName.AutoSize = True
        Me.lblFormName.BackColor = System.Drawing.Color.Transparent
        Me.lblFormName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormName.ForeColor = System.Drawing.Color.White
        Me.lblFormName.Location = New System.Drawing.Point(15, 6)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(117, 19)
        Me.lblFormName.TabIndex = 10
        Me.lblFormName.Text = "PRINT PREVIEW"
        Me.lblFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(949, -1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(50, 31)
        Me.btnExit.TabIndex = 13
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmEmployeeIDCard_PrintPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 579)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlMoveForm)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEmployeeIDCard_PrintPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlMoveForm.ResumeLayout(False)
        Me.pnlMoveForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlNONE As System.Windows.Forms.Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnlMoveForm As System.Windows.Forms.Panel
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents lblFormName As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
