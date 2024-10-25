namespace cSharpIccCalculator
{
    partial class HistoryForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customizedBorRadPanel1 = new cSharpIccCalculator.CustomizedBorRadPanel();
            this.customizedBorRadPanel2 = new cSharpIccCalculator.CustomizedBorRadPanel();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customizedBorRadPanel1.SuspendLayout();
            this.customizedBorRadPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customizedBorRadPanel1
            // 
            this.customizedBorRadPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.customizedBorRadPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.customizedBorRadPanel1.BorderColor = System.Drawing.Color.White;
            this.customizedBorRadPanel1.BorderRadius = 6;
            this.customizedBorRadPanel1.BorderSize = 0;
            this.customizedBorRadPanel1.Controls.Add(this.customizedBorRadPanel2);
            this.customizedBorRadPanel1.Controls.Add(this.label1);
            this.customizedBorRadPanel1.Location = new System.Drawing.Point(0, 0);
            this.customizedBorRadPanel1.Name = "customizedBorRadPanel1";
            this.customizedBorRadPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.customizedBorRadPanel1.Size = new System.Drawing.Size(454, 390);
            this.customizedBorRadPanel1.TabIndex = 2;
            // 
            // customizedBorRadPanel2
            // 
            this.customizedBorRadPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.customizedBorRadPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.customizedBorRadPanel2.BorderColor = System.Drawing.Color.White;
            this.customizedBorRadPanel2.BorderRadius = 20;
            this.customizedBorRadPanel2.BorderSize = 0;
            this.customizedBorRadPanel2.Controls.Add(this.listBoxHistory);
            this.customizedBorRadPanel2.Location = new System.Drawing.Point(13, 99);
            this.customizedBorRadPanel2.Name = "customizedBorRadPanel2";
            this.customizedBorRadPanel2.Padding = new System.Windows.Forms.Padding(15);
            this.customizedBorRadPanel2.Size = new System.Drawing.Size(428, 278);
            this.customizedBorRadPanel2.TabIndex = 2;
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.listBoxHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHistory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHistory.ForeColor = System.Drawing.Color.White;
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.HorizontalScrollbar = true;
            this.listBoxHistory.ItemHeight = 24;
            this.listBoxHistory.Location = new System.Drawing.Point(15, 15);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxHistory.Size = new System.Drawing.Size(398, 248);
            this.listBoxHistory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(428, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HistoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.customizedBorRadPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HistoryForm";
            this.Size = new System.Drawing.Size(454, 390);
            this.customizedBorRadPanel1.ResumeLayout(false);
            this.customizedBorRadPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBoxHistory;
        private CustomizedBorRadPanel customizedBorRadPanel1;
        private CustomizedBorRadPanel customizedBorRadPanel2;
    }
}
