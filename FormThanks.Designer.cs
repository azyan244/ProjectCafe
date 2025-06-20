using System;

namespace ProjectCafe
{
    partial class FormThanks
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
            this.lblThanks = new System.Windows.Forms.Label();
            this.lblTQ = new System.Windows.Forms.Label();
            this.listBoxPickup = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Modern No. 20", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblThanks.Location = new System.Drawing.Point(309, 161);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(534, 83);
            this.lblThanks.TabIndex = 0;
            this.lblThanks.Text = "THANK YOU ";
            // 
            // lblTQ
            // 
            this.lblTQ.AutoSize = true;
            this.lblTQ.Font = new System.Drawing.Font("Modern No. 20", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTQ.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTQ.Location = new System.Drawing.Point(116, 244);
            this.lblTQ.Name = "lblTQ";
            this.lblTQ.Size = new System.Drawing.Size(920, 83);
            this.lblTQ.TabIndex = 1;
            this.lblTQ.Text = "PLEASE COME AGAIN !";
            // 
            // listBoxPickup
            // 
            this.listBoxPickup.FormattingEnabled = true;
            this.listBoxPickup.ItemHeight = 25;
            this.listBoxPickup.Location = new System.Drawing.Point(469, 398);
            this.listBoxPickup.Name = "listBoxPickup";
            this.listBoxPickup.Size = new System.Drawing.Size(214, 79);
            this.listBoxPickup.TabIndex = 2;
            this.listBoxPickup.SelectedIndexChanged += new System.EventHandler(this.listBoxPickup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Pickup Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormThanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1029, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPickup);
            this.Controls.Add(this.lblTQ);
            this.Controls.Add(this.lblThanks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormThanks";
            this.Text = "Thanks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Label lblTQ;
        private System.Windows.Forms.ListBox listBoxPickup;
        private System.Windows.Forms.Label label1;
    }
}