Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient

Public Class GlobalClasses

    Dim c As New AppConfiguration
    Dim cs = c.cnstring

    'Position
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub Fill_ComboBox(ByVal WhatComboBox As ComboBox,
                          ByVal StoredProcedureInput As String,
                          ByVal ValueMemberInput As String,
                          ByVal DisplayMemberInput As String)
        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset(cs, CommandType.StoredProcedure, StoredProcedureInput)

            With WhatComboBox
                .ValueMember = ValueMemberInput
                .DisplayMember = DisplayMemberInput
                .DataSource = ds.Tables(0)
                .SelectedItem = Nothing
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
End Class
