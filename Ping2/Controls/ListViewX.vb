Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports RestSharp
Imports System.Net.NetworkInformation


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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler Me.ColumnClick, AddressOf SortingColumnClick
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function ValidateRect(ByVal handle As IntPtr, ByRef rect As RECT) As Boolean
    End Function
    Public Sub UpdateItem(item As ListViewItem)
        Dim index = GetItemIndex(item)
        UpdateItem(index)
    End Sub
    Public Sub UpdateItem(ByVal iIndex As Integer)
        updating = True
        itemnumber = iIndex
        Me.Update()
        updating = False
    End Sub

    Public Sub ApplyGroup(NewGroup As String, Item As ListViewItem)
        If NewGroup <> "" Then
            Dim thisGroup As ListViewGroup = Nothing
            For Each group In Me.Groups
                If group.header = NewGroup Then thisGroup = group
            Next
            If thisGroup Is Nothing Then
                thisGroup = New ListViewGroup(NewGroup)
                Groups.Add(thisGroup)
            End If
            Item.Group = thisGroup
        End If
    End Sub
    Public Function GetItemIndex(item As ListViewItem) As Integer
        Dim MyItemIndex As Integer = 0
        For Index = 0 To Items.Count - 1
            If Items(Index).Equals(item) Then
                MyItemIndex = Index
                Exit For
            End If
        Next
        Return MyItemIndex
    End Function
    Public Function GetItemByTag(Tag As Object) As ListViewItem
        Dim MyItem As ListViewItem = Nothing
        For Each item In Items
            If item.tag.Equals(Tag) Then
                MyItem = item
            End If
        Next
        Return MyItem
    End Function

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
        Dim rect As New RECT With {
            .left = Me.Left,
            .right = Me.Right,
            .top = Me.Top,
            .bottom = Me.Bottom
        }
        Return rect
    End Function

    Public Sub SortingColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs)
        If Me.Columns.Item(e.Column).ListView.Sorting <> SortOrder.Descending Then
            Me.Columns.Item(e.Column).ListView.Sorting = SortOrder.Descending
        ElseIf Me.Columns.Item(e.Column).ListView.Sorting <> SortOrder.Ascending Then
            Me.Columns.Item(e.Column).ListView.Sorting = SortOrder.Ascending
        End If
        Me.ListViewItemSorter = New ListViewItemComparer(e.Column)
        'MyBase.OnColumnClick(e)
    End Sub
End Class
Public Class ListViewItemComparer
    Implements IComparer

    Private ReadOnly col As Integer

    Public Sub New()
        col = 0
    End Sub

    Public Sub New(ByVal column As Integer)
        col = column
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        Return String.Compare((CType(x, ListViewItem)).SubItems(col).Text, (CType(y, ListViewItem)).SubItems(col).Text)
    End Function
End Class


