Public Class frmEmployeeIDCard_PrintPreview

    Dim gc As New GlobalClasses
    Dim c As New AppConfiguration
    Dim cs = c.cnstring

#Region "Panel (Moved Form)"
    Private Sub PnlMoveForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMoveForm.MouseMove, lblFormName.MouseMove
        If gc.MoveForm Then
            Me.Location = Me.Location + (e.Location - gc.MoveForm_MousePosition)
        End If
    End Sub

    Private Sub PnlMoveForm_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMoveForm.MouseUp, lblFormName.MouseUp
        If e.Button = MouseButtons.Left Then
            gc.MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub PnlMoveForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMoveForm.MouseDown, lblFormName.MouseDown
        If e.Button = MouseButtons.Left Then
            gc.MoveForm = True
            Me.Cursor = Cursors.Arrow
            gc.MoveForm_MousePosition = e.Location
        End If
    End Sub
#End Region

    Private Sub frmEmployeeIDCard_PrintPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class