namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.fieldOrderYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new WindowsFormsApplication1.nwindDataSet();
            this.fieldCustomersCompanyName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.invoicesTableAdapter = new WindowsFormsApplication1.nwindDataSetTableAdapters.InvoicesTableAdapter();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fieldOrderYear
            // 
            this.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderYear.AreaIndex = 0;
            this.fieldOrderYear.Caption = "Year";
            this.fieldOrderYear.ExpandedInFieldsGroup = false;
            this.fieldOrderYear.FieldName = "OrderDate";
            this.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderYear.Name = "fieldOrderYear";
            this.fieldOrderYear.UnboundFieldName = "fieldOrderYear";
            // 
            // fieldOrderMonth
            // 
            this.fieldOrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderMonth.AreaIndex = 1;
            this.fieldOrderMonth.Caption = "Month";
            this.fieldOrderMonth.FieldName = "OrderDate";
            this.fieldOrderMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldOrderMonth.Name = "fieldOrderMonth";
            this.fieldOrderMonth.UnboundFieldName = "fieldOrderMonth";
            this.fieldOrderMonth.Visible = false;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.invoicesBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCustomersCompanyName,
            this.fieldOrderYear,
            this.fieldProductName,
            this.fieldQuantity,
            this.fieldUnitPrice,
            this.fieldAmount,
            this.fieldOrderMonth});
            pivotGridGroup1.Caption = "Calendar";
            pivotGridGroup1.Fields.Add(this.fieldOrderYear);
            pivotGridGroup1.Fields.Add(this.fieldOrderMonth);
            pivotGridGroup1.Hierarchy = null;
            pivotGridGroup1.ShowNewValues = true;
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(600, 406);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.pivotGridControl1_CellDoubleClick);
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldCustomersCompanyName
            // 
            this.fieldCustomersCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCustomersCompanyName.AreaIndex = 0;
            this.fieldCustomersCompanyName.FieldName = "Customers_CompanyName";
            this.fieldCustomersCompanyName.Name = "fieldCustomersCompanyName";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 0;
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            // 
            // fieldUnitPrice
            // 
            this.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitPrice.AreaIndex = 1;
            this.fieldUnitPrice.FieldName = "UnitPrice";
            this.fieldUnitPrice.Name = "fieldUnitPrice";
            // 
            // fieldAmount
            // 
            this.fieldAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldAmount.AreaIndex = 2;
            this.fieldAmount.Caption = "Amount";
            this.fieldAmount.CellFormat.FormatString = "C0";
            this.fieldAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldAmount.FieldName = "Amount";
            this.fieldAmount.Name = "fieldAmount";
            this.fieldAmount.UnboundExpression = "[Quantity] * [UnitPrice]";
            this.fieldAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Year";
            this.pivotGridField1.FieldName = "OrderDate";
            this.pivotGridField1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.UnboundFieldName = "fieldOrderDate";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 406);
            this.dataGridView1.TabIndex = 1;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.pivotGridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1132, 406);
            this.splitContainerControl1.SplitterPosition = 600;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 406);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private WindowsFormsApplication1.nwindDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustomersCompanyName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAmount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderMonth;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}

