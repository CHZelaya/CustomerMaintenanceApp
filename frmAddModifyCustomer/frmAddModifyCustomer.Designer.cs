namespace frmAddModifyCustomer
{
    partial class frmAddModifyCustomer
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
            txtZipCode = new TextBox();
            label6 = new Label();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cboStates = new ComboBox();
            btnAccept = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(349, 158);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.ReadOnly = true;
            txtZipCode.Size = new Size(125, 27);
            txtZipCode.TabIndex = 22;
            //txtZipCode.TextChanged += this.txtZipCode_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(273, 165);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 21;
            label6.Text = "Zip Code";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(115, 118);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(359, 27);
            txtCity.TabIndex = 19;
            //txtCity.TextChanged += this.txtCity_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(115, 81);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(359, 27);
            txtAddress.TabIndex = 18;
            //txtAddress.TextChanged += this.txtAddress_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 44);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(359, 27);
            txtName.TabIndex = 17;
            //txtName.TextChanged += this.txtName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 167);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 16;
            label5.Text = "State:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 125);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 15;
            label4.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 88);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 14;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 51);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 13;
            label2.Text = "Name:";
            // 
            // cboStates
            // 
            cboStates.FormattingEnabled = true;
            cboStates.Location = new Point(116, 159);
            cboStates.Name = "cboStates";
            cboStates.Size = new Size(151, 28);
            cboStates.TabIndex = 23;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(115, 225);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(94, 29);
            btnAccept.TabIndex = 24;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(380, 225);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 266);
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
            Name = "Form1";
            Text = "Form1";
            //Load += this.Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtZipCode;
        private Label label6;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboStates;
        private Button btnAccept;
        private Button btnCancel;
    }
}
