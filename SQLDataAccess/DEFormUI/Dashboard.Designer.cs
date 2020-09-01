namespace DEFormUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FullListButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.GameFoundDataGrid = new System.Windows.Forms.DataGridView();
            this.fullInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hardwareTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameFoundDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Enabled = false;
            this.TitleLabel.Location = new System.Drawing.Point(12, 502);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(118, 37);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "List by:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(434, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FullListButton
            // 
            this.FullListButton.Location = new System.Drawing.Point(136, 480);
            this.FullListButton.Name = "FullListButton";
            this.FullListButton.Size = new System.Drawing.Size(238, 59);
            this.FullListButton.TabIndex = 10;
            this.FullListButton.Text = "Title";
            this.FullListButton.UseVisualStyleBackColor = true;
            this.FullListButton.Click += new System.EventHandler(this.TitleButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "Release Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ReleaseDateButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 59);
            this.button2.TabIndex = 12;
            this.button2.Text = "Hardware Type";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.HardwareTypeButtonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(921, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 59);
            this.button3.TabIndex = 13;
            this.button3.Text = "Genre";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GenreButtonClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(652, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 216);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(136, 243);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(238, 216);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(921, 243);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(226, 215);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // GameFoundDataGrid
            // 
            this.GameFoundDataGrid.AllowUserToAddRows = false;
            this.GameFoundDataGrid.AllowUserToDeleteRows = false;
            this.GameFoundDataGrid.AllowUserToResizeColumns = false;
            this.GameFoundDataGrid.AutoGenerateColumns = false;
            this.GameFoundDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GameFoundDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GameFoundDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameFoundDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.hardwareTypeDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn});
            this.GameFoundDataGrid.DataSource = this.gameBindingSource;
            this.GameFoundDataGrid.Location = new System.Drawing.Point(136, 554);
            this.GameFoundDataGrid.Name = "GameFoundDataGrid";
            this.GameFoundDataGrid.RowHeadersWidth = 62;
            this.GameFoundDataGrid.RowTemplate.Height = 28;
            this.GameFoundDataGrid.Size = new System.Drawing.Size(1017, 650);
            this.GameFoundDataGrid.TabIndex = 20;
            // 
            // fullInfoDataGridViewTextBoxColumn
            // 
            this.fullInfoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fullInfoDataGridViewTextBoxColumn.DataPropertyName = "FullInfo";
            this.fullInfoDataGridViewTextBoxColumn.HeaderText = "FullInfo";
            this.fullInfoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fullInfoDataGridViewTextBoxColumn.Name = "fullInfoDataGridViewTextBoxColumn";
            this.fullInfoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullInfoDataGridViewTextBoxColumn.Width = 150;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(390, 243);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(241, 215);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 113;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "Release_Date";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "Release Date";
            this.releaseDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.Width = 222;
            // 
            // hardwareTypeDataGridViewTextBoxColumn
            // 
            this.hardwareTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hardwareTypeDataGridViewTextBoxColumn.DataPropertyName = "Hardware_Type";
            this.hardwareTypeDataGridViewTextBoxColumn.HeaderText = "Hardware Type";
            this.hardwareTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hardwareTypeDataGridViewTextBoxColumn.Name = "hardwareTypeDataGridViewTextBoxColumn";
            this.hardwareTypeDataGridViewTextBoxColumn.Width = 247;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Width = 141;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataSource = typeof(DEFormUI.Game);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(3025, 1812);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.GameFoundDataGrid);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FullListButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameFoundDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FullListButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView GameFoundDataGrid;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardwareTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

