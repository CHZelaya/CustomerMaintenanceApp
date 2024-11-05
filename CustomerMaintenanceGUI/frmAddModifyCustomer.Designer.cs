namespace CustomerMaintenanceGUI
{
    partial class frmAddModifyCustomer
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
            btnCancel = new Button();
            btnAccept = new Button();
            cboStates = new ComboBox();
            txtZipCode = new TextBox();
            label6 = new Label();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(385, 231);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(120, 231);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(94, 29);
            btnAccept.TabIndex = 36;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // cboStates
            // 
            cboStates.FormattingEnabled = true;
            cboStates.Location = new Point(121, 165);
            cboStates.Name = "cboStates";
            cboStates.Size = new Size(151, 28);
            cboStates.TabIndex = 35;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(354, 164);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(125, 27);
            txtZipCode.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 171);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 33;
            label6.Text = "Zip Code";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(120, 124);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(359, 27);
            txtCity.TabIndex = 32;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(120, 87);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(359, 27);
            txtAddress.TabIndex = 31;
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(359, 27);
            txtName.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 173);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 29;
            label5.Text = "State:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 131);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 28;
            label4.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 94);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 27;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 57);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 26;
            label2.Text = "Name:";
            // 
            // frmAddModifyCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 318);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(cboStates);
            Controls.Add(txtZipCode);
            Controls.Add(label6);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmAddModifyCustomer";
            Text = "frmAddModifyCustomer";
            Load += frmAddModifyCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAccept;
        private ComboBox cboStates;
        private TextBox txtZipCode;
        private Label label6;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}