namespace ZH3_K158DZ
{
    partial class UserControl1
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
            this.textBoxFogásSzűrés = new System.Windows.Forms.TextBox();
            this.listBoxFogások = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hozzavalokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fogasIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nyersanyagIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nyersanyagNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavalokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFogásSzűrés
            // 
            this.textBoxFogásSzűrés.Location = new System.Drawing.Point(3, 48);
            this.textBoxFogásSzűrés.Name = "textBoxFogásSzűrés";
            this.textBoxFogásSzűrés.Size = new System.Drawing.Size(160, 23);
            this.textBoxFogásSzűrés.TabIndex = 0;
            this.textBoxFogásSzűrés.TextChanged += new System.EventHandler(this.textBoxFogásSzűrés_TextChanged);
            // 
            // listBoxFogások
            // 
            this.listBoxFogások.FormattingEnabled = true;
            this.listBoxFogások.ItemHeight = 15;
            this.listBoxFogások.Location = new System.Drawing.Point(3, 77);
            this.listBoxFogások.Name = "listBoxFogások";
            this.listBoxFogások.Size = new System.Drawing.Size(160, 319);
            this.listBoxFogások.TabIndex = 1;
            this.listBoxFogások.SelectedIndexChanged += new System.EventHandler(this.listBoxFogások_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fogasIdDataGridViewTextBoxColumn,
            this.receptIdDataGridViewTextBoxColumn,
            this.nyersanyagIdDataGridViewTextBoxColumn,
            this.nyersanyagNevDataGridViewTextBoxColumn,
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn,
            this.egysegarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hozzavalokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(169, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(646, 319);
            this.dataGridView1.TabIndex = 2;
            // 
            // hozzavalokBindingSource
            // 
            this.hozzavalokBindingSource.DataSource = typeof(ZH3_K158DZ.Hozzavalok);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Milyen fogást keres?";
            // 
            // fogasIdDataGridViewTextBoxColumn
            // 
            this.fogasIdDataGridViewTextBoxColumn.DataPropertyName = "FogasId";
            this.fogasIdDataGridViewTextBoxColumn.HeaderText = "FogasId";
            this.fogasIdDataGridViewTextBoxColumn.Name = "fogasIdDataGridViewTextBoxColumn";
            this.fogasIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // receptIdDataGridViewTextBoxColumn
            // 
            this.receptIdDataGridViewTextBoxColumn.DataPropertyName = "ReceptId";
            this.receptIdDataGridViewTextBoxColumn.HeaderText = "ReceptId";
            this.receptIdDataGridViewTextBoxColumn.Name = "receptIdDataGridViewTextBoxColumn";
            this.receptIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.receptIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // nyersanyagIdDataGridViewTextBoxColumn
            // 
            this.nyersanyagIdDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagId";
            this.nyersanyagIdDataGridViewTextBoxColumn.HeaderText = "NyersanyagId";
            this.nyersanyagIdDataGridViewTextBoxColumn.Name = "nyersanyagIdDataGridViewTextBoxColumn";
            this.nyersanyagIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nyersanyagIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            this.nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            // 
            // mennyisegiEgysegIdDataGridViewTextBoxColumn
            // 
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn.DataPropertyName = "MennyisegiEgysegId";
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn.HeaderText = "MennyisegiEgysegId";
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn.Name = "mennyisegiEgysegIdDataGridViewTextBoxColumn";
            // 
            // egysegarDataGridViewTextBoxColumn
            // 
            this.egysegarDataGridViewTextBoxColumn.DataPropertyName = "Egysegar";
            this.egysegarDataGridViewTextBoxColumn.HeaderText = "Egysegar";
            this.egysegarDataGridViewTextBoxColumn.Name = "egysegarDataGridViewTextBoxColumn";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBoxFogások);
            this.Controls.Add(this.textBoxFogásSzűrés);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(841, 406);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavalokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxFogásSzűrés;
        private ListBox listBoxFogások;
        private DataGridView dataGridView1;
        private BindingSource hozzavalokBindingSource;
        private Label label1;
        private DataGridViewTextBoxColumn fogasIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn receptIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn nyersanyagIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyisegiEgysegIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegarDataGridViewTextBoxColumn;
    }
}
