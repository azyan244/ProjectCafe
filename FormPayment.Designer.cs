using System;

namespace ProjectCafe
{
    partial class FormPayment
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.rbTNG = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbBank = new System.Windows.Forms.RadioButton();
            this.grpbxPayment = new System.Windows.Forms.GroupBox();
            this.comboBoxBank = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDelivery = new System.Windows.Forms.RadioButton();
            this.rbPickUp = new System.Windows.Forms.RadioButton();
            this.listBoxTotalPrice = new System.Windows.Forms.ListBox();
            this.labelNameDelivery = new System.Windows.Forms.Label();
            this.labelPhoneDelivery = new System.Windows.Forms.Label();
            this.labelAddressDelivery = new System.Windows.Forms.Label();
            this.txtBoxNameDelivery = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneDelivery = new System.Windows.Forms.TextBox();
            this.txtBoxAddressDelivery = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpbxPayment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(41, 39);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(165, 25);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "GRAND TOTAL :";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Sienna;
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(819, 515);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(174, 54);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // rbTNG
            // 
            this.rbTNG.AutoSize = true;
            this.rbTNG.Location = new System.Drawing.Point(64, 52);
            this.rbTNG.Name = "rbTNG";
            this.rbTNG.Size = new System.Drawing.Size(75, 29);
            this.rbTNG.TabIndex = 5;
            this.rbTNG.TabStop = true;
            this.rbTNG.Text = "TNG";
            this.rbTNG.UseVisualStyleBackColor = true;
            this.rbTNG.CheckedChanged += new System.EventHandler(this.rdbtnTNG_CheckedChanged);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(64, 122);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(80, 29);
            this.rbCash.TabIndex = 6;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbBank
            // 
            this.rbBank.AutoSize = true;
            this.rbBank.Location = new System.Drawing.Point(64, 87);
            this.rbBank.Name = "rbBank";
            this.rbBank.Size = new System.Drawing.Size(166, 29);
            this.rbBank.TabIndex = 7;
            this.rbBank.TabStop = true;
            this.rbBank.Text = "Online Banking";
            this.rbBank.UseVisualStyleBackColor = true;
            this.rbBank.CheckedChanged += new System.EventHandler(this.rdbtnBank_CheckedChanged);
            // 
            // grpbxPayment
            // 
            this.grpbxPayment.Controls.Add(this.comboBoxBank);
            this.grpbxPayment.Controls.Add(this.rbTNG);
            this.grpbxPayment.Controls.Add(this.rbBank);
            this.grpbxPayment.Controls.Add(this.rbCash);
            this.grpbxPayment.Location = new System.Drawing.Point(46, 339);
            this.grpbxPayment.Name = "grpbxPayment";
            this.grpbxPayment.Size = new System.Drawing.Size(406, 192);
            this.grpbxPayment.TabIndex = 8;
            this.grpbxPayment.TabStop = false;
            this.grpbxPayment.Text = "CHOOSE PAYMENT TYPE :";
            // 
            // comboBoxBank
            // 
            this.comboBoxBank.FormattingEnabled = true;
            this.comboBoxBank.Items.AddRange(new object[] {
            "Public Bank",
            "Maybank",
            "CIMB",
            "RHB",
            "Bank Islam"});
            this.comboBoxBank.Location = new System.Drawing.Point(236, 83);
            this.comboBoxBank.Name = "comboBoxBank";
            this.comboBoxBank.Size = new System.Drawing.Size(121, 33);
            this.comboBoxBank.TabIndex = 8;
            this.comboBoxBank.SelectedIndexChanged += new System.EventHandler(this.comboBoxBank_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDelivery);
            this.groupBox1.Controls.Add(this.rbPickUp);
            this.groupBox1.Location = new System.Drawing.Point(46, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 152);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbDelivery
            // 
            this.rbDelivery.AutoSize = true;
            this.rbDelivery.Location = new System.Drawing.Point(29, 50);
            this.rbDelivery.Name = "rbDelivery";
            this.rbDelivery.Size = new System.Drawing.Size(103, 29);
            this.rbDelivery.TabIndex = 5;
            this.rbDelivery.TabStop = true;
            this.rbDelivery.Text = "Delivery";
            this.rbDelivery.UseVisualStyleBackColor = true;
            this.rbDelivery.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbPickUp
            // 
            this.rbPickUp.AutoSize = true;
            this.rbPickUp.Location = new System.Drawing.Point(29, 85);
            this.rbPickUp.Name = "rbPickUp";
            this.rbPickUp.Size = new System.Drawing.Size(100, 29);
            this.rbPickUp.TabIndex = 7;
            this.rbPickUp.TabStop = true;
            this.rbPickUp.Text = "Pick Up";
            this.rbPickUp.UseVisualStyleBackColor = true;
            this.rbPickUp.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // listBoxTotalPrice
            // 
            this.listBoxTotalPrice.FormattingEnabled = true;
            this.listBoxTotalPrice.ItemHeight = 25;
            this.listBoxTotalPrice.Location = new System.Drawing.Point(46, 79);
            this.listBoxTotalPrice.Name = "listBoxTotalPrice";
            this.listBoxTotalPrice.Size = new System.Drawing.Size(309, 54);
            this.listBoxTotalPrice.TabIndex = 3;
            this.listBoxTotalPrice.SelectedIndexChanged += new System.EventHandler(this.lstbxPrice_SelectedIndexChanged);
            // 
            // labelNameDelivery
            // 
            this.labelNameDelivery.AutoSize = true;
            this.labelNameDelivery.Location = new System.Drawing.Point(534, 57);
            this.labelNameDelivery.Name = "labelNameDelivery";
            this.labelNameDelivery.Size = new System.Drawing.Size(64, 25);
            this.labelNameDelivery.TabIndex = 15;
            this.labelNameDelivery.Text = "Name";
            // 
            // labelPhoneDelivery
            // 
            this.labelPhoneDelivery.AutoSize = true;
            this.labelPhoneDelivery.Location = new System.Drawing.Point(534, 108);
            this.labelPhoneDelivery.Name = "labelPhoneDelivery";
            this.labelPhoneDelivery.Size = new System.Drawing.Size(69, 25);
            this.labelPhoneDelivery.TabIndex = 16;
            this.labelPhoneDelivery.Text = "Phone";
            // 
            // labelAddressDelivery
            // 
            this.labelAddressDelivery.AutoSize = true;
            this.labelAddressDelivery.Location = new System.Drawing.Point(534, 152);
            this.labelAddressDelivery.Name = "labelAddressDelivery";
            this.labelAddressDelivery.Size = new System.Drawing.Size(85, 25);
            this.labelAddressDelivery.TabIndex = 17;
            this.labelAddressDelivery.Text = "Address";
            // 
            // txtBoxNameDelivery
            // 
            this.txtBoxNameDelivery.Location = new System.Drawing.Point(642, 52);
            this.txtBoxNameDelivery.Name = "txtBoxNameDelivery";
            this.txtBoxNameDelivery.Size = new System.Drawing.Size(218, 30);
            this.txtBoxNameDelivery.TabIndex = 18;
            this.txtBoxNameDelivery.TextChanged += new System.EventHandler(this.txtBoxNameDelivery_TextChanged);
            // 
            // txtBoxPhoneDelivery
            // 
            this.txtBoxPhoneDelivery.Location = new System.Drawing.Point(642, 103);
            this.txtBoxPhoneDelivery.Name = "txtBoxPhoneDelivery";
            this.txtBoxPhoneDelivery.Size = new System.Drawing.Size(218, 30);
            this.txtBoxPhoneDelivery.TabIndex = 19;
            this.txtBoxPhoneDelivery.TextChanged += new System.EventHandler(this.txtBoxPhoneDelivery_TextChanged);
            // 
            // txtBoxAddressDelivery
            // 
            this.txtBoxAddressDelivery.Location = new System.Drawing.Point(642, 152);
            this.txtBoxAddressDelivery.Multiline = true;
            this.txtBoxAddressDelivery.Name = "txtBoxAddressDelivery";
            this.txtBoxAddressDelivery.Size = new System.Drawing.Size(218, 95);
            this.txtBoxAddressDelivery.TabIndex = 20;
            this.txtBoxAddressDelivery.TextChanged += new System.EventHandler(this.txtBoxAddressDelivery_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(881, 204);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 43);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1029, 581);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtBoxAddressDelivery);
            this.Controls.Add(this.txtBoxPhoneDelivery);
            this.Controls.Add(this.txtBoxNameDelivery);
            this.Controls.Add(this.labelAddressDelivery);
            this.Controls.Add(this.labelPhoneDelivery);
            this.Controls.Add(this.labelNameDelivery);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbxPayment);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.listBoxTotalPrice);
            this.Controls.Add(this.lblTotal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPayment";
            this.Text = "Fill Your Details";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.grpbxPayment.ResumeLayout(false);
            this.grpbxPayment.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtBoxNameDelivery_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPhoneDelivery_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtBoxAddressDelivery_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnTNG_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void lstbxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.RadioButton rbTNG;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbBank;
        private System.Windows.Forms.GroupBox grpbxPayment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDelivery;
        private System.Windows.Forms.RadioButton rbPickUp;
        private System.Windows.Forms.ComboBox comboBoxBank;
        private System.Windows.Forms.ListBox listBoxTotalPrice;
        private System.Windows.Forms.Label labelNameDelivery;
        private System.Windows.Forms.Label labelPhoneDelivery;
        private System.Windows.Forms.Label labelAddressDelivery;
        private System.Windows.Forms.TextBox txtBoxNameDelivery;
        private System.Windows.Forms.TextBox txtBoxPhoneDelivery;
        private System.Windows.Forms.TextBox txtBoxAddressDelivery;
        private System.Windows.Forms.Button btnEdit;
    }
}