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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.customizedBorRadPanel1 = new cSharpIccCalculator.CustomizedBorRadPanel();
            this.customizedBorRadPanel2 = new cSharpIccCalculator.CustomizedBorRadPanel();
            this.customizedBorRadPanel1.SuspendLayout();
            this.customizedBorRadPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(602, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.listBoxHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.HorizontalScrollbar = true;
            this.listBoxHistory.ItemHeight = 24;
            this.listBoxHistory.Location = new System.Drawing.Point(10, 10);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxHistory.Size = new System.Drawing.Size(582, 330);
            this.listBoxHistory.TabIndex = 1;
            this.listBoxHistory.SelectedIndexChanged += new System.EventHandler(this.listBoxHistory_SelectedIndexChanged);
            // 
            // customizedBorRadPanel1
            // 
            this.customizedBorRadPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customizedBorRadPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customizedBorRadPanel1.BorderColor = System.Drawing.Color.White;
            this.customizedBorRadPanel1.BorderRadius = 20;
            this.customizedBorRadPanel1.BorderSize = 2;
            this.customizedBorRadPanel1.Controls.Add(this.customizedBorRadPanel2);
            this.customizedBorRadPanel1.Controls.Add(this.label1);
            this.customizedBorRadPanel1.Location = new System.Drawing.Point(0, 0);
            this.customizedBorRadPanel1.Name = "customizedBorRadPanel1";
            this.customizedBorRadPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.customizedBorRadPanel1.Size = new System.Drawing.Size(648, 482);
            this.customizedBorRadPanel1.TabIndex = 2;
            this.customizedBorRadPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customizedBorRadPanel1_Paint);
            // 
            // customizedBorRadPanel2
            // 
            this.customizedBorRadPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customizedBorRadPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customizedBorRadPanel2.BorderColor = System.Drawing.Color.White;
            this.customizedBorRadPanel2.BorderRadius = 20;
            this.customizedBorRadPanel2.BorderSize = 0;
            this.customizedBorRadPanel2.Controls.Add(this.listBoxHistory);
            this.customizedBorRadPanel2.Location = new System.Drawing.Point(23, 109);
            this.customizedBorRadPanel2.Name = "customizedBorRadPanel2";
            this.customizedBorRadPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.customizedBorRadPanel2.Size = new System.Drawing.Size(602, 350);
            this.customizedBorRadPanel2.TabIndex = 2;
            this.customizedBorRadPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.customizedBorRadPanel2_Paint);
            // 
            // HistoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.customizedBorRadPanel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HistoryForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(648, 482);
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
