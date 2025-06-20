using System;

namespace ProjectCafe
{
    partial class FormFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFood));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.ptrbxFood = new System.Windows.Forms.PictureBox();
            this.btnCart = new System.Windows.Forms.Button();
            this.numericUpDownFood = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.listBoxPriceFood = new System.Windows.Forms.ListBox();
            this.grpBoxPastries = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbMCS = new System.Windows.Forms.RadioButton();
            this.rbRVCake = new System.Windows.Forms.RadioButton();
            this.rbCurryPuff = new System.Windows.Forms.RadioButton();
            this.rbChocFudgeCake = new System.Windows.Forms.RadioButton();
            this.rbCMP = new System.Windows.Forms.RadioButton();
            this.rbSausageRoll = new System.Windows.Forms.RadioButton();
            this.rbCarrotCake = new System.Windows.Forms.RadioButton();
            this.rbBBC = new System.Windows.Forms.RadioButton();
            this.rbVanillaWhirl = new System.Windows.Forms.RadioButton();
            this.rbCinRoll = new System.Windows.Forms.RadioButton();
            this.rbPainauChoc = new System.Windows.Forms.RadioButton();
            this.rbButterCroissant = new System.Windows.Forms.RadioButton();
            this.imglstFood = new System.Windows.Forms.ImageList(this.components);
            this.listBoxPrice = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxCartFood = new System.Windows.Forms.ListBox();
            this.btnRemoveFood = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listBoxTotalFood = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbxFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFood)).BeginInit();
            this.grpBoxPastries.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Sienna;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(637, 828);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(161, 56);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Sienna;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(816, 828);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(161, 56);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ptrbxFood
            // 
            this.ptrbxFood.BackColor = System.Drawing.Color.White;
            this.ptrbxFood.Location = new System.Drawing.Point(667, 24);
            this.ptrbxFood.Name = "ptrbxFood";
            this.ptrbxFood.Size = new System.Drawing.Size(316, 256);
            this.ptrbxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbxFood.TabIndex = 16;
            this.ptrbxFood.TabStop = false;
            this.ptrbxFood.Click += new System.EventHandler(this.ptrbxFood_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Sienna;
            this.btnCart.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.Location = new System.Drawing.Point(833, 574);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(144, 43);
            this.btnCart.TabIndex = 15;
            this.btnCart.Text = "Add to cart";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // numericUpDownFood
            // 
            this.numericUpDownFood.Location = new System.Drawing.Point(669, 360);
            this.numericUpDownFood.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFood.Name = "numericUpDownFood";
            this.numericUpDownFood.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownFood.TabIndex = 14;
            this.numericUpDownFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(670, 329);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(101, 25);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "Quantity : ";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // listBoxPriceFood
            // 
            this.listBoxPriceFood.FormattingEnabled = true;
            this.listBoxPriceFood.ItemHeight = 25;
            this.listBoxPriceFood.Location = new System.Drawing.Point(878, 632);
            this.listBoxPriceFood.Name = "listBoxPriceFood";
            this.listBoxPriceFood.Size = new System.Drawing.Size(99, 129);
            this.listBoxPriceFood.TabIndex = 12;
            this.listBoxPriceFood.SelectedIndexChanged += new System.EventHandler(this.listBoxPriceFood_SelectedIndexChanged);
            // 
            // grpBoxPastries
            // 
            this.grpBoxPastries.Controls.Add(this.label4);
            this.grpBoxPastries.Controls.Add(this.label3);
            this.grpBoxPastries.Controls.Add(this.label2);
            this.grpBoxPastries.Controls.Add(this.rbMCS);
            this.grpBoxPastries.Controls.Add(this.rbRVCake);
            this.grpBoxPastries.Controls.Add(this.rbCurryPuff);
            this.grpBoxPastries.Controls.Add(this.rbChocFudgeCake);
            this.grpBoxPastries.Controls.Add(this.rbCMP);
            this.grpBoxPastries.Controls.Add(this.rbSausageRoll);
            this.grpBoxPastries.Controls.Add(this.rbCarrotCake);
            this.grpBoxPastries.Controls.Add(this.rbBBC);
            this.grpBoxPastries.Controls.Add(this.rbVanillaWhirl);
            this.grpBoxPastries.Controls.Add(this.rbCinRoll);
            this.grpBoxPastries.Controls.Add(this.rbPainauChoc);
            this.grpBoxPastries.Controls.Add(this.rbButterCroissant);
            this.grpBoxPastries.Location = new System.Drawing.Point(58, 12);
            this.grpBoxPastries.Name = "grpBoxPastries";
            this.grpBoxPastries.Size = new System.Drawing.Size(387, 634);
            this.grpBoxPastries.TabIndex = 10;
            this.grpBoxPastries.TabStop = false;
            this.grpBoxPastries.Enter += new System.EventHandler(this.grpbxFood_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Croissants and Puff Pastries";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Cakes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Savoury";
            // 
            // rbMCS
            // 
            this.rbMCS.AutoSize = true;
            this.rbMCS.BackColor = System.Drawing.Color.Transparent;
            this.rbMCS.Location = new System.Drawing.Point(43, 556);
            this.rbMCS.Name = "rbMCS";
            this.rbMCS.Size = new System.Drawing.Size(266, 54);
            this.rbMCS.TabIndex = 29;
            this.rbMCS.TabStop = true;
            this.rbMCS.Text = "Mini Croissant Sandwich \r\n(Tuna/Egg Mayo/Chicken)";
            this.rbMCS.UseVisualStyleBackColor = false;
            this.rbMCS.CheckedChanged += new System.EventHandler(this.rbMCS_CheckedChanged);
            // 
            // rbRVCake
            // 
            this.rbRVCake.AutoSize = true;
            this.rbRVCake.Location = new System.Drawing.Point(44, 363);
            this.rbRVCake.Name = "rbRVCake";
            this.rbRVCake.Size = new System.Drawing.Size(180, 29);
            this.rbRVCake.TabIndex = 27;
            this.rbRVCake.TabStop = true;
            this.rbRVCake.Text = "Red Velvet Cake";
            this.rbRVCake.UseVisualStyleBackColor = true;
            this.rbRVCake.CheckedChanged += new System.EventHandler(this.rbRVCake_CheckedChanged);
            // 
            // rbCurryPuff
            // 
            this.rbCurryPuff.AutoSize = true;
            this.rbCurryPuff.Location = new System.Drawing.Point(44, 529);
            this.rbCurryPuff.Name = "rbCurryPuff";
            this.rbCurryPuff.Size = new System.Drawing.Size(120, 29);
            this.rbCurryPuff.TabIndex = 27;
            this.rbCurryPuff.TabStop = true;
            this.rbCurryPuff.Text = "Curry Puff";
            this.rbCurryPuff.UseVisualStyleBackColor = true;
            this.rbCurryPuff.CheckedChanged += new System.EventHandler(this.rbCurryPuff_CheckedChanged);
            // 
            // rbChocFudgeCake
            // 
            this.rbChocFudgeCake.AutoSize = true;
            this.rbChocFudgeCake.Location = new System.Drawing.Point(43, 328);
            this.rbChocFudgeCake.Name = "rbChocFudgeCake";
            this.rbChocFudgeCake.Size = new System.Drawing.Size(235, 29);
            this.rbChocFudgeCake.TabIndex = 25;
            this.rbChocFudgeCake.TabStop = true;
            this.rbChocFudgeCake.Text = "Chocolate Fudge Cake";
            this.rbChocFudgeCake.UseVisualStyleBackColor = true;
            this.rbChocFudgeCake.CheckedChanged += new System.EventHandler(this.rbChocFudgeCake_CheckedChanged);
            // 
            // rbCMP
            // 
            this.rbCMP.AutoSize = true;
            this.rbCMP.Location = new System.Drawing.Point(44, 495);
            this.rbCMP.Name = "rbCMP";
            this.rbCMP.Size = new System.Drawing.Size(280, 29);
            this.rbCMP.TabIndex = 28;
            this.rbCMP.TabStop = true;
            this.rbCMP.Text = "Chicken and Mushroom Puff";
            this.rbCMP.UseVisualStyleBackColor = true;
            this.rbCMP.CheckedChanged += new System.EventHandler(this.rbCMP_CheckedChanged);
            // 
            // rbSausageRoll
            // 
            this.rbSausageRoll.AutoSize = true;
            this.rbSausageRoll.Location = new System.Drawing.Point(45, 460);
            this.rbSausageRoll.Name = "rbSausageRoll";
            this.rbSausageRoll.Size = new System.Drawing.Size(149, 29);
            this.rbSausageRoll.TabIndex = 26;
            this.rbSausageRoll.TabStop = true;
            this.rbSausageRoll.Text = "Sausage Roll";
            this.rbSausageRoll.UseVisualStyleBackColor = true;
            this.rbSausageRoll.CheckedChanged += new System.EventHandler(this.rbSausageRoll_CheckedChanged);
            // 
            // rbCarrotCake
            // 
            this.rbCarrotCake.AutoSize = true;
            this.rbCarrotCake.Location = new System.Drawing.Point(43, 294);
            this.rbCarrotCake.Name = "rbCarrotCake";
            this.rbCarrotCake.Size = new System.Drawing.Size(206, 29);
            this.rbCarrotCake.TabIndex = 26;
            this.rbCarrotCake.TabStop = true;
            this.rbCarrotCake.Text = "Carrot Walnut Cake";
            this.rbCarrotCake.UseVisualStyleBackColor = true;
            this.rbCarrotCake.CheckedChanged += new System.EventHandler(this.rbCarrotCake_CheckedChanged);
            // 
            // rbBBC
            // 
            this.rbBBC.AutoSize = true;
            this.rbBBC.Location = new System.Drawing.Point(44, 259);
            this.rbBBC.Name = "rbBBC";
            this.rbBBC.Size = new System.Drawing.Size(267, 29);
            this.rbBBC.TabIndex = 24;
            this.rbBBC.TabStop = true;
            this.rbBBC.Text = "Basque Burnt Cheesecake";
            this.rbBBC.UseVisualStyleBackColor = true;
            this.rbBBC.CheckedChanged += new System.EventHandler(this.rbBBC_CheckedChanged);
            // 
            // rbVanillaWhirl
            // 
            this.rbVanillaWhirl.AutoSize = true;
            this.rbVanillaWhirl.Location = new System.Drawing.Point(43, 175);
            this.rbVanillaWhirl.Name = "rbVanillaWhirl";
            this.rbVanillaWhirl.Size = new System.Drawing.Size(142, 29);
            this.rbVanillaWhirl.TabIndex = 23;
            this.rbVanillaWhirl.TabStop = true;
            this.rbVanillaWhirl.Text = "Vanilla Whirl";
            this.rbVanillaWhirl.UseVisualStyleBackColor = true;
            this.rbVanillaWhirl.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rbCinRoll
            // 
            this.rbCinRoll.AutoSize = true;
            this.rbCinRoll.Location = new System.Drawing.Point(43, 140);
            this.rbCinRoll.Name = "rbCinRoll";
            this.rbCinRoll.Size = new System.Drawing.Size(160, 29);
            this.rbCinRoll.TabIndex = 21;
            this.rbCinRoll.TabStop = true;
            this.rbCinRoll.Text = "Cinnamon Roll";
            this.rbCinRoll.UseVisualStyleBackColor = true;
            this.rbCinRoll.CheckedChanged += new System.EventHandler(this.rbCinRoll_CheckedChanged);
            // 
            // rbPainauChoc
            // 
            this.rbPainauChoc.AutoSize = true;
            this.rbPainauChoc.Location = new System.Drawing.Point(43, 106);
            this.rbPainauChoc.Name = "rbPainauChoc";
            this.rbPainauChoc.Size = new System.Drawing.Size(182, 29);
            this.rbPainauChoc.TabIndex = 22;
            this.rbPainauChoc.TabStop = true;
            this.rbPainauChoc.Text = "Pain au Chocolat";
            this.rbPainauChoc.UseVisualStyleBackColor = true;
            this.rbPainauChoc.CheckedChanged += new System.EventHandler(this.rbPainauChoc_CheckedChanged);
            // 
            // rbButterCroissant
            // 
            this.rbButterCroissant.AutoSize = true;
            this.rbButterCroissant.Location = new System.Drawing.Point(44, 71);
            this.rbButterCroissant.Name = "rbButterCroissant";
            this.rbButterCroissant.Size = new System.Drawing.Size(162, 29);
            this.rbButterCroissant.TabIndex = 20;
            this.rbButterCroissant.TabStop = true;
            this.rbButterCroissant.Text = "Butter Croisant";
            this.rbButterCroissant.UseVisualStyleBackColor = true;
            this.rbButterCroissant.CheckedChanged += new System.EventHandler(this.rbButterCroissant_CheckedChanged);
            // 
            // imglstFood
            // 
            this.imglstFood.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstFood.ImageStream")));
            this.imglstFood.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstFood.Images.SetKeyName(0, "CroissantEgg.jpg");
            this.imglstFood.Images.SetKeyName(1, "CroissantTomato.jpg");
            this.imglstFood.Images.SetKeyName(2, "MiniSandwish.jpg");
            this.imglstFood.Images.SetKeyName(3, "MuffinChip.jpg");
            this.imglstFood.Images.SetKeyName(4, "MuffinHerb.jpg");
            this.imglstFood.Images.SetKeyName(5, "Pancake.jpg");
            this.imglstFood.Images.SetKeyName(6, "BreadGarlic.jpg");
            this.imglstFood.Images.SetKeyName(7, "CupcakeBerry.jpg");
            this.imglstFood.Images.SetKeyName(8, "Pavlova.jpg");
            this.imglstFood.Images.SetKeyName(9, "SconeCream.jpg");
            this.imglstFood.Images.SetKeyName(10, "CheeseTart.jpg");
            // 
            // listBoxPrice
            // 
            this.listBoxPrice.FormattingEnabled = true;
            this.listBoxPrice.ItemHeight = 25;
            this.listBoxPrice.Location = new System.Drawing.Point(667, 291);
            this.listBoxPrice.Name = "listBoxPrice";
            this.listBoxPrice.Size = new System.Drawing.Size(316, 29);
            this.listBoxPrice.TabIndex = 19;
            this.listBoxPrice.SelectedIndexChanged += new System.EventHandler(this.listBoxPrice_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(670, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Comment : ";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(669, 446);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 112);
            this.textBox1.TabIndex = 21;
            // 
            // listBoxCartFood
            // 
            this.listBoxCartFood.FormattingEnabled = true;
            this.listBoxCartFood.ItemHeight = 25;
            this.listBoxCartFood.Location = new System.Drawing.Point(669, 632);
            this.listBoxCartFood.Name = "listBoxCartFood";
            this.listBoxCartFood.Size = new System.Drawing.Size(203, 129);
            this.listBoxCartFood.TabIndex = 25;
            this.listBoxCartFood.SelectedIndexChanged += new System.EventHandler(this.listBoxCartFood_SelectedIndexChanged);
            // 
            // btnRemoveFood
            // 
            this.btnRemoveFood.BackColor = System.Drawing.Color.Sienna;
            this.btnRemoveFood.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFood.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFood.Location = new System.Drawing.Point(833, 775);
            this.btnRemoveFood.Name = "btnRemoveFood";
            this.btnRemoveFood.Size = new System.Drawing.Size(144, 43);
            this.btnRemoveFood.TabIndex = 26;
            this.btnRemoveFood.Text = "Remove";
            this.btnRemoveFood.UseVisualStyleBackColor = false;
            this.btnRemoveFood.Click += new System.EventHandler(this.btnRemoveFood_Click);
            // 
            // listBoxTotalFood
            // 
            this.listBoxTotalFood.FormattingEnabled = true;
            this.listBoxTotalFood.ItemHeight = 25;
            this.listBoxTotalFood.Location = new System.Drawing.Point(461, 842);
            this.listBoxTotalFood.Name = "listBoxTotalFood";
            this.listBoxTotalFood.Size = new System.Drawing.Size(148, 29);
            this.listBoxTotalFood.TabIndex = 27;
            // 
            // FormFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1071, 581);
            this.Controls.Add(this.listBoxTotalFood);
            this.Controls.Add(this.btnRemoveFood);
            this.Controls.Add(this.listBoxCartFood);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPrice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.ptrbxFood);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.numericUpDownFood);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.listBoxPriceFood);
            this.Controls.Add(this.grpBoxPastries);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select your Food";
            this.Load += new System.EventHandler(this.FormFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbxFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFood)).EndInit();
            this.grpBoxPastries.ResumeLayout(false);
            this.grpBoxPastries.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ptrbxFood_Click(object sender, EventArgs e)
        {
           
        }

        private void listBoxCartFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void grpbxFood_Enter(object sender, EventArgs e)
        {
            
        }

        private void listBoxPriceFood_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {
            
        }

        private void FormFood_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox ptrbxFood;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.NumericUpDown numericUpDownFood;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ListBox listBoxPriceFood;
        private System.Windows.Forms.GroupBox grpBoxPastries;
        private System.Windows.Forms.ImageList imglstFood;
        private System.Windows.Forms.RadioButton rbButterCroissant;
        private System.Windows.Forms.RadioButton rbCinRoll;
        private System.Windows.Forms.RadioButton rbPainauChoc;
        private System.Windows.Forms.ListBox listBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbVanillaWhirl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbMCS;
        private System.Windows.Forms.RadioButton rbRVCake;
        private System.Windows.Forms.RadioButton rbCurryPuff;
        private System.Windows.Forms.RadioButton rbChocFudgeCake;
        private System.Windows.Forms.RadioButton rbCMP;
        private System.Windows.Forms.RadioButton rbSausageRoll;
        private System.Windows.Forms.RadioButton rbCarrotCake;
        private System.Windows.Forms.RadioButton rbBBC;
        private System.Windows.Forms.ListBox listBoxCartFood;
        private System.Windows.Forms.Button btnRemoveFood;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox listBoxTotalFood;
    }
}