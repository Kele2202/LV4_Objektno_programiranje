namespace WindowsFormsApplication5
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
            this.cbShippers = new System.Windows.Forms.ComboBox();
            this.shippersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new WindowsFormsApplication5.NorthwindDataSet();
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgwContent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customersTableAdapter = new WindowsFormsApplication5.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.shippersTableAdapter = new WindowsFormsApplication5.NorthwindDataSetTableAdapters.ShippersTableAdapter();
            this.employeesTableAdapter = new WindowsFormsApplication5.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new WindowsFormsApplication5.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.bShow = new System.Windows.Forms.Button();
            this.checkBoxCustomers = new System.Windows.Forms.CheckBox();
            this.checkBoxShippers = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.shippersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbShippers
            // 
            this.cbShippers.DataSource = this.shippersBindingSource;
            this.cbShippers.DisplayMember = "CompanyName";
            this.cbShippers.FormattingEnabled = true;
            this.cbShippers.Location = new System.Drawing.Point(673, 89);
            this.cbShippers.Name = "cbShippers";
            this.cbShippers.Size = new System.Drawing.Size(121, 21);
            this.cbShippers.TabIndex = 0;
            this.cbShippers.ValueMember = "ShipperID";
            this.cbShippers.SelectedIndexChanged += new System.EventHandler(this.cbShippers_SelectedIndexChanged);
            // 
            // shippersBindingSource
            // 
            this.shippersBindingSource.DataMember = "Shippers";
            this.shippersBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbEmployees
            // 
            this.cbEmployees.DataSource = this.employeesBindingSource;
            this.cbEmployees.DisplayMember = "LastName";
            this.cbEmployees.FormattingEnabled = true;
            this.cbEmployees.Location = new System.Drawing.Point(673, 153);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(121, 21);
            this.cbEmployees.TabIndex = 1;
            this.cbEmployees.ValueMember = "EmployeeID";
            this.cbEmployees.SelectedIndexChanged += new System.EventHandler(this.cbEmployees_SelectedIndexChanged);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.northwindDataSet;
            // 
            // cbCustomers
            // 
            this.cbCustomers.DataSource = this.customersBindingSource;
            this.cbCustomers.DisplayMember = "CompanyName";
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(674, 25);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(121, 21);
            this.cbCustomers.TabIndex = 2;
            this.cbCustomers.ValueMember = "CustomerID";
            this.cbCustomers.SelectedIndexChanged += new System.EventHandler(this.cbCustomers_SelectedIndexChanged);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSet;
            // 
            // dgwContent
            // 
            this.dgwContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwContent.Location = new System.Drawing.Point(12, 12);
            this.dgwContent.Name = "dgwContent";
            this.dgwContent.Size = new System.Drawing.Size(655, 463);
            this.dgwContent.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(712, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shippers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employees";
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // shippersTableAdapter
            // 
            this.shippersTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.northwindDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(707, 363);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(75, 23);
            this.bShow.TabIndex = 7;
            this.bShow.Text = "Prikaži cijelu tablicu";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // checkBoxCustomers
            // 
            this.checkBoxCustomers.AutoSize = true;
            this.checkBoxCustomers.Location = new System.Drawing.Point(674, 53);
            this.checkBoxCustomers.Name = "checkBoxCustomers";
            this.checkBoxCustomers.Size = new System.Drawing.Size(108, 17);
            this.checkBoxCustomers.TabIndex = 8;
            this.checkBoxCustomers.Text = "Ignore Customers";
            this.checkBoxCustomers.UseVisualStyleBackColor = true;
            this.checkBoxCustomers.CheckedChanged += new System.EventHandler(this.checkBoxCustomers_CheckedChanged);
            // 
            // checkBoxShippers
            // 
            this.checkBoxShippers.AutoSize = true;
            this.checkBoxShippers.Location = new System.Drawing.Point(674, 117);
            this.checkBoxShippers.Name = "checkBoxShippers";
            this.checkBoxShippers.Size = new System.Drawing.Size(100, 17);
            this.checkBoxShippers.TabIndex = 9;
            this.checkBoxShippers.Text = "Ignore Shippers";
            this.checkBoxShippers.UseVisualStyleBackColor = true;
            this.checkBoxShippers.CheckedChanged += new System.EventHandler(this.checkBoxShippers_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 488);
            this.Controls.Add(this.checkBoxShippers);
            this.Controls.Add(this.checkBoxCustomers);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwContent);
            this.Controls.Add(this.cbCustomers);
            this.Controls.Add(this.cbEmployees);
            this.Controls.Add(this.cbShippers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shippersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbShippers;
        private System.Windows.Forms.ComboBox cbEmployees;
        private System.Windows.Forms.ComboBox cbCustomers;
        private System.Windows.Forms.DataGridView dgwContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource shippersBindingSource;
        private NorthwindDataSetTableAdapters.ShippersTableAdapter shippersTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.CheckBox checkBoxCustomers;
        private System.Windows.Forms.CheckBox checkBoxShippers;
    }
}

