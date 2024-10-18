namespace cSharpIccCalculator
{
    partial class CalculatorForm
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxPresentValue = new System.Windows.Forms.TextBox();
            this.textBoxPreviousValue = new System.Windows.Forms.TextBox();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonClearRecentEntry = new System.Windows.Forms.Button();
            this.buttonModulus = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.ucHistoryForm = new cSharpIccCalculator.HistoryForm();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClear.Location = new System.Drawing.Point(18, 278);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(125, 96);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxPresentValue
            // 
            this.textBoxPresentValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPresentValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBoxPresentValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPresentValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPresentValue.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPresentValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPresentValue.Location = new System.Drawing.Point(17, 152);
            this.textBoxPresentValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 30);
            this.textBoxPresentValue.Name = "textBoxPresentValue";
            this.textBoxPresentValue.ReadOnly = true;
            this.textBoxPresentValue.Size = new System.Drawing.Size(525, 67);
            this.textBoxPresentValue.TabIndex = 0;
            this.textBoxPresentValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPreviousValue
            // 
            this.textBoxPreviousValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPreviousValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBoxPreviousValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPreviousValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPreviousValue.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPreviousValue.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxPreviousValue.Location = new System.Drawing.Point(17, 65);
            this.textBoxPreviousValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 50);
            this.textBoxPreviousValue.Name = "textBoxPreviousValue";
            this.textBoxPreviousValue.ReadOnly = true;
            this.textBoxPreviousValue.Size = new System.Drawing.Size(526, 34);
            this.textBoxPreviousValue.TabIndex = 1;
            this.textBoxPreviousValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonDivision
            // 
            this.buttonDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonDivision.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivision.Font = new System.Drawing.Font("Gadugi", 15F);
            this.buttonDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDivision.Location = new System.Drawing.Point(418, 278);
            this.buttonDivision.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(125, 96);
            this.buttonDivision.TabIndex = 19;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.operation_click);
            // 
            // buttonClearRecentEntry
            // 
            this.buttonClearRecentEntry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClearRecentEntry.BackColor = System.Drawing.Color.Firebrick;
            this.buttonClearRecentEntry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonClearRecentEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearRecentEntry.Font = new System.Drawing.Font("Gadugi", 15F);
            this.buttonClearRecentEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClearRecentEntry.Location = new System.Drawing.Point(151, 278);
            this.buttonClearRecentEntry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClearRecentEntry.Name = "buttonClearRecentEntry";
            this.buttonClearRecentEntry.Size = new System.Drawing.Size(125, 96);
            this.buttonClearRecentEntry.TabIndex = 20;
            this.buttonClearRecentEntry.Text = "CE";
            this.buttonClearRecentEntry.UseVisualStyleBackColor = false;
            this.buttonClearRecentEntry.Click += new System.EventHandler(this.buttonClearRecentEntry_Click);
            // 
            // buttonModulus
            // 
            this.buttonModulus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonModulus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonModulus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonModulus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModulus.Font = new System.Drawing.Font("Gadugi", 15F);
            this.buttonModulus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonModulus.Location = new System.Drawing.Point(285, 278);
            this.buttonModulus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonModulus.Name = "buttonModulus";
            this.buttonModulus.Size = new System.Drawing.Size(125, 96);
            this.buttonModulus.TabIndex = 21;
            this.buttonModulus.Text = "%";
            this.buttonModulus.UseVisualStyleBackColor = false;
            this.buttonModulus.Click += new System.EventHandler(this.operation_click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Gadugi", 15F);
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button9.Location = new System.Drawing.Point(285, 380);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 96);
            this.button9.TabIndex = 25;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Gadugi", 15F);
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button8.Location = new System.Drawing.Point(151, 380);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 96);
            this.button8.TabIndex = 24;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonMultiplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplication.Font = new System.Drawing.Font("Gadugi", 15F);
            this.buttonMultiplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMultiplication.Location = new System.Drawing.Point(418, 380);
            this.buttonMultiplication.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(125, 96);
            this.buttonMultiplication.TabIndex = 23;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.operation_click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Gadugi", 15F);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button7.Location = new System.Drawing.Point(18, 380);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 96);
            this.button7.TabIndex = 22;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Gadugi", 15F);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.Location = new System.Drawing.Point(285, 482);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 96);
            this.button6.TabIndex = 29;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Gadugi", 15F);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.Location = new System.Drawing.Point(151, 482);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 96);
            this.button5.TabIndex = 28;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonSubtraction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtraction.Font = new System.Drawing.Font("Gadugi", 15F);
            this.buttonSubtraction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSubtraction.Location = new System.Drawing.Point(418, 482);
            this.buttonSubtraction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(125, 96);
            this.buttonSubtraction.TabIndex = 27;
            this.buttonSubtraction.Text = "-";
            this.buttonSubtraction.UseVisualStyleBackColor = false;
            this.buttonSubtraction.Click += new System.EventHandler(this.operation_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Gadugi", 15F);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Location = new System.Drawing.Point(18, 482);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 96);
            this.button4.TabIndex = 26;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Gadugi", 15F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Location = new System.Drawing.Point(285, 584);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 96);
            this.button3.TabIndex = 33;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gadugi", 15F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(151, 584);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 96);
            this.button2.TabIndex = 32;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 15F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(18, 584);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 96);
            this.button1.TabIndex = 30;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // buttonDot
            // 
            this.buttonDot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonDot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDot.Font = new System.Drawing.Font("Gadugi", 15F);
            this.buttonDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDot.Location = new System.Drawing.Point(285, 686);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(125, 96);
            this.buttonDot.TabIndex = 37;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEqual.BackColor = System.Drawing.Color.Green;
            this.buttonEqual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqual.Font = new System.Drawing.Font("Gadugi", 15F);
            this.buttonEqual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEqual.Location = new System.Drawing.Point(418, 686);
            this.buttonEqual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(125, 96);
            this.buttonEqual.TabIndex = 35;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Gadugi", 15F);
            this.button0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button0.Location = new System.Drawing.Point(18, 686);
            this.button0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(258, 96);
            this.button0.TabIndex = 34;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonAddition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddition.Font = new System.Drawing.Font("Gadugi", 15F);
            this.buttonAddition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAddition.Location = new System.Drawing.Point(418, 584);
            this.buttonAddition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(125, 96);
            this.buttonAddition.TabIndex = 38;
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = false;
            this.buttonAddition.Click += new System.EventHandler(this.operation_click);
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculator.FlatAppearance.BorderSize = 0;
            this.buttonCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCalculator.Location = new System.Drawing.Point(18, 18);
            this.buttonCalculator.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(125, 34);
            this.buttonCalculator.TabIndex = 39;
            this.buttonCalculator.Text = "Calculator";
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Visible = false;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHistory.FlatAppearance.BorderSize = 0;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonHistory.Location = new System.Drawing.Point(418, 18);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(125, 34);
            this.buttonHistory.TabIndex = 40;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // ucHistoryForm
            // 
            this.ucHistoryForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucHistoryForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ucHistoryForm.Font = new System.Drawing.Font("Gadugi", 12F);
            this.ucHistoryForm.Location = new System.Drawing.Point(18, 278);
            this.ucHistoryForm.Margin = new System.Windows.Forms.Padding(4);
            this.ucHistoryForm.Name = "ucHistoryForm";
            this.ucHistoryForm.Padding = new System.Windows.Forms.Padding(15);
            this.ucHistoryForm.Size = new System.Drawing.Size(525, 504);
            this.ucHistoryForm.TabIndex = 41;
            this.ucHistoryForm.Visible = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(561, 800);
            this.Controls.Add(this.ucHistoryForm);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonCalculator);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonSubtraction);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonModulus);
            this.Controls.Add(this.buttonClearRecentEntry);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxPresentValue);
            this.Controls.Add(this.textBoxPreviousValue);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.Padding = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Winform Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxPresentValue;
        private System.Windows.Forms.TextBox textBoxPreviousValue;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonClearRecentEntry;
        private System.Windows.Forms.Button buttonModulus;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonSubtraction;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.Button buttonHistory;
        private HistoryForm ucHistoryForm;
    }
}

