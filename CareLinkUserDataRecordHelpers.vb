' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Text

Public Module CareLinkUserDataRecordHelpers

    Private ReadOnly s_columnsToHide As New List(Of String) From {
        "ID"}

    Friend Function GetCellStyle(columnName As String) As DataGridViewCellStyle
        Dim cellStyle As New DataGridViewCellStyle
        ' Names below are actually NameOf(Something) like NameOf(ID)
        Select Case columnName
            Case "ID",
                 "CareLinkUserName",
                 "CareLinkPassword"
                cellStyle.SetCellStyle(DataGridViewContentAlignment.MiddleLeft, New Padding(1))
            Case "AutoLogin",
                 "CountryCode",
                 "UseLocalTimeZone",
                 "DeleteRow"
                cellStyle = cellStyle.SetCellStyle(DataGridViewContentAlignment.MiddleCenter, New Padding(0))
            Case ""
                Throw New Exception($"{NameOf(CareLinkUserDataRecordHelpers)}.{NameOf(GetCellStyle)}, {NameOf(columnName)} = {columnName}")
            Case Else
        End Select
        Return cellStyle
    End Function

    Friend Function HideColumn(dataPropertyName As String) As Boolean
        If String.IsNullOrWhiteSpace(dataPropertyName) Then
            Return False
        End If
        Return Not (Debugger.IsAttached) AndAlso s_columnsToHide.Contains(dataPropertyName)
    End Function

    ''' <summary>
    ''' Converts a single string of characters that contains words that
    ''' start with an uppercase character without spaces
    ''' to a Title where the first letter of every word capitalized and
    ''' words are separated by spaces
    ''' </summary>
    ''' <param name="inStr">A string like ThisIsATitle</param>
    ''' <returns>This Is A Title</returns>
    <Extension()>
    Friend Function ToTitleCase(inStr As String, Optional separateNumbers As Boolean = True) As String
        If String.IsNullOrWhiteSpace(inStr) Then
            Return ""
        End If

        Dim result As New Text.StringBuilder(Char.ToUpperInvariant(inStr(0)))
        Dim lastWasNumeric As Boolean = Char.IsNumber(inStr(0))
        For Each c As Char In inStr.Substring(1)
            If Char.IsLower(c) OrElse lastWasNumeric Then
                result.Append(c)
                lastWasNumeric = False
            ElseIf Char.IsNumber(c) AndAlso Not separateNumbers Then
                result.Append(c)
                lastWasNumeric = True
            Else
                result.Append($" {Char.ToUpperInvariant(c)}")
                lastWasNumeric = False
            End If
        Next
        result = result.Replace("Care Link", $"CareLink{TmChar}")
        Return result.ToString().Replace("time", " Time", False, CultureInfo.CurrentUICulture)
    End Function

    <Extension>
    Public Function SetCellStyle(cellStyle As DataGridViewCellStyle, alignment As DataGridViewContentAlignment, padding As Padding) As DataGridViewCellStyle
        cellStyle.Alignment = alignment
        cellStyle.Padding = padding
        Return cellStyle
    End Function

    <Extension>
    Public Function TrimEnd(sb As StringBuilder, trimString As String) As StringBuilder
        Dim value As String = sb.ToString.TrimEnd(trimString)
        sb.Clear()
        Return sb.Append(value)
    End Function

End Module
