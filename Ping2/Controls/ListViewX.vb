﻿Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Runtime.InteropServices


Public Enum WM
    WM_NULL = &H0
    WM_CREATE = &H1
    WM_DESTROY = &H2
    WM_MOVE = &H3
    WM_SIZE = &H5
    WM_ACTIVATE = &H6
    WM_SETFOCUS = &H7
    WM_KILLFOCUS = &H8
    WM_ENABLE = &HA
    WM_SETREDRAW = &HB
    WM_SETTEXT = &HC
    WM_GETTEXT = &HD
    WM_GETTEXTLENGTH = &HE
    WM_PAINT = &HF
    WM_CLOSE = &H10
    WM_QUERYENDSESSION = &H11
    WM_QUIT = &H12
    WM_QUERYOPEN = &H13
    WM_ERASEBKGND = &H14
End Enum

<StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)>
Public Structure RECT
    Public left As Integer
    Public top As Integer
    Public right As Integer
    Public bottom As Integer
End Structure

Public Class ListViewX
    Inherits System.Windows.Forms.ListView

    Private updating As Boolean
    Private itemnumber As Integer

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function ValidateRect(ByVal handle As IntPtr, ByRef rect As RECT) As Boolean
    End Function

    Public Sub UpdateItem(ByVal iIndex As Integer)
        updating = True
        itemnumber = iIndex
        Me.Update()
        updating = False
    End Sub

    Protected Overrides Sub WndProc(ByRef messg As Message)
        If updating Then

            If CInt(WM.WM_ERASEBKGND) = messg.Msg Then
                messg.Msg = CInt(WM.WM_NULL)
            ElseIf CInt(WM.WM_PAINT) = messg.Msg Then
                Dim vrect As RECT = Me.GetWindowRECT()
                ValidateRect(Me.Handle, vrect)
                Invalidate(Me.Items(itemnumber).Bounds)
            End If
        End If

        MyBase.WndProc(messg)
    End Sub

    Private Function GetWindowRECT() As RECT
        Dim rect As RECT = New RECT()
        rect.left = Me.Left
        rect.right = Me.Right
        rect.top = Me.Top
        rect.bottom = Me.Bottom
        Return rect
    End Function
End Class


