namespace AirSystem.Views
{
    partial class frmListarUsuarios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNameFilter = new System.Windows.Forms.Label();
            this.tBoxNameFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblNameFilter
            // 
            this.lblNameFilter.AutoSize = true;
            this.lblNameFilter.Location = new System.Drawing.Point(15, 458);
            this.lblNameFilter.Name = "lblNameFilter";
            this.lblNameFilter.Size = new System.Drawing.Size(38, 13);
            this.lblNameFilter.TabIndex = 1;
            this.lblNameFilter.Text = "Nome:";
            // 
            // tBoxNameFilter
            // 
            this.tBoxNameFilter.Location = new System.Drawing.Point(59, 455);
            this.tBoxNameFilter.Name = "tBoxNameFilter";
            this.tBoxNameFilter.Size = new System.Drawing.Size(203, 20);
            this.tBoxNameFilter.TabIndex = 2;
            // 
            // frmListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.tBoxNameFilter);
            this.Controls.Add(this.lblNameFilter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmListarUsuarios";
            this.Text = "frmListarUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNameFilter;
        private System.Windows.Forms.TextBox tBoxNameFilter;
    }
}