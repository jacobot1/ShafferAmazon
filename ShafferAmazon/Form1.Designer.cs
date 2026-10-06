namespace ShafferAmazon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPID = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnClear = new Button();
            btnCount = new Button();
            btnExit = new Button();
            listView = new ListView();
            lblCount = new Label();
            lblProductID = new Label();
            lblProductName = new Label();
            lblDescription = new Label();
            txtSpecialFeature = new TextBox();
            txtVendor = new TextBox();
            lblSpecialFeature = new Label();
            lblVendor = new Label();
            lblStoreName = new Label();
            lblAvailability = new Label();
            txtAvailability = new TextBox();
            SuspendLayout();
            // 
            // txtPID
            // 
            txtPID.Location = new Point(141, 84);
            txtPID.Margin = new Padding(3, 4, 3, 4);
            txtPID.Name = "txtPID";
            txtPID.Size = new Size(114, 27);
            txtPID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(141, 123);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(141, 161);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(114, 27);
            txtDescription.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 16);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(106, 16);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(86, 31);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(199, 16);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(291, 16);
            btnCount.Margin = new Padding(3, 4, 3, 4);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(86, 31);
            btnCount.TabIndex = 6;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(384, 16);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // listView
            // 
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(291, 63);
            listView.Margin = new Padding(3, 4, 3, 4);
            listView.Name = "listView";
            listView.Size = new Size(1194, 276);
            listView.TabIndex = 8;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(477, 21);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(110, 20);
            lblCount.TabIndex = 9;
            lblCount.Text = "Product Count: ";
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(14, 88);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(79, 20);
            lblProductID.TabIndex = 10;
            lblProductID.Text = "Product ID";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(14, 127);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(104, 20);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "Product Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(14, 165);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Description";
            // 
            // txtSpecialFeature
            // 
            txtSpecialFeature.Location = new Point(141, 200);
            txtSpecialFeature.Margin = new Padding(3, 4, 3, 4);
            txtSpecialFeature.Name = "txtSpecialFeature";
            txtSpecialFeature.Size = new Size(114, 27);
            txtSpecialFeature.TabIndex = 13;
            // 
            // txtVendor
            // 
            txtVendor.Location = new Point(141, 239);
            txtVendor.Margin = new Padding(3, 4, 3, 4);
            txtVendor.Name = "txtVendor";
            txtVendor.Size = new Size(114, 27);
            txtVendor.TabIndex = 14;
            // 
            // lblSpecialFeature
            // 
            lblSpecialFeature.AutoSize = true;
            lblSpecialFeature.Location = new Point(14, 204);
            lblSpecialFeature.Name = "lblSpecialFeature";
            lblSpecialFeature.Size = new Size(110, 20);
            lblSpecialFeature.TabIndex = 15;
            lblSpecialFeature.Text = "Special Feature";
            // 
            // lblVendor
            // 
            lblVendor.AutoSize = true;
            lblVendor.Location = new Point(14, 243);
            lblVendor.Name = "lblVendor";
            lblVendor.Size = new Size(56, 20);
            lblVendor.TabIndex = 16;
            lblVendor.Text = "Vendor";
            // 
            // lblStoreName
            // 
            lblStoreName.AutoSize = true;
            lblStoreName.Location = new Point(14, 319);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(91, 20);
            lblStoreName.TabIndex = 17;
            lblStoreName.Text = "Store Name:";
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Location = new Point(14, 282);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(83, 20);
            lblAvailability.TabIndex = 18;
            lblAvailability.Text = "Availability";
            // 
            // txtAvailability
            // 
            txtAvailability.Location = new Point(141, 279);
            txtAvailability.Name = "txtAvailability";
            txtAvailability.Size = new Size(114, 27);
            txtAvailability.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1497, 372);
            Controls.Add(txtAvailability);
            Controls.Add(lblAvailability);
            Controls.Add(lblStoreName);
            Controls.Add(lblVendor);
            Controls.Add(lblSpecialFeature);
            Controls.Add(txtVendor);
            Controls.Add(txtSpecialFeature);
            Controls.Add(lblDescription);
            Controls.Add(lblProductName);
            Controls.Add(lblProductID);
            Controls.Add(lblCount);
            Controls.Add(listView);
            Controls.Add(btnExit);
            Controls.Add(btnCount);
            Controls.Add(btnClear);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtPID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Amazon Product Comparison";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPID;
        private TextBox txtName;
        private TextBox txtDescription;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnClear;
        private Button btnCount;
        private Button btnExit;
        private ListView listView;
        private Label lblCount;
        private Label lblProductID;
        private Label lblProductName;
        private Label lblDescription;
        private TextBox txtSpecialFeature;
        private TextBox txtVendor;
        private Label lblSpecialFeature;
        private Label lblVendor;
        private Label lblStoreName;
        private Label lblAvailability;
        private TextBox txtAvailability;
    }
}
