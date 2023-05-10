Public Class Page1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MasterSub()
        MasterSub1()
    End Sub

    Private Sub MasterSub()
        Return
    End Sub

    Private Sub MasterSub1()
        'modified MasterSub1 - A
        'modified MasterSub1 - B
        Return
    End Sub
End Class