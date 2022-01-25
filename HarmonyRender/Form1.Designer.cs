
namespace HarmonyRender
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.defaultOutputFolder = new System.Windows.Forms.TextBox();
            this.buttRenderAll = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportPathDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Render = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tBfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exportPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.framesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.framesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportPathDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttAddFile = new System.Windows.Forms.Button();
            this.buttAddDir = new System.Windows.Forms.Button();
            this.buttBrowse = new System.Windows.Forms.Button();
            this.rederingTextOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBfilesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultOutputFolder
            // 
            this.defaultOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultOutputFolder.Location = new System.Drawing.Point(365, 14);
            this.defaultOutputFolder.Name = "defaultOutputFolder";
            this.defaultOutputFolder.Size = new System.Drawing.Size(358, 20);
            this.defaultOutputFolder.TabIndex = 1;
            this.defaultOutputFolder.Text = "Set default export dir";
            this.defaultOutputFolder.TextChanged += new System.EventHandler(this.defaultOutputFolder_TextChanged);
            // 
            // buttRenderAll
            // 
            this.buttRenderAll.Location = new System.Drawing.Point(15, 65);
            this.buttRenderAll.Name = "buttRenderAll";
            this.buttRenderAll.Size = new System.Drawing.Size(85, 23);
            this.buttRenderAll.TabIndex = 4;
            this.buttRenderAll.Text = "Render All";
            this.buttRenderAll.UseVisualStyleBackColor = true;
            this.buttRenderAll.Click += new System.EventHandler(this.renderAll_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.exportNameDataGridViewTextBoxColumn2,
            this.exportPathDataGridViewTextBoxColumn2,
            this.Frames,
            this.Path,
            this.Render,
            this.Remove});
            this.dataGridView.DataSource = this.tBfilesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(15, 104);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(1171, 783);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.Width = 200;
            // 
            // exportNameDataGridViewTextBoxColumn2
            // 
            this.exportNameDataGridViewTextBoxColumn2.DataPropertyName = "ExportName";
            this.exportNameDataGridViewTextBoxColumn2.HeaderText = "ExportName";
            this.exportNameDataGridViewTextBoxColumn2.Name = "exportNameDataGridViewTextBoxColumn2";
            this.exportNameDataGridViewTextBoxColumn2.Width = 200;
            // 
            // exportPathDataGridViewTextBoxColumn2
            // 
            this.exportPathDataGridViewTextBoxColumn2.DataPropertyName = "ExportPath";
            this.exportPathDataGridViewTextBoxColumn2.FillWeight = 200F;
            this.exportPathDataGridViewTextBoxColumn2.HeaderText = "ExportPath";
            this.exportPathDataGridViewTextBoxColumn2.Name = "exportPathDataGridViewTextBoxColumn2";
            this.exportPathDataGridViewTextBoxColumn2.Width = 400;
            // 
            // Frames
            // 
            this.Frames.DataPropertyName = "Frames";
            this.Frames.HeaderText = "Frames";
            this.Frames.Name = "Frames";
            this.Frames.Width = 70;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.Visible = false;
            // 
            // Render
            // 
            this.Render.HeaderText = "Render";
            this.Render.Name = "Render";
            this.Render.Text = "Render";
            this.Render.ToolTipText = "Render this file";
            // 
            // Remove
            // 
            this.Remove.DividerWidth = 10;
            this.Remove.FillWeight = 90F;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.Text = "Remove";
            this.Remove.ToolTipText = "Remove this file";
            // 
            // tBfilesBindingSource
            // 
            this.tBfilesBindingSource.DataSource = typeof(HarmonyRender.TBfiles);
            // 
            // exportPathDataGridViewTextBoxColumn
            // 
            this.exportPathDataGridViewTextBoxColumn.DataPropertyName = "ExportPath";
            this.exportPathDataGridViewTextBoxColumn.HeaderText = "ExportPath";
            this.exportPathDataGridViewTextBoxColumn.Name = "exportPathDataGridViewTextBoxColumn";
            // 
            // exportNameDataGridViewTextBoxColumn
            // 
            this.exportNameDataGridViewTextBoxColumn.DataPropertyName = "ExportName";
            this.exportNameDataGridViewTextBoxColumn.HeaderText = "ExportName";
            this.exportNameDataGridViewTextBoxColumn.Name = "exportNameDataGridViewTextBoxColumn";
            // 
            // framesDataGridViewTextBoxColumn
            // 
            this.framesDataGridViewTextBoxColumn.DataPropertyName = "Frames";
            this.framesDataGridViewTextBoxColumn.HeaderText = "Frames";
            this.framesDataGridViewTextBoxColumn.Name = "framesDataGridViewTextBoxColumn";
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // pathDataGridViewTextBoxColumn1
            // 
            this.pathDataGridViewTextBoxColumn1.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn1.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn1.Name = "pathDataGridViewTextBoxColumn1";
            // 
            // framesDataGridViewTextBoxColumn1
            // 
            this.framesDataGridViewTextBoxColumn1.DataPropertyName = "Frames";
            this.framesDataGridViewTextBoxColumn1.HeaderText = "Frames";
            this.framesDataGridViewTextBoxColumn1.Name = "framesDataGridViewTextBoxColumn1";
            // 
            // exportNameDataGridViewTextBoxColumn1
            // 
            this.exportNameDataGridViewTextBoxColumn1.DataPropertyName = "ExportName";
            this.exportNameDataGridViewTextBoxColumn1.HeaderText = "ExportName";
            this.exportNameDataGridViewTextBoxColumn1.Name = "exportNameDataGridViewTextBoxColumn1";
            // 
            // exportPathDataGridViewTextBoxColumn1
            // 
            this.exportPathDataGridViewTextBoxColumn1.DataPropertyName = "ExportPath";
            this.exportPathDataGridViewTextBoxColumn1.HeaderText = "ExportPath";
            this.exportPathDataGridViewTextBoxColumn1.Name = "exportPathDataGridViewTextBoxColumn1";
            // 
            // buttAddFile
            // 
            this.buttAddFile.Location = new System.Drawing.Point(15, 12);
            this.buttAddFile.Name = "buttAddFile";
            this.buttAddFile.Size = new System.Drawing.Size(85, 23);
            this.buttAddFile.TabIndex = 5;
            this.buttAddFile.Text = "Add file";
            this.buttAddFile.UseVisualStyleBackColor = true;
            this.buttAddFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // buttAddDir
            // 
            this.buttAddDir.Location = new System.Drawing.Point(15, 39);
            this.buttAddDir.Name = "buttAddDir";
            this.buttAddDir.Size = new System.Drawing.Size(85, 23);
            this.buttAddDir.TabIndex = 6;
            this.buttAddDir.Text = "Add dir";
            this.buttAddDir.UseVisualStyleBackColor = true;
            this.buttAddDir.Click += new System.EventHandler(this.addDir_Click);
            // 
            // buttBrowse
            // 
            this.buttBrowse.Location = new System.Drawing.Point(725, 12);
            this.buttBrowse.Name = "buttBrowse";
            this.buttBrowse.Size = new System.Drawing.Size(85, 23);
            this.buttBrowse.TabIndex = 7;
            this.buttBrowse.Text = "Browse";
            this.buttBrowse.UseVisualStyleBackColor = true;
            this.buttBrowse.Click += new System.EventHandler(this.buttBrowse_Click);
            // 
            // rederingTextOutput
            // 
            this.rederingTextOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rederingTextOutput.Location = new System.Drawing.Point(365, 65);
            this.rederingTextOutput.Name = "rederingTextOutput";
            this.rederingTextOutput.Size = new System.Drawing.Size(445, 20);
            this.rederingTextOutput.TabIndex = 8;
            this.rederingTextOutput.Text = "RENDERING";
            this.rederingTextOutput.TextChanged += new System.EventHandler(this.rederingTextOutput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 911);
            this.Controls.Add(this.rederingTextOutput);
            this.Controls.Add(this.buttBrowse);
            this.Controls.Add(this.buttAddDir);
            this.Controls.Add(this.buttAddFile);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.defaultOutputFolder);
            this.Controls.Add(this.buttRenderAll);
            this.Name = "Form1";
            this.Text = "HarmonyRender";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBfilesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox defaultOutputFolder;
        private System.Windows.Forms.Button buttRenderAll;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn exportPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exportNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn framesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn framesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn exportNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn exportPathDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tBfilesBindingSource;
        private System.Windows.Forms.Button buttAddFile;
        private System.Windows.Forms.Button buttAddDir;
        private System.Windows.Forms.Button buttBrowse;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn exportNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn exportPathDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewButtonColumn Render;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.TextBox rederingTextOutput;
    }
}

