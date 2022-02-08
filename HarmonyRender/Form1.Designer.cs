
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.defaultOutputFolder = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportPathDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Render = new System.Windows.Forms.DataGridViewImageColumn();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.buttBrowse = new System.Windows.Forms.Button();
            this.rederingTextOutput = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttAddDir = new System.Windows.Forms.Button();
            this.buttAddFile = new System.Windows.Forms.Button();
            this.buttRenderAll = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBfilesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultOutputFolder
            // 
            this.defaultOutputFolder.AllowDrop = true;
            this.defaultOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultOutputFolder.Location = new System.Drawing.Point(138, 20);
            this.defaultOutputFolder.Name = "defaultOutputFolder";
            this.defaultOutputFolder.Size = new System.Drawing.Size(266, 20);
            this.defaultOutputFolder.TabIndex = 1;
            this.defaultOutputFolder.Text = "Set default export dir";
            this.defaultOutputFolder.TextChanged += new System.EventHandler(this.defaultOutputFolder_TextChanged);
            this.defaultOutputFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.defaultOutputFolder_DragDrop);
            this.defaultOutputFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.defaultOutputFolder_DragEnter);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowDrop = true;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.nameDataGridViewTextBoxColumn2,
            this.exportNameDataGridViewTextBoxColumn2,
            this.exportPathDataGridViewTextBoxColumn2,
            this.Frames,
            this.Path,
            this.Render,
            this.Remove});
            this.dataGridView.DataSource = this.tBfilesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(15, 60);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.Size = new System.Drawing.Size(1079, 783);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView_DragDrop);
            this.dataGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView_DragEnter);
            // 
            // Selected
            // 
            this.Selected.HeaderText = "Selected";
            this.Selected.Name = "Selected";
            this.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selected.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.exportPathDataGridViewTextBoxColumn2.Width = 450;
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
            this.Render.Image = global::HarmonyRender.Properties.Resources.YES;
            this.Render.Name = "Render";
            this.Render.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Render.ToolTipText = "Render this file";
            this.Render.Width = 60;
            // 
            // Remove
            // 
            this.Remove.DividerWidth = 10;
            this.Remove.FillWeight = 90F;
            this.Remove.HeaderText = "Remove";
            this.Remove.Image = global::HarmonyRender.Properties.Resources.X;
            this.Remove.Name = "Remove";
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remove.ToolTipText = "Remove this file";
            this.Remove.Width = 60;
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
            // buttBrowse
            // 
            this.buttBrowse.Location = new System.Drawing.Point(421, 18);
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
            this.rederingTextOutput.Location = new System.Drawing.Point(988, 34);
            this.rederingTextOutput.Name = "rederingTextOutput";
            this.rederingTextOutput.Size = new System.Drawing.Size(91, 20);
            this.rederingTextOutput.TabIndex = 8;
            this.rederingTextOutput.Text = "RENDERING";
            this.rederingTextOutput.TextChanged += new System.EventHandler(this.rederingTextOutput_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Render";
            this.dataGridViewImageColumn1.Image = global::HarmonyRender.Properties.Resources.YES;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Render this file";
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DividerWidth = 10;
            this.dataGridViewImageColumn2.FillWeight = 90F;
            this.dataGridViewImageColumn2.HeaderText = "Remove";
            this.dataGridViewImageColumn2.Image = global::HarmonyRender.Properties.Resources.X;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.ToolTipText = "Remove this file";
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // buttAddDir
            // 
            this.buttAddDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttAddDir.FlatAppearance.BorderSize = 0;
            this.buttAddDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttAddDir.Image = global::HarmonyRender.Properties.Resources.ADD_FOLDER;
            this.buttAddDir.Location = new System.Drawing.Point(55, 14);
            this.buttAddDir.Margin = new System.Windows.Forms.Padding(0);
            this.buttAddDir.MaximumSize = new System.Drawing.Size(30, 30);
            this.buttAddDir.Name = "buttAddDir";
            this.buttAddDir.Size = new System.Drawing.Size(30, 30);
            this.buttAddDir.TabIndex = 6;
            this.buttAddDir.UseVisualStyleBackColor = true;
            this.buttAddDir.Click += new System.EventHandler(this.addDir_Click);
            // 
            // buttAddFile
            // 
            this.buttAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttAddFile.FlatAppearance.BorderSize = 0;
            this.buttAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttAddFile.Image = global::HarmonyRender.Properties.Resources.ADD_FILE;
            this.buttAddFile.Location = new System.Drawing.Point(15, 14);
            this.buttAddFile.Margin = new System.Windows.Forms.Padding(0);
            this.buttAddFile.Name = "buttAddFile";
            this.buttAddFile.Size = new System.Drawing.Size(30, 30);
            this.buttAddFile.TabIndex = 5;
            this.buttAddFile.UseVisualStyleBackColor = true;
            this.buttAddFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // buttRenderAll
            // 
            this.buttRenderAll.FlatAppearance.BorderSize = 0;
            this.buttRenderAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttRenderAll.Image = global::HarmonyRender.Properties.Resources.RENDER_ALL;
            this.buttRenderAll.Location = new System.Drawing.Point(95, 14);
            this.buttRenderAll.Margin = new System.Windows.Forms.Padding(0);
            this.buttRenderAll.Name = "buttRenderAll";
            this.buttRenderAll.Size = new System.Drawing.Size(30, 30);
            this.buttRenderAll.TabIndex = 4;
            this.buttRenderAll.UseVisualStyleBackColor = true;
            this.buttRenderAll.Click += new System.EventHandler(this.renderAll_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(561, 20);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(385, 10);
            this.progressBar1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1110, 911);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rederingTextOutput);
            this.Controls.Add(this.buttBrowse);
            this.Controls.Add(this.buttAddDir);
            this.Controls.Add(this.buttAddFile);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.defaultOutputFolder);
            this.Controls.Add(this.buttRenderAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HarmonyRender";
            this.toolTip1.SetToolTip(this, "Harmony renderer");
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
        private System.Windows.Forms.TextBox rederingTextOutput;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn exportNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn exportPathDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewImageColumn Render;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

