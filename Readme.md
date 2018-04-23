# Get values from all cells that are shown at the same level as a clicked cell


<p>You can use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_GetCellValuetopic"><u>GetCellValue(Object[] columnValues, Object[] rowValues, PivotGridField dataField);</u></a> method to get a value from a cell by corresponding row and column field values. To iterate through the last level field values use the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_GetVisibleValuestopic"><u>PivotGridFieldBase.GetVisibleValues</u></a> method. To get information about higher level values corresponding to a clicked cell use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotCellBaseEventArgs_GetColumnFieldstopic"><u>PivotCellBaseEventArgs.GetColumnFields</u></a>, <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotCellBaseEventArgs_GetRowFieldstopic"><u>PivotCellBaseEventArgs.GetRowFields</u></a> and <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotCellBaseEventArgs_GetFieldValuetopic"><u>PivotCellBaseEventArgs.GetFieldValue</u></a> methods.</p><br />


<br/>


