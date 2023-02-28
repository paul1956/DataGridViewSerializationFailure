﻿' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

Imports System.Runtime.CompilerServices
Imports System.Text

Friend Module DataGridViewColumnEventArgsExtensions
    Friend Const ProjectName As String = "CareLink"
    Friend Const TmChar As String = ChrW(&H2122)

    <Extension>
    Public Sub DgvColumnAdded(ByRef e As DataGridViewColumnEventArgs, cellStyle As DataGridViewCellStyle, wrapHeader As Boolean, forceReadOnly As Boolean, caption As String)
        With e.Column
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Dim idHeaderName As Boolean = .DataPropertyName = "ID"
            .ReadOnly = forceReadOnly OrElse idHeaderName
            .Resizable = DataGridViewTriState.False
            Dim title As New StringBuilder
            Dim titleInTitleCase As String = .Name
            If Not .Name.Contains("OADateTime", StringComparison.InvariantCultureIgnoreCase) Then
                titleInTitleCase = If(.DataPropertyName.Length < 4, .Name, .Name.ToLower())
            End If

            If wrapHeader Then
                Dim titleSplit As String() = titleInTitleCase.Replace("A I T", "AIT").Split(" "c)
                For Each s As String In titleSplit
                    If s.Length < 5 Then
                        title.Append(s)
                    Else
                        title.AppendLine(s)
                    End If
                Next
            Else
                title.Append(titleInTitleCase.Replace("Care Link", $"{ProjectName}{TmChar}"))
            End If
            .HeaderText = title.TrimEnd(Environment.NewLine).ToString
            .DefaultCellStyle = cellStyle
            If .HeaderText <> "Record Number" Then
                .SortMode = DataGridViewColumnSortMode.NotSortable
            End If
            If String.IsNullOrWhiteSpace(caption) Then Return
            .HeaderText = caption.Replace("_", "")
            If .DataPropertyName.Contains("message", StringComparison.OrdinalIgnoreCase) Then
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            ElseIf .DataPropertyName.Equals("RecordNumber", StringComparison.OrdinalIgnoreCase) Then
                .SortMode = DataGridViewColumnSortMode.Automatic
                .HeaderCell.SortGlyphDirection = SortOrder.Ascending
            End If
        End With

    End Sub

End Module
