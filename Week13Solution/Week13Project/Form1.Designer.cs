namespace Week13Project
{
    partial class frmWeek13
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCustomerList = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.coboState = new System.Windows.Forms.ComboBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtExtra1 = new System.Windows.Forms.TextBox();
            this.lblExtra1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.txtExtra2 = new System.Windows.Forms.TextBox();
            this.lblExtra2 = new System.Windows.Forms.Label();
            this.txtExtra3 = new System.Windows.Forms.TextBox();
            this.lblExtra3 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.dataOutput = new System.Windows.Forms.DataGridView();
            this.grpCustomerTypes = new System.Windows.Forms.GroupBox();
            this.radGovernment = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblErrorOutput = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).BeginInit();
            this.grpCustomerTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerList
            // 
            this.lblCustomerList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerList.Location = new System.Drawing.Point(12, 379);
            this.lblCustomerList.Name = "lblCustomerList";
            this.lblCustomerList.Size = new System.Drawing.Size(977, 41);
            this.lblCustomerList.TabIndex = 2;
            this.lblCustomerList.Text = "Customer List";
            this.lblCustomerList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(25, 84);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 21);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(125, 80);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(287, 29);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(125, 12);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(287, 29);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(23, 14);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 21);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(125, 114);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(287, 29);
            this.txtAddress1.TabIndex = 3;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(28, 118);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(91, 21);
            this.lblAddress1.TabIndex = 7;
            this.lblAddress1.Text = "Address 1:";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(125, 148);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(287, 29);
            this.txtAddress2.TabIndex = 4;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(28, 152);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(91, 21);
            this.lblAddress2.TabIndex = 9;
            this.lblAddress2.Text = "Address 2:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(125, 182);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(287, 29);
            this.txtCity.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(74, 186);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(45, 21);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(68, 220);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(51, 21);
            this.lblState.TabIndex = 13;
            this.lblState.Text = "State:";
            // 
            // coboState
            // 
            this.coboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coboState.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coboState.FormattingEnabled = true;
            this.coboState.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.coboState.Items.AddRange(new object[] {
            "- no selection -",
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "District of Columbia (DC)",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.coboState.Location = new System.Drawing.Point(125, 216);
            this.coboState.Name = "coboState";
            this.coboState.Size = new System.Drawing.Size(287, 29);
            this.coboState.TabIndex = 6;
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(125, 250);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(287, 29);
            this.txtZip.TabIndex = 7;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(34, 254);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(85, 21);
            this.lblZip.TabIndex = 15;
            this.lblZip.Text = "Zip Code:";
            // 
            // txtExtra1
            // 
            this.txtExtra1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtra1.Location = new System.Drawing.Point(125, 284);
            this.txtExtra1.Name = "txtExtra1";
            this.txtExtra1.Size = new System.Drawing.Size(287, 29);
            this.txtExtra1.TabIndex = 8;
            this.txtExtra1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtExtra1_KeyUp);
            // 
            // lblExtra1
            // 
            this.lblExtra1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtra1.Location = new System.Drawing.Point(2, 288);
            this.lblExtra1.Name = "lblExtra1";
            this.lblExtra1.Size = new System.Drawing.Size(117, 21);
            this.lblExtra1.TabIndex = 17;
            this.lblExtra1.Text = "Home Phone:";
            this.lblExtra1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(641, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 42);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(819, 148);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(171, 42);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(818, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 83);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(641, 298);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 83);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnListAll
            // 
            this.btnListAll.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAll.Location = new System.Drawing.Point(641, 203);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(349, 83);
            this.btnListAll.TabIndex = 13;
            this.btnListAll.Text = "&Show All Customers";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // txtExtra2
            // 
            this.txtExtra2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtra2.Location = new System.Drawing.Point(125, 318);
            this.txtExtra2.Name = "txtExtra2";
            this.txtExtra2.Size = new System.Drawing.Size(287, 29);
            this.txtExtra2.TabIndex = 9;
            // 
            // lblExtra2
            // 
            this.lblExtra2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtra2.Location = new System.Drawing.Point(2, 322);
            this.lblExtra2.Name = "lblExtra2";
            this.lblExtra2.Size = new System.Drawing.Size(117, 21);
            this.lblExtra2.TabIndex = 31;
            this.lblExtra2.Text = "Home Type:";
            this.lblExtra2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtExtra3
            // 
            this.txtExtra3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtra3.Location = new System.Drawing.Point(125, 352);
            this.txtExtra3.Name = "txtExtra3";
            this.txtExtra3.Size = new System.Drawing.Size(287, 29);
            this.txtExtra3.TabIndex = 10;
            // 
            // lblExtra3
            // 
            this.lblExtra3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtra3.Location = new System.Drawing.Point(2, 356);
            this.lblExtra3.Name = "lblExtra3";
            this.lblExtra3.Size = new System.Drawing.Size(117, 21);
            this.lblExtra3.TabIndex = 33;
            this.lblExtra3.Text = "Cust. ID:";
            this.lblExtra3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(125, 46);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(287, 29);
            this.txtMiddleName.TabIndex = 1;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(5, 49);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(114, 21);
            this.lblMiddleName.TabIndex = 37;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // dataOutput
            // 
            this.dataOutput.AllowUserToAddRows = false;
            this.dataOutput.AllowUserToDeleteRows = false;
            this.dataOutput.AllowUserToResizeRows = false;
            this.dataOutput.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataOutput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.customerAddress,
            this.customerNumber,
            this.customerID,
            this.customerDetails,
            this.customerType,
            this.itemIndex});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOutput.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataOutput.Location = new System.Drawing.Point(12, 423);
            this.dataOutput.MultiSelect = false;
            this.dataOutput.Name = "dataOutput";
            this.dataOutput.ReadOnly = true;
            this.dataOutput.RowHeadersVisible = false;
            this.dataOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOutput.Size = new System.Drawing.Size(977, 394);
            this.dataOutput.TabIndex = 38;
            this.dataOutput.TabStop = false;
            this.dataOutput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOutput_CellClick);
            // 
            // grpCustomerTypes
            // 
            this.grpCustomerTypes.Controls.Add(this.radGovernment);
            this.grpCustomerTypes.Controls.Add(this.radCommercial);
            this.grpCustomerTypes.Controls.Add(this.radResidential);
            this.grpCustomerTypes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerTypes.Location = new System.Drawing.Point(642, 14);
            this.grpCustomerTypes.Name = "grpCustomerTypes";
            this.grpCustomerTypes.Size = new System.Drawing.Size(347, 125);
            this.grpCustomerTypes.TabIndex = 16;
            this.grpCustomerTypes.TabStop = false;
            this.grpCustomerTypes.Text = "Customer Types";
            // 
            // radGovernment
            // 
            this.radGovernment.AutoSize = true;
            this.radGovernment.Location = new System.Drawing.Point(6, 90);
            this.radGovernment.Name = "radGovernment";
            this.radGovernment.Size = new System.Drawing.Size(120, 25);
            this.radGovernment.TabIndex = 2;
            this.radGovernment.Text = "Government";
            this.radGovernment.UseVisualStyleBackColor = true;
            this.radGovernment.CheckedChanged += new System.EventHandler(this.radGovernment_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Location = new System.Drawing.Point(6, 59);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(118, 25);
            this.radCommercial.TabIndex = 1;
            this.radCommercial.Text = "Commercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Checked = true;
            this.radResidential.Location = new System.Drawing.Point(6, 28);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(109, 25);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(422, 46);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(213, 335);
            this.txtOutput.TabIndex = 39;
            this.txtOutput.TabStop = false;
            this.txtOutput.Text = "ID Pattern: AA#-A##-AA";
            // 
            // lblErrorOutput
            // 
            this.lblErrorOutput.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorOutput.Location = new System.Drawing.Point(418, 12);
            this.lblErrorOutput.Name = "lblErrorOutput";
            this.lblErrorOutput.Size = new System.Drawing.Size(217, 31);
            this.lblErrorOutput.TabIndex = 40;
            this.lblErrorOutput.Text = "Error Output:";
            this.lblErrorOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 162;
            // 
            // customerAddress
            // 
            this.customerAddress.HeaderText = "Address";
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.ReadOnly = true;
            this.customerAddress.Width = 162;
            // 
            // customerNumber
            // 
            this.customerNumber.HeaderText = "Contact Number";
            this.customerNumber.Name = "customerNumber";
            this.customerNumber.ReadOnly = true;
            this.customerNumber.Width = 162;
            // 
            // customerID
            // 
            this.customerID.HeaderText = "Customer ID";
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            this.customerID.Width = 162;
            // 
            // customerDetails
            // 
            this.customerDetails.HeaderText = "Details";
            this.customerDetails.Name = "customerDetails";
            this.customerDetails.ReadOnly = true;
            this.customerDetails.Width = 328;
            // 
            // customerType
            // 
            this.customerType.HeaderText = "Type";
            this.customerType.Name = "customerType";
            this.customerType.ReadOnly = true;
            this.customerType.Visible = false;
            // 
            // itemIndex
            // 
            this.itemIndex.HeaderText = "Index";
            this.itemIndex.Name = "itemIndex";
            this.itemIndex.ReadOnly = true;
            this.itemIndex.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(703, 391);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(287, 29);
            this.txtSearch.TabIndex = 41;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(580, 395);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(117, 21);
            this.lblSearch.TabIndex = 42;
            this.lblSearch.Text = "Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmWeek13
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1001, 828);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.grpCustomerTypes);
            this.Controls.Add(this.lblErrorOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.dataOutput);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.txtExtra3);
            this.Controls.Add(this.lblExtra3);
            this.Controls.Add(this.txtExtra2);
            this.Controls.Add(this.lblExtra2);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtExtra1);
            this.Controls.Add(this.lblExtra1);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.coboState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblCustomerList);
            this.KeyPreview = true;
            this.Name = "frmWeek13";
            this.Text = "Week13Lab";
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).EndInit();
            this.grpCustomerTypes.ResumeLayout(false);
            this.grpCustomerTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCustomerList;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox coboState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtExtra1;
        private System.Windows.Forms.Label lblExtra1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.TextBox txtExtra2;
        private System.Windows.Forms.Label lblExtra2;
        private System.Windows.Forms.TextBox txtExtra3;
        private System.Windows.Forms.Label lblExtra3;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.DataGridView dataOutput;
        private System.Windows.Forms.GroupBox grpCustomerTypes;
        private System.Windows.Forms.RadioButton radGovernment;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblErrorOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIndex;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}

