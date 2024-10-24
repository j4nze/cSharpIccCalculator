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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.customizedBorRadPanel1 = new cSharpIccCalculator.CustomizedBorRadPanel();
            this.customizedNoCaretTextBoxPresentValue = new cSharpIccCalculator.CustomizedNoCaretTextBox();
            this.textBoxPreviousValue = new System.Windows.Forms.TextBox();
            this.customizedBorRadPanel2 = new cSharpIccCalculator.CustomizedBorRadPanel();
            this.ucHistoryForm = new cSharpIccCalculator.HistoryForm();
            this.customizedBorRadButtonAddition = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButtonSubtraction = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButtonMultiplication = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButtonDecimal = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButton0 = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButton3 = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButton1 = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButton4 = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButton5 = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButton6 = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButton9 = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButton8 = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButton7 = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButtonDivision = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButtonClearEntry = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButtonPercent = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButtonClear = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButton2 = new cSharpIccCalculator.CustomizedBorRadButton();
            this.customizedBorRadButtonEqual = new cSharpIccCalculator.CustomizedBorRadButton();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.customizedBorRadPanel1.SuspendLayout();
            this.customizedBorRadPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customizedBorRadPanel1
            // 
            this.customizedBorRadPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customizedBorRadPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customizedBorRadPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.customizedBorRadPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.customizedBorRadPanel1.BorderColor = System.Drawing.Color.White;
            this.customizedBorRadPanel1.BorderRadius = 20;
            this.customizedBorRadPanel1.BorderSize = 0;
            this.customizedBorRadPanel1.Controls.Add(this.customizedNoCaretTextBoxPresentValue);
            this.customizedBorRadPanel1.Controls.Add(this.textBoxPreviousValue);
            this.customizedBorRadPanel1.Location = new System.Drawing.Point(23, 89);
            this.customizedBorRadPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.customizedBorRadPanel1.Name = "customizedBorRadPanel1";
            this.customizedBorRadPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.customizedBorRadPanel1.Size = new System.Drawing.Size(648, 207);
            this.customizedBorRadPanel1.TabIndex = 43;
            // 
            // customizedNoCaretTextBoxPresentValue
            // 
            this.customizedNoCaretTextBoxPresentValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.customizedNoCaretTextBoxPresentValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customizedNoCaretTextBoxPresentValue.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold);
            this.customizedNoCaretTextBoxPresentValue.ForeColor = System.Drawing.Color.White;
            this.customizedNoCaretTextBoxPresentValue.Location = new System.Drawing.Point(24, 90);
            this.customizedNoCaretTextBoxPresentValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 30);
            this.customizedNoCaretTextBoxPresentValue.Name = "customizedNoCaretTextBoxPresentValue";
            this.customizedNoCaretTextBoxPresentValue.ReadOnly = true;
            this.customizedNoCaretTextBoxPresentValue.Size = new System.Drawing.Size(600, 67);
            this.customizedNoCaretTextBoxPresentValue.TabIndex = 100;
            this.customizedNoCaretTextBoxPresentValue.Text = "0";
            this.customizedNoCaretTextBoxPresentValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.customizedNoCaretTextBoxPresentValue.TextChanged += new System.EventHandler(this.textBoxPresentValue_TextChanged);
            // 
            // textBoxPreviousValue
            // 
            this.textBoxPreviousValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPreviousValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textBoxPreviousValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPreviousValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPreviousValue.Enabled = false;
            this.textBoxPreviousValue.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPreviousValue.ForeColor = System.Drawing.Color.White;
            this.textBoxPreviousValue.Location = new System.Drawing.Point(24, 23);
            this.textBoxPreviousValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 30);
            this.textBoxPreviousValue.Name = "textBoxPreviousValue";
            this.textBoxPreviousValue.ReadOnly = true;
            this.textBoxPreviousValue.Size = new System.Drawing.Size(600, 34);
            this.textBoxPreviousValue.TabIndex = 1;
            this.textBoxPreviousValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customizedBorRadPanel2
            // 
            this.customizedBorRadPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customizedBorRadPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.customizedBorRadPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.customizedBorRadPanel2.BorderColor = System.Drawing.Color.White;
            this.customizedBorRadPanel2.BorderRadius = 20;
            this.customizedBorRadPanel2.BorderSize = 0;
            this.customizedBorRadPanel2.Controls.Add(this.ucHistoryForm);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButtonAddition);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButtonSubtraction);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButtonMultiplication);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButtonDecimal);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButton0);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButton3);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButton1);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButton4);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButton5);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButton6);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButton9);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButton8);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButton7);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButtonDivision);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButtonClearEntry);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButtonPercent);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButtonClear);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButton2);
            this.customizedBorRadPanel2.Controls.Add(this.customizedBorRadButtonEqual);
            this.customizedBorRadPanel2.Location = new System.Drawing.Point(23, 339);
            this.customizedBorRadPanel2.Name = "customizedBorRadPanel2";
            this.customizedBorRadPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.customizedBorRadPanel2.Size = new System.Drawing.Size(648, 482);
            this.customizedBorRadPanel2.TabIndex = 44;
            // 
            // ucHistoryForm
            // 
            this.ucHistoryForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucHistoryForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucHistoryForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.ucHistoryForm.Font = new System.Drawing.Font("Gadugi", 12F);
            this.ucHistoryForm.Location = new System.Drawing.Point(-1, 1);
            this.ucHistoryForm.Margin = new System.Windows.Forms.Padding(4);
            this.ucHistoryForm.Name = "ucHistoryForm";
            this.ucHistoryForm.Padding = new System.Windows.Forms.Padding(15);
            this.ucHistoryForm.Size = new System.Drawing.Size(648, 482);
            this.ucHistoryForm.TabIndex = 41;
            this.ucHistoryForm.Visible = false;
            // 
            // customizedBorRadButtonAddition
            // 
            this.customizedBorRadButtonAddition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.customizedBorRadButtonAddition.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.customizedBorRadButtonAddition.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButtonAddition.BorderRadius = 10;
            this.customizedBorRadButtonAddition.BorderSize = 0;
            this.customizedBorRadButtonAddition.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButtonAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButtonAddition.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButtonAddition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonAddition.Location = new System.Drawing.Point(485, 290);
            this.customizedBorRadButtonAddition.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButtonAddition.Name = "customizedBorRadButtonAddition";
            this.customizedBorRadButtonAddition.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButtonAddition.TabIndex = 59;
            this.customizedBorRadButtonAddition.Text = "+";
            this.customizedBorRadButtonAddition.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonAddition.UseVisualStyleBackColor = false;
            this.customizedBorRadButtonAddition.Click += new System.EventHandler(this.operation_click);
            // 
            // customizedBorRadButtonSubtraction
            // 
            this.customizedBorRadButtonSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.customizedBorRadButtonSubtraction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.customizedBorRadButtonSubtraction.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButtonSubtraction.BorderRadius = 10;
            this.customizedBorRadButtonSubtraction.BorderSize = 0;
            this.customizedBorRadButtonSubtraction.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButtonSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButtonSubtraction.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButtonSubtraction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonSubtraction.Location = new System.Drawing.Point(485, 198);
            this.customizedBorRadButtonSubtraction.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButtonSubtraction.Name = "customizedBorRadButtonSubtraction";
            this.customizedBorRadButtonSubtraction.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButtonSubtraction.TabIndex = 58;
            this.customizedBorRadButtonSubtraction.Text = "-";
            this.customizedBorRadButtonSubtraction.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonSubtraction.UseVisualStyleBackColor = false;
            this.customizedBorRadButtonSubtraction.Click += new System.EventHandler(this.operation_click);
            // 
            // customizedBorRadButtonMultiplication
            // 
            this.customizedBorRadButtonMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.customizedBorRadButtonMultiplication.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.customizedBorRadButtonMultiplication.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButtonMultiplication.BorderRadius = 10;
            this.customizedBorRadButtonMultiplication.BorderSize = 0;
            this.customizedBorRadButtonMultiplication.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButtonMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButtonMultiplication.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButtonMultiplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonMultiplication.Location = new System.Drawing.Point(485, 106);
            this.customizedBorRadButtonMultiplication.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButtonMultiplication.Name = "customizedBorRadButtonMultiplication";
            this.customizedBorRadButtonMultiplication.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButtonMultiplication.TabIndex = 57;
            this.customizedBorRadButtonMultiplication.Text = "*";
            this.customizedBorRadButtonMultiplication.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonMultiplication.UseVisualStyleBackColor = false;
            this.customizedBorRadButtonMultiplication.Click += new System.EventHandler(this.operation_click);
            // 
            // customizedBorRadButtonDecimal
            // 
            this.customizedBorRadButtonDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButtonDecimal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButtonDecimal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButtonDecimal.BorderRadius = 10;
            this.customizedBorRadButtonDecimal.BorderSize = 0;
            this.customizedBorRadButtonDecimal.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButtonDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButtonDecimal.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButtonDecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButtonDecimal.Location = new System.Drawing.Point(328, 384);
            this.customizedBorRadButtonDecimal.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButtonDecimal.Name = "customizedBorRadButtonDecimal";
            this.customizedBorRadButtonDecimal.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButtonDecimal.TabIndex = 56;
            this.customizedBorRadButtonDecimal.Text = ".";
            this.customizedBorRadButtonDecimal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButtonDecimal.UseVisualStyleBackColor = false;
            this.customizedBorRadButtonDecimal.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // customizedBorRadButton0
            // 
            this.customizedBorRadButton0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton0.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton0.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButton0.BorderRadius = 10;
            this.customizedBorRadButton0.BorderSize = 0;
            this.customizedBorRadButton0.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButton0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButton0.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButton0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton0.Location = new System.Drawing.Point(14, 384);
            this.customizedBorRadButton0.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButton0.Name = "customizedBorRadButton0";
            this.customizedBorRadButton0.Size = new System.Drawing.Size(306, 84);
            this.customizedBorRadButton0.TabIndex = 55;
            this.customizedBorRadButton0.Text = "0";
            this.customizedBorRadButton0.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton0.UseVisualStyleBackColor = false;
            this.customizedBorRadButton0.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // customizedBorRadButton3
            // 
            this.customizedBorRadButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButton3.BorderRadius = 10;
            this.customizedBorRadButton3.BorderSize = 0;
            this.customizedBorRadButton3.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButton3.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton3.Location = new System.Drawing.Point(328, 290);
            this.customizedBorRadButton3.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButton3.Name = "customizedBorRadButton3";
            this.customizedBorRadButton3.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButton3.TabIndex = 54;
            this.customizedBorRadButton3.Text = "3";
            this.customizedBorRadButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton3.UseVisualStyleBackColor = false;
            this.customizedBorRadButton3.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // customizedBorRadButton1
            // 
            this.customizedBorRadButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButton1.BorderRadius = 10;
            this.customizedBorRadButton1.BorderSize = 0;
            this.customizedBorRadButton1.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButton1.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton1.Location = new System.Drawing.Point(14, 290);
            this.customizedBorRadButton1.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButton1.Name = "customizedBorRadButton1";
            this.customizedBorRadButton1.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButton1.TabIndex = 52;
            this.customizedBorRadButton1.Text = "1";
            this.customizedBorRadButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton1.UseVisualStyleBackColor = false;
            this.customizedBorRadButton1.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // customizedBorRadButton4
            // 
            this.customizedBorRadButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButton4.BorderRadius = 10;
            this.customizedBorRadButton4.BorderSize = 0;
            this.customizedBorRadButton4.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButton4.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton4.Location = new System.Drawing.Point(14, 198);
            this.customizedBorRadButton4.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButton4.Name = "customizedBorRadButton4";
            this.customizedBorRadButton4.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButton4.TabIndex = 51;
            this.customizedBorRadButton4.Text = "4";
            this.customizedBorRadButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton4.UseVisualStyleBackColor = false;
            this.customizedBorRadButton4.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // customizedBorRadButton5
            // 
            this.customizedBorRadButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButton5.BorderRadius = 10;
            this.customizedBorRadButton5.BorderSize = 0;
            this.customizedBorRadButton5.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButton5.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton5.Location = new System.Drawing.Point(171, 198);
            this.customizedBorRadButton5.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButton5.Name = "customizedBorRadButton5";
            this.customizedBorRadButton5.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButton5.TabIndex = 50;
            this.customizedBorRadButton5.Text = "5";
            this.customizedBorRadButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton5.UseVisualStyleBackColor = false;
            this.customizedBorRadButton5.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // customizedBorRadButton6
            // 
            this.customizedBorRadButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButton6.BorderRadius = 10;
            this.customizedBorRadButton6.BorderSize = 0;
            this.customizedBorRadButton6.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButton6.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton6.Location = new System.Drawing.Point(328, 198);
            this.customizedBorRadButton6.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButton6.Name = "customizedBorRadButton6";
            this.customizedBorRadButton6.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButton6.TabIndex = 49;
            this.customizedBorRadButton6.Text = "6";
            this.customizedBorRadButton6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton6.UseVisualStyleBackColor = false;
            this.customizedBorRadButton6.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // customizedBorRadButton9
            // 
            this.customizedBorRadButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton9.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButton9.BorderRadius = 10;
            this.customizedBorRadButton9.BorderSize = 0;
            this.customizedBorRadButton9.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButton9.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton9.Location = new System.Drawing.Point(328, 106);
            this.customizedBorRadButton9.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButton9.Name = "customizedBorRadButton9";
            this.customizedBorRadButton9.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButton9.TabIndex = 48;
            this.customizedBorRadButton9.Text = "9";
            this.customizedBorRadButton9.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton9.UseVisualStyleBackColor = false;
            this.customizedBorRadButton9.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // customizedBorRadButton8
            // 
            this.customizedBorRadButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButton8.BorderRadius = 10;
            this.customizedBorRadButton8.BorderSize = 0;
            this.customizedBorRadButton8.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButton8.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton8.Location = new System.Drawing.Point(171, 106);
            this.customizedBorRadButton8.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButton8.Name = "customizedBorRadButton8";
            this.customizedBorRadButton8.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButton8.TabIndex = 47;
            this.customizedBorRadButton8.Text = "8";
            this.customizedBorRadButton8.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton8.UseVisualStyleBackColor = false;
            this.customizedBorRadButton8.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // customizedBorRadButton7
            // 
            this.customizedBorRadButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButton7.BorderRadius = 10;
            this.customizedBorRadButton7.BorderSize = 0;
            this.customizedBorRadButton7.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.customizedBorRadButton7.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButton7.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton7.Location = new System.Drawing.Point(14, 106);
            this.customizedBorRadButton7.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButton7.Name = "customizedBorRadButton7";
            this.customizedBorRadButton7.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButton7.TabIndex = 46;
            this.customizedBorRadButton7.Text = "7";
            this.customizedBorRadButton7.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton7.UseVisualStyleBackColor = false;
            this.customizedBorRadButton7.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // customizedBorRadButtonDivision
            // 
            this.customizedBorRadButtonDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.customizedBorRadButtonDivision.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.customizedBorRadButtonDivision.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButtonDivision.BorderRadius = 10;
            this.customizedBorRadButtonDivision.BorderSize = 0;
            this.customizedBorRadButtonDivision.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButtonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButtonDivision.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButtonDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonDivision.Location = new System.Drawing.Point(485, 14);
            this.customizedBorRadButtonDivision.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButtonDivision.Name = "customizedBorRadButtonDivision";
            this.customizedBorRadButtonDivision.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButtonDivision.TabIndex = 45;
            this.customizedBorRadButtonDivision.Text = "/";
            this.customizedBorRadButtonDivision.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonDivision.UseVisualStyleBackColor = false;
            this.customizedBorRadButtonDivision.Click += new System.EventHandler(this.operation_click);
            // 
            // customizedBorRadButtonClearEntry
            // 
            this.customizedBorRadButtonClearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.customizedBorRadButtonClearEntry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.customizedBorRadButtonClearEntry.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButtonClearEntry.BorderRadius = 10;
            this.customizedBorRadButtonClearEntry.BorderSize = 0;
            this.customizedBorRadButtonClearEntry.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButtonClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButtonClearEntry.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButtonClearEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonClearEntry.Location = new System.Drawing.Point(171, 14);
            this.customizedBorRadButtonClearEntry.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButtonClearEntry.Name = "customizedBorRadButtonClearEntry";
            this.customizedBorRadButtonClearEntry.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButtonClearEntry.TabIndex = 44;
            this.customizedBorRadButtonClearEntry.Text = "C";
            this.customizedBorRadButtonClearEntry.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonClearEntry.UseVisualStyleBackColor = false;
            this.customizedBorRadButtonClearEntry.Click += new System.EventHandler(this.buttonClearRecentEntry_Click);
            // 
            // customizedBorRadButtonPercent
            // 
            this.customizedBorRadButtonPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.customizedBorRadButtonPercent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(94)))));
            this.customizedBorRadButtonPercent.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButtonPercent.BorderRadius = 10;
            this.customizedBorRadButtonPercent.BorderSize = 0;
            this.customizedBorRadButtonPercent.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButtonPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButtonPercent.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButtonPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonPercent.Location = new System.Drawing.Point(328, 14);
            this.customizedBorRadButtonPercent.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButtonPercent.Name = "customizedBorRadButtonPercent";
            this.customizedBorRadButtonPercent.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButtonPercent.TabIndex = 43;
            this.customizedBorRadButtonPercent.Text = "%";
            this.customizedBorRadButtonPercent.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonPercent.UseVisualStyleBackColor = false;
            this.customizedBorRadButtonPercent.Click += new System.EventHandler(this.operation_click);
            // 
            // customizedBorRadButtonClear
            // 
            this.customizedBorRadButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customizedBorRadButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.customizedBorRadButtonClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.customizedBorRadButtonClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButtonClear.BorderRadius = 10;
            this.customizedBorRadButtonClear.BorderSize = 0;
            this.customizedBorRadButtonClear.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButtonClear.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButtonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonClear.Location = new System.Drawing.Point(14, 14);
            this.customizedBorRadButtonClear.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButtonClear.Name = "customizedBorRadButtonClear";
            this.customizedBorRadButtonClear.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButtonClear.TabIndex = 42;
            this.customizedBorRadButtonClear.Text = "AC";
            this.customizedBorRadButtonClear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonClear.UseVisualStyleBackColor = false;
            this.customizedBorRadButtonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // customizedBorRadButton2
            // 
            this.customizedBorRadButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.customizedBorRadButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButton2.BorderRadius = 10;
            this.customizedBorRadButton2.BorderSize = 0;
            this.customizedBorRadButton2.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButton2.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton2.Location = new System.Drawing.Point(171, 290);
            this.customizedBorRadButton2.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButton2.Name = "customizedBorRadButton2";
            this.customizedBorRadButton2.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButton2.TabIndex = 60;
            this.customizedBorRadButton2.Text = "2";
            this.customizedBorRadButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.customizedBorRadButton2.UseVisualStyleBackColor = false;
            this.customizedBorRadButton2.Click += new System.EventHandler(this.numericAndDecimal_click);
            // 
            // customizedBorRadButtonEqual
            // 
            this.customizedBorRadButtonEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.customizedBorRadButtonEqual.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.customizedBorRadButtonEqual.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customizedBorRadButtonEqual.BorderRadius = 10;
            this.customizedBorRadButtonEqual.BorderSize = 0;
            this.customizedBorRadButtonEqual.FlatAppearance.BorderSize = 0;
            this.customizedBorRadButtonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizedBorRadButtonEqual.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizedBorRadButtonEqual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonEqual.Location = new System.Drawing.Point(485, 384);
            this.customizedBorRadButtonEqual.Margin = new System.Windows.Forms.Padding(4);
            this.customizedBorRadButtonEqual.Name = "customizedBorRadButtonEqual";
            this.customizedBorRadButtonEqual.Size = new System.Drawing.Size(149, 84);
            this.customizedBorRadButtonEqual.TabIndex = 0;
            this.customizedBorRadButtonEqual.Text = "=";
            this.customizedBorRadButtonEqual.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customizedBorRadButtonEqual.UseVisualStyleBackColor = false;
            this.customizedBorRadButtonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.FlatAppearance.BorderSize = 0;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Image = global::cSharpIccCalculator.Properties.Resources.history;
            this.buttonHistory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonHistory.Location = new System.Drawing.Point(47, 23);
            this.buttonHistory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(53, 53);
            this.buttonHistory.TabIndex = 46;
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculator.FlatAppearance.BorderSize = 0;
            this.buttonCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculator.Image = global::cSharpIccCalculator.Properties.Resources.calculator__2_;
            this.buttonCalculator.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCalculator.Location = new System.Drawing.Point(106, 23);
            this.buttonCalculator.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(53, 53);
            this.buttonCalculator.TabIndex = 45;
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Visible = false;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(694, 844);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonCalculator);
            this.Controls.Add(this.customizedBorRadPanel1);
            this.Controls.Add(this.customizedBorRadPanel2);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Winform Calculator";
            this.customizedBorRadPanel1.ResumeLayout(false);
            this.customizedBorRadPanel1.PerformLayout();
            this.customizedBorRadPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPreviousValue;
        private HistoryForm ucHistoryForm;
        private CustomizedBorRadButton customizedBorRadButtonClear;
        private CustomizedBorRadPanel customizedBorRadPanel1;
        private CustomizedBorRadPanel customizedBorRadPanel2;
        private CustomizedBorRadButton customizedBorRadButtonDivision;
        private CustomizedBorRadButton customizedBorRadButtonClearEntry;
        private CustomizedBorRadButton customizedBorRadButtonPercent;
        private CustomizedBorRadButton customizedBorRadButton4;
        private CustomizedBorRadButton customizedBorRadButton5;
        private CustomizedBorRadButton customizedBorRadButton6;
        private CustomizedBorRadButton customizedBorRadButton9;
        private CustomizedBorRadButton customizedBorRadButton8;
        private CustomizedBorRadButton customizedBorRadButton7;
        private CustomizedBorRadButton customizedBorRadButtonEqual;
        private CustomizedBorRadButton customizedBorRadButtonAddition;
        private CustomizedBorRadButton customizedBorRadButtonSubtraction;
        private CustomizedBorRadButton customizedBorRadButtonMultiplication;
        private CustomizedBorRadButton customizedBorRadButtonDecimal;
        private CustomizedBorRadButton customizedBorRadButton0;
        private CustomizedBorRadButton customizedBorRadButton3;
        private CustomizedBorRadButton customizedBorRadButton2;
        private System.Windows.Forms.Button buttonHistory;
        private CustomizedBorRadButton customizedBorRadButton1;
        private CustomizedNoCaretTextBox customizedNoCaretTextBoxPresentValue;
        private System.Windows.Forms.Button buttonCalculator;
    }
}

