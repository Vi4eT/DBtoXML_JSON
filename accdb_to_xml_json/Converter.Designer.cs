
namespace accdb_to_xml_json
{
    partial class Converter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.buttonToXML = new System.Windows.Forms.Button();
			this.textBoxGrid = new System.Windows.Forms.TextBox();
			this.buttonReadXML = new System.Windows.Forms.Button();
			this.buttonWriteXML = new System.Windows.Forms.Button();
			this.textBoxFile = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonWriteJSON = new System.Windows.Forms.Button();
			this.buttonToJSON = new System.Windows.Forms.Button();
			this.buttonReadJSON = new System.Windows.Forms.Button();
			this.buttonProvider = new System.Windows.Forms.Button();
			this.buttonIncome = new System.Windows.Forms.Button();
			this.buttonProduct = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.testDBDataSet = new accdb_to_xml_json.TestDBDataSet();
			this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.providerTableAdapter = new accdb_to_xml_json.TestDBDataSetTableAdapters.ProviderTableAdapter();
			this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.incomeTableAdapter = new accdb_to_xml_json.TestDBDataSetTableAdapters.IncomeTableAdapter();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productTableAdapter = new accdb_to_xml_json.TestDBDataSetTableAdapters.ProductTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonToXML
			// 
			this.buttonToXML.Location = new System.Drawing.Point(12, 258);
			this.buttonToXML.Margin = new System.Windows.Forms.Padding(4);
			this.buttonToXML.Name = "buttonToXML";
			this.buttonToXML.Size = new System.Drawing.Size(100, 50);
			this.buttonToXML.TabIndex = 4;
			this.buttonToXML.Text = "Grid to XML";
			this.buttonToXML.UseVisualStyleBackColor = true;
			this.buttonToXML.Click += new System.EventHandler(this.buttonToXML_Click);
			// 
			// textBoxGrid
			// 
			this.textBoxGrid.Location = new System.Drawing.Point(0, 69);
			this.textBoxGrid.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxGrid.Multiline = true;
			this.textBoxGrid.Name = "textBoxGrid";
			this.textBoxGrid.Size = new System.Drawing.Size(529, 181);
			this.textBoxGrid.TabIndex = 10;
			// 
			// buttonReadXML
			// 
			this.buttonReadXML.Location = new System.Drawing.Point(12, 374);
			this.buttonReadXML.Margin = new System.Windows.Forms.Padding(4);
			this.buttonReadXML.Name = "buttonReadXML";
			this.buttonReadXML.Size = new System.Drawing.Size(100, 50);
			this.buttonReadXML.TabIndex = 6;
			this.buttonReadXML.Text = "Read XML";
			this.buttonReadXML.UseVisualStyleBackColor = true;
			this.buttonReadXML.Click += new System.EventHandler(this.buttonReadXML_Click);
			// 
			// buttonWriteXML
			// 
			this.buttonWriteXML.Location = new System.Drawing.Point(12, 316);
			this.buttonWriteXML.Margin = new System.Windows.Forms.Padding(4);
			this.buttonWriteXML.Name = "buttonWriteXML";
			this.buttonWriteXML.Size = new System.Drawing.Size(100, 50);
			this.buttonWriteXML.TabIndex = 5;
			this.buttonWriteXML.Text = "Save to XML";
			this.buttonWriteXML.UseVisualStyleBackColor = true;
			this.buttonWriteXML.Click += new System.EventHandler(this.buttonWriteXML_Click);
			// 
			// textBoxFile
			// 
			this.textBoxFile.Location = new System.Drawing.Point(537, 69);
			this.textBoxFile.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxFile.Multiline = true;
			this.textBoxFile.Name = "textBoxFile";
			this.textBoxFile.Size = new System.Drawing.Size(529, 181);
			this.textBoxFile.TabIndex = 11;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(120, 258);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(827, 283);
			this.dataGridView1.TabIndex = 14;
			// 
			// buttonWriteJSON
			// 
			this.buttonWriteJSON.Location = new System.Drawing.Point(955, 316);
			this.buttonWriteJSON.Margin = new System.Windows.Forms.Padding(4);
			this.buttonWriteJSON.Name = "buttonWriteJSON";
			this.buttonWriteJSON.Size = new System.Drawing.Size(100, 50);
			this.buttonWriteJSON.TabIndex = 8;
			this.buttonWriteJSON.Text = "Save to JSON";
			this.buttonWriteJSON.UseVisualStyleBackColor = true;
			this.buttonWriteJSON.Click += new System.EventHandler(this.buttonWriteJSON_Click);
			// 
			// buttonToJSON
			// 
			this.buttonToJSON.Location = new System.Drawing.Point(955, 258);
			this.buttonToJSON.Margin = new System.Windows.Forms.Padding(4);
			this.buttonToJSON.Name = "buttonToJSON";
			this.buttonToJSON.Size = new System.Drawing.Size(100, 50);
			this.buttonToJSON.TabIndex = 7;
			this.buttonToJSON.Text = "Grid to JSON";
			this.buttonToJSON.UseVisualStyleBackColor = true;
			this.buttonToJSON.Click += new System.EventHandler(this.buttonToJSON_Click);
			// 
			// buttonReadJSON
			// 
			this.buttonReadJSON.Location = new System.Drawing.Point(955, 374);
			this.buttonReadJSON.Margin = new System.Windows.Forms.Padding(4);
			this.buttonReadJSON.Name = "buttonReadJSON";
			this.buttonReadJSON.Size = new System.Drawing.Size(100, 50);
			this.buttonReadJSON.TabIndex = 9;
			this.buttonReadJSON.Text = "Read JSON";
			this.buttonReadJSON.UseVisualStyleBackColor = true;
			this.buttonReadJSON.Click += new System.EventHandler(this.buttonReadJSON_Click);
			// 
			// buttonProvider
			// 
			this.buttonProvider.Location = new System.Drawing.Point(12, 11);
			this.buttonProvider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonProvider.Name = "buttonProvider";
			this.buttonProvider.Size = new System.Drawing.Size(100, 50);
			this.buttonProvider.TabIndex = 1;
			this.buttonProvider.Text = "Provider";
			this.buttonProvider.UseVisualStyleBackColor = true;
			this.buttonProvider.Click += new System.EventHandler(this.buttonProvider_Click);
			// 
			// buttonIncome
			// 
			this.buttonIncome.Location = new System.Drawing.Point(118, 11);
			this.buttonIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonIncome.Name = "buttonIncome";
			this.buttonIncome.Size = new System.Drawing.Size(100, 50);
			this.buttonIncome.TabIndex = 2;
			this.buttonIncome.Text = "Income";
			this.buttonIncome.UseVisualStyleBackColor = true;
			this.buttonIncome.Click += new System.EventHandler(this.buttonIncome_Click);
			// 
			// buttonProduct
			// 
			this.buttonProduct.Location = new System.Drawing.Point(224, 11);
			this.buttonProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonProduct.Name = "buttonProduct";
			this.buttonProduct.Size = new System.Drawing.Size(100, 50);
			this.buttonProduct.TabIndex = 3;
			this.buttonProduct.Text = "Product";
			this.buttonProduct.UseVisualStyleBackColor = true;
			this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(955, 11);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(100, 50);
			this.buttonSave.TabIndex = 16;
			this.buttonSave.Text = "Save DB";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// testDBDataSet
			// 
			this.testDBDataSet.DataSetName = "TestDBDataSet";
			this.testDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// providerBindingSource
			// 
			this.providerBindingSource.DataMember = "Provider";
			this.providerBindingSource.DataSource = this.testDBDataSet;
			// 
			// providerTableAdapter
			// 
			this.providerTableAdapter.ClearBeforeFill = true;
			// 
			// incomeBindingSource
			// 
			this.incomeBindingSource.DataMember = "Income";
			this.incomeBindingSource.DataSource = this.testDBDataSet;
			// 
			// incomeTableAdapter
			// 
			this.incomeTableAdapter.ClearBeforeFill = true;
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataMember = "Product";
			this.productBindingSource.DataSource = this.testDBDataSet;
			// 
			// productTableAdapter
			// 
			this.productTableAdapter.ClearBeforeFill = true;
			// 
			// Converter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonProduct);
			this.Controls.Add(this.buttonIncome);
			this.Controls.Add(this.buttonProvider);
			this.Controls.Add(this.buttonReadJSON);
			this.Controls.Add(this.buttonWriteJSON);
			this.Controls.Add(this.buttonToJSON);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonToXML);
			this.Controls.Add(this.textBoxGrid);
			this.Controls.Add(this.buttonReadXML);
			this.Controls.Add(this.buttonWriteXML);
			this.Controls.Add(this.textBoxFile);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Converter";
			this.Text = "Converter";
			this.Load += new System.EventHandler(this.Converter_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToXML;
        private System.Windows.Forms.TextBox textBoxGrid;
        private System.Windows.Forms.Button buttonReadXML;
        private System.Windows.Forms.Button buttonWriteXML;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonWriteJSON;
        private System.Windows.Forms.Button buttonToJSON;
        private System.Windows.Forms.Button buttonReadJSON;
		private System.Windows.Forms.Button buttonProvider;
		private System.Windows.Forms.Button buttonIncome;
		private System.Windows.Forms.Button buttonProduct;
		private System.Windows.Forms.Button buttonSave;
		private TestDBDataSet testDBDataSet;
		private System.Windows.Forms.BindingSource providerBindingSource;
		private TestDBDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
		private System.Windows.Forms.BindingSource incomeBindingSource;
		private TestDBDataSetTableAdapters.IncomeTableAdapter incomeTableAdapter;
		private System.Windows.Forms.BindingSource productBindingSource;
		private TestDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
	}
}

