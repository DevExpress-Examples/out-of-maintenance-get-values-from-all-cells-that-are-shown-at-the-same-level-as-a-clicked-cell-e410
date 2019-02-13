Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Data

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			excelDataSource1.FileName = "SalesPerson.xlsx"
			excelDataSource1.Fill()
			pivotGridControl1.BestFit()
			pivotGridControl1.BestFitDataHeaders(True)

		End Sub

		Private Sub pivotGridControl1_CellDoubleClick(ByVal sender As Object, ByVal e As PivotCellEventArgs) Handles pivotGridControl1.CellDoubleClick
			If e.RowField Is Nothing Then
				Return 'Grand Total cell
			End If
			Dim columnFields() As PivotGridField = e.GetColumnFields()
			Dim columnValues(columnFields.Length - 1) As Object
			For i As Integer = 0 To columnFields.Length - 1
				columnValues(i) = e.GetFieldValue(columnFields(i))
			Next i
			Dim rowFields() As PivotGridField = e.GetRowFields()
			Dim rowValues(rowFields.Length - 1) As Object
			For i As Integer = 0 To rowFields.Length - 2
				rowValues(i) = e.GetFieldValue(rowFields(i))
			Next i

			Dim dt As New DataTable()
			For Each field As PivotGridField In columnFields
				dt.Columns.Add(field.ToString(), field.DataType)
			Next field
			For Each field As PivotGridField In rowFields
				dt.Columns.Add(field.ToString(), field.DataType)
			Next field
			dt.Columns.Add(e.DataField.ToString(), e.DataField.DataType)

			For Each lastLevelValue As Object In e.RowField.GetVisibleValues()
				rowValues(rowFields.Length-1) = lastLevelValue
				Dim cellValue As Object = e.GetCellValue(columnValues, rowValues, e.DataField)
				If cellValue Is Nothing Then
					Continue For
				End If
				Dim row As DataRow = dt.NewRow()

				For i As Integer = 0 To columnFields.Length - 1
					row(columnFields(i).ToString()) = columnValues(i)
				Next i
				For i As Integer = 0 To rowFields.Length - 1
					row(rowFields(i).ToString()) = rowValues(i)
				Next i
				row(e.DataField.ToString()) = cellValue
				dt.Rows.Add(row)

			Next lastLevelValue
			gridControl1.DataSource = dt
			gridView1.BestFitColumns()
		End Sub
	End Class
End Namespace
