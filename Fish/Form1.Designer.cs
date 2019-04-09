namespace Fish
{
    partial class Form1
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
            this.pbBowl = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spnSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.spnFoodProb = new System.Windows.Forms.NumericUpDown();
            this.btnPause = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbFishDetail = new System.Windows.Forms.PictureBox();
            this.spnFoodSpawnRate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPopSize = new System.Windows.Forms.Label();
            this.spnMinPopulation = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.spnMaxFood = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.spnMaxPopulation = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.spnSpawnRate = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.spnPopSpawnProb = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.spnMovementCost = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.spnReproductionCost = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.spnMutationRate = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.spnMutationProb = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.spnDeathSpawnProb = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.spnDeathSpawnVal = new System.Windows.Forms.NumericUpDown();
            this.spnFoodSpeedX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.spnFoodSpeedY = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.spnHungerRate = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.spnInitialLife = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBowl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFoodProb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFishDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFoodSpawnRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMinPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSpawnRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPopSpawnProb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMovementCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnReproductionCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMutationRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMutationProb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDeathSpawnProb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDeathSpawnVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFoodSpeedX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFoodSpeedY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHungerRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnInitialLife)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBowl
            // 
            this.pbBowl.BackColor = System.Drawing.Color.Transparent;
            this.pbBowl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBowl.Location = new System.Drawing.Point(0, 0);
            this.pbBowl.Name = "pbBowl";
            this.pbBowl.Size = new System.Drawing.Size(1518, 972);
            this.pbBowl.TabIndex = 0;
            this.pbBowl.TabStop = false;
            this.pbBowl.Click += new System.EventHandler(this.pbBowl_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sim Speed:";
            // 
            // spnSpeed
            // 
            this.spnSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnSpeed.Location = new System.Drawing.Point(1450, 7);
            this.spnSpeed.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.spnSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnSpeed.Name = "spnSpeed";
            this.spnSpeed.Size = new System.Drawing.Size(56, 20);
            this.spnSpeed.TabIndex = 5;
            this.spnSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnSpeed.ValueChanged += new System.EventHandler(this.spnSpeed_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1352, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Food Spawn Prob:";
            // 
            // spnFoodProb
            // 
            this.spnFoodProb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnFoodProb.Location = new System.Drawing.Point(1450, 33);
            this.spnFoodProb.Name = "spnFoodProb";
            this.spnFoodProb.Size = new System.Drawing.Size(56, 20);
            this.spnFoodProb.TabIndex = 7;
            this.spnFoodProb.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spnFoodProb.ValueChanged += new System.EventHandler(this.spnFoodProb_ValueChanged);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Location = new System.Drawing.Point(1431, 567);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 8;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbFishDetail
            // 
            this.pbFishDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFishDetail.Location = new System.Drawing.Point(1145, 645);
            this.pbFishDetail.Name = "pbFishDetail";
            this.pbFishDetail.Size = new System.Drawing.Size(361, 315);
            this.pbFishDetail.TabIndex = 9;
            this.pbFishDetail.TabStop = false;
            // 
            // spnFoodSpawnRate
            // 
            this.spnFoodSpawnRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnFoodSpawnRate.Location = new System.Drawing.Point(1450, 59);
            this.spnFoodSpawnRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spnFoodSpawnRate.Name = "spnFoodSpawnRate";
            this.spnFoodSpawnRate.Size = new System.Drawing.Size(56, 20);
            this.spnFoodSpawnRate.TabIndex = 10;
            this.spnFoodSpawnRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spnFoodSpawnRate.ValueChanged += new System.EventHandler(this.spnFoodSpawnRate_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1351, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Food Spawn Rate:";
            // 
            // labelPopSize
            // 
            this.labelPopSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPopSize.AutoSize = true;
            this.labelPopSize.Location = new System.Drawing.Point(1367, 196);
            this.labelPopSize.Name = "labelPopSize";
            this.labelPopSize.Size = new System.Drawing.Size(80, 13);
            this.labelPopSize.TabIndex = 13;
            this.labelPopSize.Text = "Min Population:";
            // 
            // spnMinPopulation
            // 
            this.spnMinPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnMinPopulation.Location = new System.Drawing.Point(1450, 189);
            this.spnMinPopulation.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spnMinPopulation.Name = "spnMinPopulation";
            this.spnMinPopulation.Size = new System.Drawing.Size(56, 20);
            this.spnMinPopulation.TabIndex = 12;
            this.spnMinPopulation.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spnMinPopulation.ValueChanged += new System.EventHandler(this.spnMinPopulation_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1386, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Max Food:";
            // 
            // spnMaxFood
            // 
            this.spnMaxFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnMaxFood.Location = new System.Drawing.Point(1450, 85);
            this.spnMaxFood.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spnMaxFood.Name = "spnMaxFood";
            this.spnMaxFood.Size = new System.Drawing.Size(56, 20);
            this.spnMaxFood.TabIndex = 17;
            this.spnMaxFood.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spnMaxFood.ValueChanged += new System.EventHandler(this.spnMaxFood_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1364, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Max Population:";
            // 
            // spnMaxPopulation
            // 
            this.spnMaxPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnMaxPopulation.Location = new System.Drawing.Point(1450, 215);
            this.spnMaxPopulation.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spnMaxPopulation.Name = "spnMaxPopulation";
            this.spnMaxPopulation.Size = new System.Drawing.Size(56, 20);
            this.spnMaxPopulation.TabIndex = 18;
            this.spnMaxPopulation.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spnMaxPopulation.ValueChanged += new System.EventHandler(this.spnMaxPopulation_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1356, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Pop Spawn Rate:";
            // 
            // spnSpawnRate
            // 
            this.spnSpawnRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnSpawnRate.Location = new System.Drawing.Point(1450, 241);
            this.spnSpawnRate.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.spnSpawnRate.Name = "spnSpawnRate";
            this.spnSpawnRate.Size = new System.Drawing.Size(56, 20);
            this.spnSpawnRate.TabIndex = 20;
            this.spnSpawnRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spnSpawnRate.ValueChanged += new System.EventHandler(this.spnMaxPopulation_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1356, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Pop Spawn Prob:";
            // 
            // spnPopSpawnProb
            // 
            this.spnPopSpawnProb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnPopSpawnProb.DecimalPlaces = 2;
            this.spnPopSpawnProb.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.spnPopSpawnProb.Location = new System.Drawing.Point(1450, 267);
            this.spnPopSpawnProb.Name = "spnPopSpawnProb";
            this.spnPopSpawnProb.Size = new System.Drawing.Size(56, 20);
            this.spnPopSpawnProb.TabIndex = 22;
            this.spnPopSpawnProb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1364, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Movement Cost:";
            // 
            // spnMovementCost
            // 
            this.spnMovementCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnMovementCost.DecimalPlaces = 2;
            this.spnMovementCost.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.spnMovementCost.Location = new System.Drawing.Point(1450, 449);
            this.spnMovementCost.Name = "spnMovementCost";
            this.spnMovementCost.Size = new System.Drawing.Size(56, 20);
            this.spnMovementCost.TabIndex = 30;
            this.spnMovementCost.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.spnMovementCost.ValueChanged += new System.EventHandler(this.propMovementCost_ValueChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1350, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Reproduction Cost:";
            // 
            // spnReproductionCost
            // 
            this.spnReproductionCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnReproductionCost.Location = new System.Drawing.Point(1450, 423);
            this.spnReproductionCost.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.spnReproductionCost.Name = "spnReproductionCost";
            this.spnReproductionCost.Size = new System.Drawing.Size(56, 20);
            this.spnReproductionCost.TabIndex = 28;
            this.spnReproductionCost.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spnReproductionCost.ValueChanged += new System.EventHandler(this.spnReproductionCost_ValueChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1364, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Mutation Rate:";
            // 
            // spnMutationRate
            // 
            this.spnMutationRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnMutationRate.DecimalPlaces = 2;
            this.spnMutationRate.Location = new System.Drawing.Point(1450, 328);
            this.spnMutationRate.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spnMutationRate.Name = "spnMutationRate";
            this.spnMutationRate.Size = new System.Drawing.Size(56, 20);
            this.spnMutationRate.TabIndex = 26;
            this.spnMutationRate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spnMutationRate.ValueChanged += new System.EventHandler(this.spnMutationRate_ValueChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1367, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Mutation Prob:";
            // 
            // spnMutationProb
            // 
            this.spnMutationProb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnMutationProb.DecimalPlaces = 2;
            this.spnMutationProb.Location = new System.Drawing.Point(1450, 302);
            this.spnMutationProb.Name = "spnMutationProb";
            this.spnMutationProb.Size = new System.Drawing.Size(56, 20);
            this.spnMutationProb.TabIndex = 24;
            this.spnMutationProb.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spnMutationProb.ValueChanged += new System.EventHandler(this.spnMutationProb_ValueChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1348, 510);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Death Spawn Prob:";
            // 
            // spnDeathSpawnProb
            // 
            this.spnDeathSpawnProb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnDeathSpawnProb.DecimalPlaces = 2;
            this.spnDeathSpawnProb.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.spnDeathSpawnProb.Location = new System.Drawing.Point(1450, 503);
            this.spnDeathSpawnProb.Name = "spnDeathSpawnProb";
            this.spnDeathSpawnProb.Size = new System.Drawing.Size(56, 20);
            this.spnDeathSpawnProb.TabIndex = 34;
            this.spnDeathSpawnProb.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spnDeathSpawnProb.ValueChanged += new System.EventHandler(this.spnDeathSpawnProb_ValueChanged);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1348, 536);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Death Spawn Val:";
            // 
            // spnDeathSpawnVal
            // 
            this.spnDeathSpawnVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnDeathSpawnVal.DecimalPlaces = 2;
            this.spnDeathSpawnVal.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.spnDeathSpawnVal.Location = new System.Drawing.Point(1450, 529);
            this.spnDeathSpawnVal.Name = "spnDeathSpawnVal";
            this.spnDeathSpawnVal.Size = new System.Drawing.Size(56, 20);
            this.spnDeathSpawnVal.TabIndex = 36;
            this.spnDeathSpawnVal.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spnDeathSpawnVal.ValueChanged += new System.EventHandler(this.spnDeathSpawnVal_ValueChanged);
            // 
            // spnFoodSpeedX
            // 
            this.spnFoodSpeedX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnFoodSpeedX.DecimalPlaces = 2;
            this.spnFoodSpeedX.Location = new System.Drawing.Point(1450, 111);
            this.spnFoodSpeedX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spnFoodSpeedX.Name = "spnFoodSpeedX";
            this.spnFoodSpeedX.Size = new System.Drawing.Size(56, 20);
            this.spnFoodSpeedX.TabIndex = 39;
            this.spnFoodSpeedX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnFoodSpeedX.ValueChanged += new System.EventHandler(this.spnFoodSpeedX_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1369, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Food Speed X:";
            // 
            // spnFoodSpeedY
            // 
            this.spnFoodSpeedY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnFoodSpeedY.DecimalPlaces = 2;
            this.spnFoodSpeedY.Location = new System.Drawing.Point(1450, 137);
            this.spnFoodSpeedY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spnFoodSpeedY.Name = "spnFoodSpeedY";
            this.spnFoodSpeedY.Size = new System.Drawing.Size(56, 20);
            this.spnFoodSpeedY.TabIndex = 41;
            this.spnFoodSpeedY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnFoodSpeedY.ValueChanged += new System.EventHandler(this.spnFoodSpeedY_ValueChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1369, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Food Speed Y:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1370, 479);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Hunger Rate:";
            // 
            // spnHungerRate
            // 
            this.spnHungerRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnHungerRate.Location = new System.Drawing.Point(1450, 477);
            this.spnHungerRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spnHungerRate.Name = "spnHungerRate";
            this.spnHungerRate.Size = new System.Drawing.Size(56, 20);
            this.spnHungerRate.TabIndex = 42;
            this.spnHungerRate.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.spnHungerRate.ValueChanged += new System.EventHandler(this.spnHungerRate_ValueChanged);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1370, 399);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Initial Life:";
            // 
            // spnInitialLife
            // 
            this.spnInitialLife.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnInitialLife.Location = new System.Drawing.Point(1450, 397);
            this.spnInitialLife.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spnInitialLife.Name = "spnInitialLife";
            this.spnInitialLife.Size = new System.Drawing.Size(56, 20);
            this.spnInitialLife.TabIndex = 44;
            this.spnInitialLife.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spnInitialLife.ValueChanged += new System.EventHandler(this.spnInitialLife_ValueChanged);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1503, 430);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 13);
            this.label19.TabIndex = 47;
            this.label19.Text = "%";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(1503, 330);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 13);
            this.label20.TabIndex = 48;
            this.label20.Text = "%";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1503, 309);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 49;
            this.label21.Text = "%";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1503, 274);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 13);
            this.label22.TabIndex = 50;
            this.label22.Text = "%";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1503, 451);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 13);
            this.label23.TabIndex = 51;
            this.label23.Text = "%";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1503, 505);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 13);
            this.label24.TabIndex = 52;
            this.label24.Text = "%";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1503, 531);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(15, 13);
            this.label25.TabIndex = 53;
            this.label25.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 972);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.spnInitialLife);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.spnHungerRate);
            this.Controls.Add(this.spnFoodSpeedY);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.spnFoodSpeedX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.spnDeathSpawnVal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.spnDeathSpawnProb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.spnMovementCost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.spnReproductionCost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.spnMutationRate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.spnMutationProb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.spnPopSpawnProb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.spnSpawnRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.spnMaxPopulation);
            this.Controls.Add(this.spnMaxFood);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPopSize);
            this.Controls.Add(this.spnMinPopulation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.spnFoodSpawnRate);
            this.Controls.Add(this.pbFishDetail);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.spnFoodProb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spnSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBowl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbBowl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFoodProb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFishDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFoodSpawnRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMinPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSpawnRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPopSpawnProb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMovementCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnReproductionCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMutationRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMutationProb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDeathSpawnProb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDeathSpawnVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFoodSpeedX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFoodSpeedY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHungerRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnInitialLife)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBowl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spnSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spnFoodProb;
        private System.Windows.Forms.Button btnPause;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbFishDetail;
        private System.Windows.Forms.NumericUpDown spnFoodSpawnRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPopSize;
        private System.Windows.Forms.NumericUpDown spnMinPopulation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown spnMaxFood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown spnMaxPopulation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown spnSpawnRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown spnPopSpawnProb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown spnMovementCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown spnReproductionCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown spnMutationRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown spnMutationProb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown spnDeathSpawnProb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown spnDeathSpawnVal;
        private System.Windows.Forms.NumericUpDown spnFoodSpeedX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown spnFoodSpeedY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown spnHungerRate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown spnInitialLife;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
    }
}

