Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Data

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		gridCustomers.GroupSummarySortInfo.Clear()

		Dim sortInfo As New ASPxGroupSummarySortInfo()
		sortInfo.SortOrder = ColumnSortOrder.Ascending
		sortInfo.SummaryItem = gridCustomers.GroupSummary("Country", SummaryItemType.Min)
		sortInfo.GroupColumn = "City"

		gridCustomers.GroupSummarySortInfo.AddRange(sortInfo)
	End Sub
End Class
