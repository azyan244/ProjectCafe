using System;

namespace ProjectCafe
{
    partial class FormMethod
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
            this.btnChange = new System.Windows.Forms.Button();
            this.listBoxGrandTotal = new System.Windows.Forms.ListBox();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxPrice = new System.Windows.Forms.ListBox();
            this.RemoveOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Sienna;
            this.btnChange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(481, 499);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(237, 54);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Change my Order";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // listBoxGrandTotal
            // 
            this.listBoxGrandTotal.FormattingEnabled = true;
            this.listBoxGrandTotal.ItemHeight = 25;
            this.listBoxGrandTotal.Location = new System.Drawing.Point(47, 366);
            this.listBoxGrandTotal.Name = "listBoxGrandTotal";
            this.listBoxGrandTotal.Size = new System.Drawing.Size(388, 54);
            this.listBoxGrandTotal.TabIndex = 11;
            this.listBoxGrandTotal.SelectedIndexChanged += new System.EventHandler(this.listBoxGrandTotal_SelectedIndexChanged);
            // 
            // listBoxCart
            // 
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.ItemHeight = 25;
            this.listBoxCart.Location = new System.Drawing.Point(47, 66);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(262, 254);
            this.listBoxCart.TabIndex = 10;
            this.listBoxCart.SelectedIndexChanged += new System.EventHandler(this.listBoxCart_SelectedIndexChanged);

            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(42, 30);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 25);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Cart :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(768, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Proceed to payment?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Add anything else?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBoxPrice
            // 
            this.listBoxPrice.FormattingEnabled = true;
            this.listBoxPrice.ItemHeight = 25;
            this.listBoxPrice.Location = new System.Drawing.Point(315, 66);
            this.listBoxPrice.Name = "listBoxPrice";
            this.listBoxPrice.Size = new System.Drawing.Size(120, 254);
            this.listBoxPrice.TabIndex = 17;
            this.listBoxPrice.SelectedIndexChanged += new System.EventHandler(this.listBoxPrice_SelectedIndexChanged);
            // 
            // RemoveOrder
            // 
            this.RemoveOrder.BackColor = System.Drawing.Color.Sienna;
            this.RemoveOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveOrder.Location = new System.Drawing.Point(467, 66);
            this.RemoveOrder.Name = "RemoveOrder";
            this.RemoveOrder.Size = new System.Drawing.Size(175, 49);
            this.RemoveOrder.TabIndex = 18;
            this.RemoveOrder.Text = "Remove";
            this.RemoveOrder.UseCompatibleTextRendering = true;
            this.RemoveOrder.UseVisualStyleBackColor = false;
            this.RemoveOrder.Click += new System.EventHandler(this.RemoveOrder_Click);
            

            // 
            // FormMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1029, 581);
            this.Controls.Add(this.RemoveOrder);
            this.Controls.Add(this.listBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.listBoxGrandTotal);
            this.Controls.Add(this.listBoxCart);
            this.Controls.Add(this.lblTotal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMethod";
            this.Text = "Your Cart";
            this.Load += new System.EventHandler(this.FormMethod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listBoxCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxGrandTotal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        #endregion
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ListBox listBoxGrandTotal;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxPrice;
        private System.Windows.Forms.Button RemoveOrder;
    }
}