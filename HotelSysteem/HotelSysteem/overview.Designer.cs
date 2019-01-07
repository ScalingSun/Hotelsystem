namespace HotelSysteem
{
    partial class overview
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
            this.btnGoBack = new System.Windows.Forms.Button();
            this.dgvOverView = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(359, 310);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 1;
            this.btnGoBack.Text = "Ga terug";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // dgvOverView
            // 
            this.dgvOverView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Address,
            this.Room,
            this.Date});
            this.dgvOverView.Location = new System.Drawing.Point(12, 12);
            this.dgvOverView.Name = "dgvOverView";
            this.dgvOverView.Size = new System.Drawing.Size(444, 280);
            this.dgvOverView.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.HeaderText = "Naam";
            this.Name.Name = "Name";
            // 
            // Address
            // 
            this.Address.HeaderText = "Adres";
            this.Address.Name = "Address";
            // 
            // Room
            // 
            this.Room.HeaderText = "Kamer";
            this.Room.Name = "Room";
            // 
            // Date
            // 
            this.Date.HeaderText = "Datum";
            this.Date.Name = "Date";
            // 
            // overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.dgvOverView);
            this.Controls.Add(this.btnGoBack);
            this.Text = "overview";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.DataGridView dgvOverView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}