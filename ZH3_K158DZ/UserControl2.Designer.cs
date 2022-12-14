namespace ZH3_K158DZ
{
    partial class UserControl2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receptIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nyersanyagIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mennyiseg4foDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyersanyagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNyersanyagSzűrés = new System.Windows.Forms.TextBox();
            this.listBoxNyersanyagok = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receptIdDataGridViewTextBoxColumn,
            this.fogasIdDataGridViewTextBoxColumn,
            this.nyersanyagIdDataGridViewTextBoxColumn,
            this.mennyiseg4foDataGridViewTextBoxColumn,
            this.fogasDataGridViewTextBoxColumn,
            this.nyersanyagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.receptekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(184, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(650, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // receptIdDataGridViewTextBoxColumn
            // 
            this.receptIdDataGridViewTextBoxColumn.DataPropertyName = "ReceptId";
            this.receptIdDataGridViewTextBoxColumn.HeaderText = "ReceptId";
            this.receptIdDataGridViewTextBoxColumn.Name = "receptIdDataGridViewTextBoxColumn";
            // 
            // fogasIdDataGridViewTextBoxColumn
            // 
            this.fogasIdDataGridViewTextBoxColumn.DataPropertyName = "FogasId";
            this.fogasIdDataGridViewTextBoxColumn.HeaderText = "FogasId";
            this.fogasIdDataGridViewTextBoxColumn.Name = "fogasIdDataGridViewTextBoxColumn";
            this.fogasIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fogasIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // nyersanyagIdDataGridViewTextBoxColumn
            // 
            this.nyersanyagIdDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagId";
            this.nyersanyagIdDataGridViewTextBoxColumn.HeaderText = "NyersanyagId";
            this.nyersanyagIdDataGridViewTextBoxColumn.Name = "nyersanyagIdDataGridViewTextBoxColumn";
            this.nyersanyagIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nyersanyagIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            this.mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            // 
            // fogasDataGridViewTextBoxColumn
            // 
            this.fogasDataGridViewTextBoxColumn.DataPropertyName = "Fogas";
            this.fogasDataGridViewTextBoxColumn.HeaderText = "Fogas";
            this.fogasDataGridViewTextBoxColumn.Name = "fogasDataGridViewTextBoxColumn";
            // 
            // nyersanyagDataGridViewTextBoxColumn
            // 
            this.nyersanyagDataGridViewTextBoxColumn.DataPropertyName = "Nyersanyag";
            this.nyersanyagDataGridViewTextBoxColumn.HeaderText = "Nyersanyag";
            this.nyersanyagDataGridViewTextBoxColumn.Name = "nyersanyagDataGridViewTextBoxColumn";
            // 
            // receptekBindingSource
            // 
            this.receptekBindingSource.DataSource = typeof(ZH3_K158DZ.ReceptModels.Receptek);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Milyen nyersanyagot keres?";
            // 
            // textBoxNyersanyagSzűrés
            // 
            this.textBoxNyersanyagSzűrés.Location = new System.Drawing.Point(3, 41);
            this.textBoxNyersanyagSzűrés.Name = "textBoxNyersanyagSzűrés";
            this.textBoxNyersanyagSzűrés.Size = new System.Drawing.Size(152, 23);
            this.textBoxNyersanyagSzűrés.TabIndex = 2;
            this.textBoxNyersanyagSzűrés.TextChanged += new System.EventHandler(this.textBoxNyersanyagSzűrés_TextChanged);
            // 
            // listBoxNyersanyagok
            // 
            this.listBoxNyersanyagok.FormattingEnabled = true;
            this.listBoxNyersanyagok.ItemHeight = 15;
            this.listBoxNyersanyagok.Location = new System.Drawing.Point(3, 72);
            this.listBoxNyersanyagok.Name = "listBoxNyersanyagok";
            this.listBoxNyersanyagok.Size = new System.Drawing.Size(152, 364);
            this.listBoxNyersanyagok.TabIndex = 3;
            this.listBoxNyersanyagok.SelectedIndexChanged += new System.EventHandler(this.listBoxNyersanyagok_SelectedIndexChanged);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.listBoxNyersanyagok);
            this.Controls.Add(this.textBoxNyersanyagSzűrés);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(862, 456);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn receptIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn fogasIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn nyersanyagIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagDataGridViewTextBoxColumn;
        private BindingSource receptekBindingSource;
        private Label label1;
        private TextBox textBoxNyersanyagSzűrés;
        private ListBox listBoxNyersanyagok;
    }
}
