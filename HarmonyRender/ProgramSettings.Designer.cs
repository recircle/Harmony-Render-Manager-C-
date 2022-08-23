namespace HarmonyRender
{
    partial class ProgramSettings
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
            this.browseHarmonyButton = new System.Windows.Forms.Button();
            this.harmonyPathTextBox = new System.Windows.Forms.TextBox();
            this.videoExport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exportPrefix1 = new System.Windows.Forms.TextBox();
            this.exportPrefix2 = new System.Windows.Forms.TextBox();
            this.exportFileName = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.exportFileName)).BeginInit();
            this.SuspendLayout();
            // 
            // browseHarmonyButton
            // 
            this.browseHarmonyButton.Location = new System.Drawing.Point(777, 10);
            this.browseHarmonyButton.Name = "browseHarmonyButton";
            this.browseHarmonyButton.Size = new System.Drawing.Size(75, 23);
            this.browseHarmonyButton.TabIndex = 0;
            this.browseHarmonyButton.Text = "Open";
            this.browseHarmonyButton.UseVisualStyleBackColor = true;
            this.browseHarmonyButton.Click += new System.EventHandler(this.browseHarmonyButton_Click);
            // 
            // harmonyPathTextBox
            // 
            this.harmonyPathTextBox.Location = new System.Drawing.Point(12, 12);
            this.harmonyPathTextBox.Name = "harmonyPathTextBox";
            this.harmonyPathTextBox.Size = new System.Drawing.Size(759, 20);
            this.harmonyPathTextBox.TabIndex = 2;
            this.harmonyPathTextBox.Text = "Add Harmony exe path";
            this.harmonyPathTextBox.TextChanged += new System.EventHandler(this.HarmonyPathTextBox_TextChanged);
            // 
            // videoExport
            // 
            this.videoExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoExport.FormattingEnabled = true;
            this.videoExport.Items.AddRange(new object[] {
            "MOV-png",
            "H264",
            "SEQUENCE-png"});
            this.videoExport.Location = new System.Drawing.Point(12, 72);
            this.videoExport.Name = "videoExport";
            this.videoExport.Size = new System.Drawing.Size(208, 21);
            this.videoExport.TabIndex = 3;
            this.videoExport.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Export settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Export shot prefix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Export shot prefix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Export file name ###";
            // 
            // exportPrefix1
            // 
            this.exportPrefix1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exportPrefix1.Location = new System.Drawing.Point(12, 132);
            this.exportPrefix1.Name = "exportPrefix1";
            this.exportPrefix1.Size = new System.Drawing.Size(205, 13);
            this.exportPrefix1.TabIndex = 8;
            this.exportPrefix1.Text = "K";
            // 
            // exportPrefix2
            // 
            this.exportPrefix2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exportPrefix2.Location = new System.Drawing.Point(12, 194);
            this.exportPrefix2.Name = "exportPrefix2";
            this.exportPrefix2.Size = new System.Drawing.Size(205, 13);
            this.exportPrefix2.TabIndex = 9;
            this.exportPrefix2.Text = "S";
            // 
            // exportFileName
            // 
            this.exportFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exportFileName.Location = new System.Drawing.Point(12, 258);
            this.exportFileName.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.exportFileName.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.exportFileName.Name = "exportFileName";
            this.exportFileName.Size = new System.Drawing.Size(205, 16);
            this.exportFileName.TabIndex = 11;
            this.exportFileName.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ProgramSettings
            // 
            this.ClientSize = new System.Drawing.Size(864, 453);
            this.Controls.Add(this.exportFileName);
            this.Controls.Add(this.exportPrefix2);
            this.Controls.Add(this.exportPrefix1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoExport);
            this.Controls.Add(this.harmonyPathTextBox);
            this.Controls.Add(this.browseHarmonyButton);
            this.Name = "ProgramSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgramSettings_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgramSettings_FormClosed);
            this.Load += new System.EventHandler(this.ProgramSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exportFileName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttBrowse;
        private System.Windows.Forms.TextBox defaultOutputFolder;
        private System.Windows.Forms.Button browseHarmonyButton;
        private System.Windows.Forms.TextBox harmonyPathTextBox;
        private System.Windows.Forms.ComboBox videoExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox exportPrefix1;
        private System.Windows.Forms.TextBox exportPrefix2;
        private System.Windows.Forms.NumericUpDown exportFileName;
    }
}