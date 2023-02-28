Public Class Form1
#If failue Then
    Private Sub DgvCareLinkUsers_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles DgvCareLinkUsers.ColumnAdded
        With e.Column
            Dim dgv As DataGridView = CType(sender, DataGridView)
            Dim caption As String = CType(dgv.DataSource, DataTable)?.Columns(.Index).Caption
            Dim dataPropertyName As String = e.Column.DataPropertyName
            If String.IsNullOrWhiteSpace(caption) Then
                caption = dataPropertyName.Replace("DgvCareLinkUsers", "")
            End If
            If caption.Contains("DeleteRow", StringComparison.OrdinalIgnoreCase) Then
                caption = ""
            Else
                If .Index > 0 AndAlso String.IsNullOrWhiteSpace(dataPropertyName) AndAlso String.IsNullOrWhiteSpace(caption) Then
                    ' stuff
                End If
            End If
            If CareLinkUserDataRecordHelpers.HideColumn(dataPropertyName) Then
                e.DgvColumnAdded(CareLinkUserDataRecordHelpers.GetCellStyle(dataPropertyName),
                                 False,
                                 False,
                                 caption)
                .Visible = False
            Else
                e.DgvColumnAdded(CareLinkUserDataRecordHelpers.GetCellStyle(dataPropertyName),
                                 False,
                                 True,
                                 caption)
                e.Column.HeaderText = caption.ToTitleCase
            End If
        End With
    End Sub
#Else

    Private Sub DataGridView2_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles DataGridView2.ColumnAdded
        With e.Column
            Dim dgv As DataGridView = CType(sender, DataGridView)
            Dim caption As String = CType(dgv.DataSource, DataTable)?.Columns(.Index).Caption
            Dim dataPropertyName As String = e.Column.DataPropertyName
            If String.IsNullOrWhiteSpace(caption) Then
                caption = dataPropertyName.Replace("DgvCareLinkUsers", "")
            End If
            If caption.Contains("DeleteRow", StringComparison.OrdinalIgnoreCase) Then
                caption = ""
                If CareLinkUserDataRecordHelpers.HideColumn(dataPropertyName) Then
                    e.DgvColumnAdded(CareLinkUserDataRecordHelpers.GetCellStyle(dataPropertyName),
                                     False,
                                     False,
                                     caption)
                    .Visible = False
                Else
                    e.DgvColumnAdded(CareLinkUserDataRecordHelpers.GetCellStyle(dataPropertyName),
                                     False,
                                     True,
                                     caption)
                    e.Column.HeaderText = caption.ToLower
                End If
            End If
        End With
    End Sub

#End If

End Class
