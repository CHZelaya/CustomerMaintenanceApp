
namespace CustomerMaintenanceGUI
{
    partial class frmCustomerMaintenance
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
            label1 = new Label();
            txtCustomerID = new TextBox();
            btnGetCustomer = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            label6 = new Label();
            txtZipCode = new TextBox();
            btnAdd = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 38);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "CustomerID:";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(134, 31);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(125, 27);
            txtCustomerID.TabIndex = 1;
            // 
            // btnGetCustomer
            // 
            btnGetCustomer.Location = new Point(297, 31);
            btnGetCustomer.Name = "btnGetCustomer";
            btnGetCustomer.Size = new Size(114, 29);
            btnGetCustomer.TabIndex = 2;
            btnGetCustomer.Text = "Get Customer";
            btnGetCustomer.UseVisualStyleBackColor = true;
            btnGetCustomer.Click += btnGetCustomer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 92);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 129);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 166);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 5;
            label4.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 208);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "State:";
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 85);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(359, 27);
            txtName.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(134, 122);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(359, 27);
            txtAddress.TabIndex = 8;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(134, 159);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(359, 27);
            txtCity.TabIndex = 9;
            // 
            // txtState
            // 
            txtState.Location = new Point(134, 201);
            txtState.Name = "txtState";
            txtState.ReadOnly = true;
            txtState.Size = new Size(125, 27);
            txtState.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 206);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 11;
            label6.Text = "Zip Code";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(368, 199);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.ReadOnly = true;
            txtZipCode.Size = new Size(125, 27);
            txtZipCode.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(69, 262);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(169, 262);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(94, 29);
            btnModify.TabIndex = 14;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(269, 262);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(460, 262);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 16;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmCustomerMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 342);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(txtZipCode);
            Controls.Add(label6);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnGetCustomer);
            Controls.Add(txtCustomerID);
            Controls.Add(label1);
            Name = "frmCustomerMaintenance";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private TextBox txtCustomerID;
        private Button btnGetCustomer;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtState;
        private Label label6;
        private TextBox txtZipCode;
        private Button btnAdd;
        private Button btnModify;
        private Button btnDelete;
        private Button btnExit;
    }
}
