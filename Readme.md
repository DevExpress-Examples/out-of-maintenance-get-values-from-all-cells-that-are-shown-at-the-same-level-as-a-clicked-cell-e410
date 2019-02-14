<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsFormsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication1/Program.vb))
<!-- default file list end -->
# How to Get Cell Values for All Cells at the Same Level

In this example, double click a cell to retrieve data from all cells at the same data slice (level) and display them in the grid on the right.

![screenshot](https://github.com/DevExpress-Examples/get-values-from-all-cells-that-are-shown-at-the-same-level-as-a-clicked-cell-e4108/blob/18.2.4%2B/images/screenshot.png)

API in this example:

* [PivotGridControl.CellDoubleClick](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CellDoubleClick) event
* [PivotCellEventArgs.GetColumnFields](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotCellEventArgsBase-3.GetColumnFields) method
* [PivotCellEventArgs.GetRowFields](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotCellEventArgsBase-3.GetRowFields) method
* [PivotCellEventArgs.GetFieldValue](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotCellEventArgsBase-3.GetFieldValue(-0)) method
* [PivotCellDisplayTextEventArgs.GetCellValue](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotCellBaseEventArgs.GetCellValue(System.Object---System.Object---DevExpress.Xpf.PivotGrid.PivotGridField)) method
* [PivotGridFieldBase.GetVisibleValues](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.GetVisibleValues) method
