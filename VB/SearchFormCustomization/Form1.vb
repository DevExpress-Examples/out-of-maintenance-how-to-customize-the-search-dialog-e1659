Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraEditors

Namespace SearchFormExample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			labelControl1.Text = "Search form uses the following mnemonics:" & Constants.vbLf & "dx for DevExpress, fn for function, fld for field, cl for class"
			myRichEditControl1.LoadDocument("RichEditAbout.rtf",DocumentFormat.Rtf)
		End Sub

		Private Sub btnShowSearchForm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowSearchForm.Click
			myRichEditControl1.ShowSearchForm()
		End Sub
	End Class

	Public Class MyRichEditControl
		Inherits RichEditControl
		Protected Overrides Function CreateSearchForm(ByVal activePage As SearchFormActivePage) As SearchTextForm
			Return New MySearchForm(Me, activePage)
		End Function
	End Class
	Public Class MySearchForm
		Inherits SearchTextForm
		Private Shared patterns As Dictionary(Of String, String) = CreatePatternsTable()

		Private Shared Function CreatePatternsTable() As Dictionary(Of String, String)
			Dim result As New Dictionary(Of String, String)()
			result.Add("dx", "DevExpress")
			result.Add("fn", "function")
			result.Add("fld", "field")
			result.Add("cl", "class")
			Return result
		End Function
		Public Sub New(ByVal control As RichEditControl, ByVal activePage As SearchFormActivePage)
			MyBase.New(control, activePage)
			cbFndSearchString.Text = "Enter search text here"
			SubscribeToControlsEvents()
		End Sub

		Private Sub SubscribeToControlsEvents()
			AddHandler cbFndSearchString.TextChanged, AddressOf OnSearchStringChanged
			AddHandler cbRplSearchString.TextChanged, AddressOf OnSearchStringChanged
		End Sub
		Private Sub OnSearchStringChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim editor As MRUEdit = TryCast(sender, MRUEdit)
			If patterns.ContainsKey(editor.Text) Then
				editor.Text = patterns(editor.Text)
			End If
		End Sub
	End Class
End Namespace