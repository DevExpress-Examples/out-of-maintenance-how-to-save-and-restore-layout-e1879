Imports Microsoft.VisualBasic
Imports System

Namespace SaveAndRestoreLayout
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Session("Layout") = ASPxPivotGrid1.SaveLayout()
		End Sub
		Protected Sub ASPxButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim layout As String = CStr(Session("Layout"))
			If layout Is Nothing Then
				Return
			End If
			ASPxPivotGrid1.LoadLayout(layout)
		End Sub
	End Class
End Namespace
