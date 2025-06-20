using System;
using System.Windows.Forms;

namespace ProjectCafe
{
    partial class FormDrink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDrink));
            this.listBoxPriceDrink = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numericUpDownDrink = new System.Windows.Forms.NumericUpDown();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.imglstDrink = new System.Windows.Forms.ImageList(this.components);
            this.grpBoxCoffee = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbVanillaShake = new System.Windows.Forms.RadioButton();
            this.rbCaramelShake = new System.Windows.Forms.RadioButton();
            this.rbStrawberryShake = new System.Windows.Forms.RadioButton();
            this.rbChocShake = new System.Windows.Forms.RadioButton();
            this.rbChocolate = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbChamomile = new System.Windows.Forms.RadioButton();
            this.rbLemon = new System.Windows.Forms.RadioButton();
            this.rbMatcha = new System.Windows.Forms.RadioButton();
            this.rbChai = new System.Windows.Forms.RadioButton();
            this.rbEarlGrey = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCappucino = new System.Windows.Forms.RadioButton();
            this.rbMocha = new System.Windows.Forms.RadioButton();
            this.rbLatte = new System.Windows.Forms.RadioButton();
            this.rbCM = new System.Windows.Forms.RadioButton();
            this.rbAmericano = new System.Windows.Forms.RadioButton();
            this.rbEspresso = new System.Windows.Forms.RadioButton();
            this.ptrbxDrink = new System.Windows.Forms.PictureBox();
            this.txtBoxCommentDrink = new System.Windows.Forms.TextBox();
            this.listBoxTotalDrink = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCold = new System.Windows.Forms.RadioButton();
            this.rbHot = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDrinkCart = new System.Windows.Forms.ListBox();
            this.listBoxDrinkPrice = new System.Windows.Forms.ListBox();
            this.btnRemoveDrink = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrink)).BeginInit();
            this.grpBoxCoffee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbxDrink)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPriceDrink
            // 
            this.listBoxPriceDrink.FormattingEnabled = true;
            this.listBoxPriceDrink.ItemHeight = 25;
            this.listBoxPriceDrink.Location = new System.Drawing.Point(658, 288);
            this.listBoxPriceDrink.Name = "listBoxPriceDrink";
            this.listBoxPriceDrink.Size = new System.Drawing.Size(316, 29);
            this.listBoxPriceDrink.TabIndex = 3;
            this.listBoxPriceDrink.SelectedIndexChanged += new System.EventHandler(this.listBoxPriceDrink_SelectedIndexChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(653, 351);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(101, 25);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity : ";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // numericUpDownDrink
            // 
            this.numericUpDownDrink.Location = new System.Drawing.Point(760, 349);
            this.numericUpDownDrink.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDrink.Name = "numericUpDownDrink";
            this.numericUpDownDrink.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownDrink.TabIndex = 5;
            this.numericUpDownDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownDrink.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDrink.ValueChanged += new System.EventHandler(this.numericUpDownDrink_ValueChanged);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.BackColor = System.Drawing.Color.Sienna;
            this.btnAddtoCart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCart.ForeColor = System.Drawing.Color.White;
            this.btnAddtoCart.Location = new System.Drawing.Point(829, 677);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(144, 43);
            this.btnAddtoCart.TabIndex = 6;
            this.btnAddtoCart.Text = "Add to cart";
            this.btnAddtoCart.UseVisualStyleBackColor = false;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Sienna;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(816, 962);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(161, 56);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // imglstDrink
            // 
            this.imglstDrink.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstDrink.ImageStream")));
            this.imglstDrink.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstDrink.Images.SetKeyName(0, "CheeseCake.jpg");
            this.imglstDrink.Images.SetKeyName(1, "Peanut.jpg");
            this.imglstDrink.Images.SetKeyName(2, "Toblerone.jpg");
            this.imglstDrink.Images.SetKeyName(3, "Biscoff.jpg");
            this.imglstDrink.Images.SetKeyName(4, "Mint.jpg");
            this.imglstDrink.Images.SetKeyName(5, "Oreo.jpg");
            this.imglstDrink.Images.SetKeyName(6, "Peach.jpg");
            this.imglstDrink.Images.SetKeyName(7, "Cappuccino.jpg");
            this.imglstDrink.Images.SetKeyName(8, "Caramel.jpg");
            this.imglstDrink.Images.SetKeyName(9, "DTiramisu.jpg");
            this.imglstDrink.Images.SetKeyName(10, "StrawberryMilkshake.jpg");
            this.imglstDrink.Images.SetKeyName(11, "pCafe.jpg");
            // 
            // grpBoxCoffee
            // 
            this.grpBoxCoffee.Controls.Add(this.label5);
            this.grpBoxCoffee.Controls.Add(this.rbVanillaShake);
            this.grpBoxCoffee.Controls.Add(this.rbCaramelShake);
            this.grpBoxCoffee.Controls.Add(this.rbStrawberryShake);
            this.grpBoxCoffee.Controls.Add(this.rbChocShake);
            this.grpBoxCoffee.Controls.Add(this.rbChocolate);
            this.grpBoxCoffee.Controls.Add(this.label4);
            this.grpBoxCoffee.Controls.Add(this.rbChamomile);
            this.grpBoxCoffee.Controls.Add(this.rbLemon);
            this.grpBoxCoffee.Controls.Add(this.rbMatcha);
            this.grpBoxCoffee.Controls.Add(this.rbChai);
            this.grpBoxCoffee.Controls.Add(this.rbEarlGrey);
            this.grpBoxCoffee.Controls.Add(this.rbEnglish);
            this.grpBoxCoffee.Controls.Add(this.label1);
            this.grpBoxCoffee.Controls.Add(this.rbCappucino);
            this.grpBoxCoffee.Controls.Add(this.rbMocha);
            this.grpBoxCoffee.Controls.Add(this.rbLatte);
            this.grpBoxCoffee.Controls.Add(this.rbCM);
            this.grpBoxCoffee.Controls.Add(this.rbAmericano);
            this.grpBoxCoffee.Controls.Add(this.rbEspresso);
            this.grpBoxCoffee.Location = new System.Drawing.Point(46, 14);
            this.grpBoxCoffee.Name = "grpBoxCoffee";
            this.grpBoxCoffee.Size = new System.Drawing.Size(387, 789);
            this.grpBoxCoffee.TabIndex = 11;
            this.grpBoxCoffee.TabStop = false;
            this.grpBoxCoffee.Enter += new System.EventHandler(this.grpbxDrink_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Non-Coffee";
            // 
            // rbVanillaShake
            // 
            this.rbVanillaShake.AutoSize = true;
            this.rbVanillaShake.Location = new System.Drawing.Point(45, 655);
            this.rbVanillaShake.Name = "rbVanillaShake";
            this.rbVanillaShake.Size = new System.Drawing.Size(154, 29);
            this.rbVanillaShake.TabIndex = 38;
            this.rbVanillaShake.TabStop = true;
            this.rbVanillaShake.Text = "Vanilla Shake";
            this.rbVanillaShake.UseVisualStyleBackColor = true;
            this.rbVanillaShake.CheckedChanged += new System.EventHandler(this.rbVanillaShake_CheckedChanged);
            // 
            // rbCaramelShake
            // 
            this.rbCaramelShake.AutoSize = true;
            this.rbCaramelShake.Location = new System.Drawing.Point(46, 725);
            this.rbCaramelShake.Name = "rbCaramelShake";
            this.rbCaramelShake.Size = new System.Drawing.Size(169, 29);
            this.rbCaramelShake.TabIndex = 41;
            this.rbCaramelShake.TabStop = true;
            this.rbCaramelShake.Text = "Caramel Shake";
            this.rbCaramelShake.UseVisualStyleBackColor = true;
            this.rbCaramelShake.CheckedChanged += new System.EventHandler(this.rbCaramelShake_CheckedChanged);
            // 
            // rbStrawberryShake
            // 
            this.rbStrawberryShake.AutoSize = true;
            this.rbStrawberryShake.Location = new System.Drawing.Point(46, 690);
            this.rbStrawberryShake.Name = "rbStrawberryShake";
            this.rbStrawberryShake.Size = new System.Drawing.Size(189, 29);
            this.rbStrawberryShake.TabIndex = 40;
            this.rbStrawberryShake.TabStop = true;
            this.rbStrawberryShake.Text = "Strawberry Shake";
            this.rbStrawberryShake.UseVisualStyleBackColor = true;
            this.rbStrawberryShake.CheckedChanged += new System.EventHandler(this.rbStrawberryShake_CheckedChanged);
            // 
            // rbChocShake
            // 
            this.rbChocShake.AutoSize = true;
            this.rbChocShake.Location = new System.Drawing.Point(45, 621);
            this.rbChocShake.Name = "rbChocShake";
            this.rbChocShake.Size = new System.Drawing.Size(184, 29);
            this.rbChocShake.TabIndex = 39;
            this.rbChocShake.TabStop = true;
            this.rbChocShake.Text = "Chocolate Shake";
            this.rbChocShake.UseVisualStyleBackColor = true;
            this.rbChocShake.CheckedChanged += new System.EventHandler(this.rbChocShake_CheckedChanged);
            // 
            // rbChocolate
            // 
            this.rbChocolate.AutoSize = true;
            this.rbChocolate.Location = new System.Drawing.Point(46, 586);
            this.rbChocolate.Name = "rbChocolate";
            this.rbChocolate.Size = new System.Drawing.Size(122, 29);
            this.rbChocolate.TabIndex = 37;
            this.rbChocolate.TabStop = true;
            this.rbChocolate.Text = "Chocolate";
            this.rbChocolate.UseVisualStyleBackColor = true;
            this.rbChocolate.CheckedChanged += new System.EventHandler(this.rbChocolate_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Coffee";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rbChamomile
            // 
            this.rbChamomile.AutoSize = true;
            this.rbChamomile.Location = new System.Drawing.Point(46, 392);
            this.rbChamomile.Name = "rbChamomile";
            this.rbChamomile.Size = new System.Drawing.Size(132, 29);
            this.rbChamomile.TabIndex = 31;
            this.rbChamomile.TabStop = true;
            this.rbChamomile.Text = "Chamomile";
            this.rbChamomile.UseVisualStyleBackColor = true;
            this.rbChamomile.CheckedChanged += new System.EventHandler(this.rbChamomile_CheckedChanged);
            // 
            // rbLemon
            // 
            this.rbLemon.AutoSize = true;
            this.rbLemon.Location = new System.Drawing.Point(47, 462);
            this.rbLemon.Name = "rbLemon";
            this.rbLemon.Size = new System.Drawing.Size(133, 29);
            this.rbLemon.TabIndex = 35;
            this.rbLemon.TabStop = true;
            this.rbLemon.Text = "Lemon Tea";
            this.rbLemon.UseVisualStyleBackColor = true;
            this.rbLemon.CheckedChanged += new System.EventHandler(this.rbLemon_CheckedChanged);
            // 
            // rbMatcha
            // 
            this.rbMatcha.AutoSize = true;
            this.rbMatcha.Location = new System.Drawing.Point(47, 427);
            this.rbMatcha.Name = "rbMatcha";
            this.rbMatcha.Size = new System.Drawing.Size(146, 29);
            this.rbMatcha.TabIndex = 33;
            this.rbMatcha.TabStop = true;
            this.rbMatcha.Text = "Matcha Latte";
            this.rbMatcha.UseVisualStyleBackColor = true;
            this.rbMatcha.CheckedChanged += new System.EventHandler(this.rbMatcha_CheckedChanged);
            // 
            // rbChai
            // 
            this.rbChai.AutoSize = true;
            this.rbChai.Location = new System.Drawing.Point(47, 497);
            this.rbChai.Name = "rbChai";
            this.rbChai.Size = new System.Drawing.Size(122, 29);
            this.rbChai.TabIndex = 34;
            this.rbChai.TabStop = true;
            this.rbChai.Text = "Chai Latte";
            this.rbChai.UseVisualStyleBackColor = true;
            this.rbChai.CheckedChanged += new System.EventHandler(this.rbChai_CheckedChanged);
            // 
            // rbEarlGrey
            // 
            this.rbEarlGrey.AutoSize = true;
            this.rbEarlGrey.Location = new System.Drawing.Point(46, 358);
            this.rbEarlGrey.Name = "rbEarlGrey";
            this.rbEarlGrey.Size = new System.Drawing.Size(114, 29);
            this.rbEarlGrey.TabIndex = 32;
            this.rbEarlGrey.TabStop = true;
            this.rbEarlGrey.Text = "Earl Grey";
            this.rbEarlGrey.UseVisualStyleBackColor = true;
            this.rbEarlGrey.CheckedChanged += new System.EventHandler(this.rbEarlGrey_CheckedChanged);
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(47, 323);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(184, 29);
            this.rbEnglish.TabIndex = 30;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "English Breakfast";
            this.rbEnglish.UseVisualStyleBackColor = true;
            this.rbEnglish.CheckedChanged += new System.EventHandler(this.rbEnglish_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tea";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rbCappucino
            // 
            this.rbCappucino.AutoSize = true;
            this.rbCappucino.Location = new System.Drawing.Point(45, 127);
            this.rbCappucino.Name = "rbCappucino";
            this.rbCappucino.Size = new System.Drawing.Size(138, 29);
            this.rbCappucino.TabIndex = 21;
            this.rbCappucino.TabStop = true;
            this.rbCappucino.Text = "Cappuccino";
            this.rbCappucino.UseVisualStyleBackColor = true;
            this.rbCappucino.CheckedChanged += new System.EventHandler(this.rbCappucino_CheckedChanged);
            // 
            // rbMocha
            // 
            this.rbMocha.AutoSize = true;
            this.rbMocha.Location = new System.Drawing.Point(46, 197);
            this.rbMocha.Name = "rbMocha";
            this.rbMocha.Size = new System.Drawing.Size(93, 29);
            this.rbMocha.TabIndex = 28;
            this.rbMocha.TabStop = true;
            this.rbMocha.Text = "Mocha";
            this.rbMocha.UseVisualStyleBackColor = true;
            this.rbMocha.CheckedChanged += new System.EventHandler(this.rbMocha_CheckedChanged);
            // 
            // rbLatte
            // 
            this.rbLatte.AutoSize = true;
            this.rbLatte.Location = new System.Drawing.Point(46, 162);
            this.rbLatte.Name = "rbLatte";
            this.rbLatte.Size = new System.Drawing.Size(76, 29);
            this.rbLatte.TabIndex = 23;
            this.rbLatte.TabStop = true;
            this.rbLatte.Text = "Latte";
            this.rbLatte.UseVisualStyleBackColor = true;
            this.rbLatte.CheckedChanged += new System.EventHandler(this.rbLatte_CheckedChanged);
            // 
            // rbCM
            // 
            this.rbCM.AutoSize = true;
            this.rbCM.Location = new System.Drawing.Point(46, 232);
            this.rbCM.Name = "rbCM";
            this.rbCM.Size = new System.Drawing.Size(202, 29);
            this.rbCM.TabIndex = 27;
            this.rbCM.TabStop = true;
            this.rbCM.Text = "Caramel Macchiato";
            this.rbCM.UseVisualStyleBackColor = true;
            this.rbCM.CheckedChanged += new System.EventHandler(this.rbCM_CheckedChanged);
            // 
            // rbAmericano
            // 
            this.rbAmericano.AutoSize = true;
            this.rbAmericano.Location = new System.Drawing.Point(45, 93);
            this.rbAmericano.Name = "rbAmericano";
            this.rbAmericano.Size = new System.Drawing.Size(127, 29);
            this.rbAmericano.TabIndex = 22;
            this.rbAmericano.TabStop = true;
            this.rbAmericano.Text = "Americano";
            this.rbAmericano.UseVisualStyleBackColor = true;
            this.rbAmericano.CheckedChanged += new System.EventHandler(this.rbAmericano_CheckedChanged);
            // 
            // rbEspresso
            // 
            this.rbEspresso.AutoSize = true;
            this.rbEspresso.Location = new System.Drawing.Point(46, 58);
            this.rbEspresso.Name = "rbEspresso";
            this.rbEspresso.Size = new System.Drawing.Size(115, 29);
            this.rbEspresso.TabIndex = 20;
            this.rbEspresso.TabStop = true;
            this.rbEspresso.Text = "Espresso";
            this.rbEspresso.UseVisualStyleBackColor = true;
            this.rbEspresso.CheckedChanged += new System.EventHandler(this.rdbtnStrawberry_CheckedChanged);
            // 
            // ptrbxDrink
            // 
            this.ptrbxDrink.BackColor = System.Drawing.Color.White;
            this.ptrbxDrink.Location = new System.Drawing.Point(658, 26);
            this.ptrbxDrink.Name = "ptrbxDrink";
            this.ptrbxDrink.Size = new System.Drawing.Size(316, 256);
            this.ptrbxDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbxDrink.TabIndex = 7;
            this.ptrbxDrink.TabStop = false;
            this.ptrbxDrink.Click += new System.EventHandler(this.ptrbxDrink_Click);
            // 
            // txtBoxCommentDrink
            // 
            this.txtBoxCommentDrink.BackColor = System.Drawing.Color.White;
            this.txtBoxCommentDrink.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBoxCommentDrink.Location = new System.Drawing.Point(657, 529);
            this.txtBoxCommentDrink.Multiline = true;
            this.txtBoxCommentDrink.Name = "txtBoxCommentDrink";
            this.txtBoxCommentDrink.Size = new System.Drawing.Size(316, 131);
            this.txtBoxCommentDrink.TabIndex = 13;
            // 
            // listBoxTotalDrink
            // 
            this.listBoxTotalDrink.FormattingEnabled = true;
            this.listBoxTotalDrink.ItemHeight = 25;
            this.listBoxTotalDrink.Location = new System.Drawing.Point(608, 975);
            this.listBoxTotalDrink.Name = "listBoxTotalDrink";
            this.listBoxTotalDrink.Size = new System.Drawing.Size(185, 29);
            this.listBoxTotalDrink.TabIndex = 14;
            this.listBoxTotalDrink.SelectedIndexChanged += new System.EventHandler(this.listBoxTotalDrink_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Temperature : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCold);
            this.groupBox2.Controls.Add(this.rbHot);
            this.groupBox2.Location = new System.Drawing.Point(787, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 76);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // rbCold
            // 
            this.rbCold.AutoSize = true;
            this.rbCold.Location = new System.Drawing.Point(106, 25);
            this.rbCold.Name = "rbCold";
            this.rbCold.Size = new System.Drawing.Size(74, 29);
            this.rbCold.TabIndex = 1;
            this.rbCold.TabStop = true;
            this.rbCold.Text = "Cold";
            this.rbCold.UseVisualStyleBackColor = true;
            this.rbCold.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // rbHot
            // 
            this.rbHot.AutoSize = true;
            this.rbHot.Location = new System.Drawing.Point(7, 27);
            this.rbHot.Name = "rbHot";
            this.rbHot.Size = new System.Drawing.Size(63, 29);
            this.rbHot.TabIndex = 0;
            this.rbHot.TabStop = true;
            this.rbHot.Text = "Hot";
            this.rbHot.UseVisualStyleBackColor = true;
            this.rbHot.CheckedChanged += new System.EventHandler(this.rbHot_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(652, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Comment : ";
            // 
            // listBoxDrinkCart
            // 
            this.listBoxDrinkCart.FormattingEnabled = true;
            this.listBoxDrinkCart.ItemHeight = 25;
            this.listBoxDrinkCart.Location = new System.Drawing.Point(657, 750);
            this.listBoxDrinkCart.Name = "listBoxDrinkCart";
            this.listBoxDrinkCart.Size = new System.Drawing.Size(211, 129);
            this.listBoxDrinkCart.TabIndex = 34;
            this.listBoxDrinkCart.SelectedIndexChanged += new System.EventHandler(this.listBoxDrinkCart_SelectedIndexChanged);
            // 
            // listBoxDrinkPrice
            // 
            this.listBoxDrinkPrice.FormattingEnabled = true;
            this.listBoxDrinkPrice.ItemHeight = 25;
            this.listBoxDrinkPrice.Location = new System.Drawing.Point(875, 750);
            this.listBoxDrinkPrice.Name = "listBoxDrinkPrice";
            this.listBoxDrinkPrice.Size = new System.Drawing.Size(99, 129);
            this.listBoxDrinkPrice.TabIndex = 35;
            this.listBoxDrinkPrice.SelectedIndexChanged += new System.EventHandler(this.listBoxDrinkPrice_SelectedIndexChanged);
            // 
            // btnRemoveDrink
            // 
            this.btnRemoveDrink.BackColor = System.Drawing.Color.Sienna;
            this.btnRemoveDrink.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDrink.ForeColor = System.Drawing.Color.White;
            this.btnRemoveDrink.Location = new System.Drawing.Point(830, 897);
            this.btnRemoveDrink.Name = "btnRemoveDrink";
            this.btnRemoveDrink.Size = new System.Drawing.Size(144, 43);
            this.btnRemoveDrink.TabIndex = 36;
            this.btnRemoveDrink.Text = "Remove";
            this.btnRemoveDrink.UseVisualStyleBackColor = false;
            this.btnRemoveDrink.Click += new System.EventHandler(this.btnRemoveDrink_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup_1);
            // 
            // FormDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1134, 581);
            this.Controls.Add(this.btnRemoveDrink);
            this.Controls.Add(this.listBoxDrinkPrice);
            this.Controls.Add(this.listBoxDrinkCart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxTotalDrink);
            this.Controls.Add(this.txtBoxCommentDrink);
            this.Controls.Add(this.grpBoxCoffee);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.ptrbxDrink);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.numericUpDownDrink);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.listBoxPriceDrink);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDrink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select your Drink";
            this.Load += new System.EventHandler(this.FormDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrink)).EndInit();
            this.grpBoxCoffee.ResumeLayout(false);
            this.grpBoxCoffee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbxDrink)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormDrink_Load(object sender, EventArgs e)
        {
            
        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void listBoxDrinkPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void listBoxDrinkCart_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void rbHot_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxTotalDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ptrbxDrink_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void grpbxDrink_Enter(object sender, EventArgs e)
        {
           
        }

        private void numericUpDownDrink_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {
            
        }

        private void listBoxPriceDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        #endregion
        private System.Windows.Forms.ListBox listBoxPriceDrink;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownDrink;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.PictureBox ptrbxDrink;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ImageList imglstDrink;
        private System.Windows.Forms.GroupBox grpBoxCoffee;
        private System.Windows.Forms.RadioButton rbCappucino;
        private System.Windows.Forms.RadioButton rbMocha;
        private System.Windows.Forms.RadioButton rbLatte;
        private System.Windows.Forms.RadioButton rbCM;
        private System.Windows.Forms.RadioButton rbAmericano;
        private System.Windows.Forms.RadioButton rbEspresso;
        private System.Windows.Forms.TextBox txtBoxCommentDrink;
        private System.Windows.Forms.ListBox listBoxTotalDrink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbHot;
        private System.Windows.Forms.RadioButton rbCold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDrinkCart;
        private System.Windows.Forms.ListBox listBoxDrinkPrice;
        private System.Windows.Forms.Button btnRemoveDrink;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rbChamomile;
        private System.Windows.Forms.RadioButton rbLemon;
        private System.Windows.Forms.RadioButton rbMatcha;
        private System.Windows.Forms.RadioButton rbChai;
        private System.Windows.Forms.RadioButton rbEarlGrey;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbVanillaShake;
        private System.Windows.Forms.RadioButton rbCaramelShake;
        private System.Windows.Forms.RadioButton rbStrawberryShake;
        private System.Windows.Forms.RadioButton rbChocShake;
        private System.Windows.Forms.RadioButton rbChocolate;
        private System.Windows.Forms.Label label4;

    }
}