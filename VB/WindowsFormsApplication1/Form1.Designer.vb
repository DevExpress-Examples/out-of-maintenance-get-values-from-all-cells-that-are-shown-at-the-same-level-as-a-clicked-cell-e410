Namespace WindowsFormsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Me.fieldOrderYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderMonth = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.invoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New WindowsFormsApplication1.nwindDataSet()
			Me.fieldCustomersCompanyName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldUnitPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldAmount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.invoicesTableAdapter = New WindowsFormsApplication1.nwindDataSetTableAdapters.InvoicesTableAdapter()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.invoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' fieldOrderYear
			' 
			Me.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderYear.AreaIndex = 0
			Me.fieldOrderYear.Caption = "Year"
			Me.fieldOrderYear.ExpandedInFieldsGroup = False
			Me.fieldOrderYear.FieldName = "OrderDate"
			Me.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldOrderYear.Name = "fieldOrderYear"
			Me.fieldOrderYear.UnboundFieldName = "fieldOrderYear"
			' 
			' fieldOrderMonth
			' 
			Me.fieldOrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderMonth.AreaIndex = 1
			Me.fieldOrderMonth.Caption = "Month"
			Me.fieldOrderMonth.FieldName = "OrderDate"
			Me.fieldOrderMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.fieldOrderMonth.Name = "fieldOrderMonth"
			Me.fieldOrderMonth.UnboundFieldName = "fieldOrderMonth"
			Me.fieldOrderMonth.Visible = False
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.DataSource = Me.invoicesBindingSource
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCustomersCompanyName1, Me.fieldOrderYear, Me.fieldProductName, Me.fieldQuantity, Me.fieldUnitPrice, Me.fieldAmount, Me.fieldOrderMonth})
			pivotGridGroup1.Caption = "Calendar"
			pivotGridGroup1.Fields.Add(Me.fieldOrderYear)
			pivotGridGroup1.Fields.Add(Me.fieldOrderMonth)
			pivotGridGroup1.Hierarchy = Nothing
			pivotGridGroup1.ShowNewValues = True
			Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(590, 406)
			Me.pivotGridControl1.TabIndex = 0
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.pivotGridControl1.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.pivotGridControl1_CellDoubleClick);
			' 
			' invoicesBindingSource
			' 
			Me.invoicesBindingSource.DataMember = "Invoices"
			Me.invoicesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' fieldCustomersCompanyName1
			' 
			Me.fieldCustomersCompanyName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCustomersCompanyName1.AreaIndex = 0
			Me.fieldCustomersCompanyName1.Caption = "Company"
			Me.fieldCustomersCompanyName1.FieldName = "Customers_CompanyName"
			Me.fieldCustomersCompanyName1.Name = "fieldCustomersCompanyName1"
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.Caption = "Product"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 0
			Me.fieldQuantity.Caption = "Qty"
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			' 
			' fieldUnitPrice
			' 
			Me.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldUnitPrice.AreaIndex = 1
			Me.fieldUnitPrice.FieldName = "UnitPrice"
			Me.fieldUnitPrice.Name = "fieldUnitPrice"
			' 
			' fieldAmount
			' 
			Me.fieldAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldAmount.AreaIndex = 2
			Me.fieldAmount.Caption = "Amount"
			Me.fieldAmount.CellFormat.FormatString = "C0"
			Me.fieldAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldAmount.FieldName = "Amount"
			Me.fieldAmount.Name = "fieldAmount"
			Me.fieldAmount.UnboundExpression = "[Quantity] * [UnitPrice]"
			Me.fieldAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			' 
			' pivotGridField1
			' 
			Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.pivotGridField1.AreaIndex = 0
			Me.pivotGridField1.Caption = "Year"
			Me.pivotGridField1.FieldName = "OrderDate"
			Me.pivotGridField1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.pivotGridField1.Name = "pivotGridField1"
			Me.pivotGridField1.UnboundFieldName = "fieldOrderDate"
			' 
			' dataGridView1
			' 
			Me.dataGridView1.AllowUserToAddRows = False
			Me.dataGridView1.AllowUserToDeleteRows = False
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.ReadOnly = True
			Me.dataGridView1.Size = New System.Drawing.Size(284, 406)
			Me.dataGridView1.TabIndex = 1
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.pivotGridControl1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.dataGridView1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(879, 406)
			Me.splitContainerControl1.SplitterPosition = 590
			Me.splitContainerControl1.TabIndex = 2
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' invoicesTableAdapter
			' 
			Me.invoicesTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(879, 406)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "Form1"
			Me.Text = "Double click a cell to display the same level data"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.invoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private nwindDataSet As nwindDataSet
		Private invoicesBindingSource As System.Windows.Forms.BindingSource
		Private invoicesTableAdapter As WindowsFormsApplication1.nwindDataSetTableAdapters.InvoicesTableAdapter
		Private fieldCustomersCompanyName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldUnitPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldAmount As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderMonth As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
	End Class
End Namespace

