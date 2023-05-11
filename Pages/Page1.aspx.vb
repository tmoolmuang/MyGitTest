Public Class Page1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'add some comment
        Dim a As Boolean = func1()
    End Sub

    Private Function func1() As Boolean
        Return True
    End Function

End Class