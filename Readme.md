<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579541/12.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4108)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsFormsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication1/Program.vb))
<!-- default file list end -->
# Get values from all cells that are shown at the same level as a clicked cell


<p>You can use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_GetCellValuetopic"><u>GetCellValue(Object[] columnValues, Object[] rowValues, PivotGridField dataField);</u></a> method to get a value from a cell by corresponding row and column field values. To iterate through the last level field values use the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_GetVisibleValuestopic"><u>PivotGridFieldBase.GetVisibleValues</u></a> method. To get information about higher level values corresponding to a clicked cell use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotCellBaseEventArgs_GetColumnFieldstopic"><u>PivotCellBaseEventArgs.GetColumnFields</u></a>, <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotCellBaseEventArgs_GetRowFieldstopic"><u>PivotCellBaseEventArgs.GetRowFields</u></a> and <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotCellBaseEventArgs_GetFieldValuetopic"><u>PivotCellBaseEventArgs.GetFieldValue</u></a> methods.</p><br />


<br/>


