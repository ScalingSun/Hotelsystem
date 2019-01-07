namespace HotelSysteem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbRoom = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.gbxBox = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnOverView = new System.Windows.Forms.Button();
            this.gbxBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kamer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(75, 33);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 4;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(75, 94);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(100, 61);
            this.txbAddress.TabIndex = 5;
            // 
            // txbRoom
            // 
            this.txbRoom.Location = new System.Drawing.Point(75, 175);
            this.txbRoom.Name = "txbRoom";
            this.txbRoom.Size = new System.Drawing.Size(42, 20);
            this.txbRoom.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(75, 228);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 8;
            // 
            // gbxBox
            // 
            this.gbxBox.Controls.Add(this.btnInsert);
            this.gbxBox.Controls.Add(this.label1);
            this.gbxBox.Controls.Add(this.dtpDate);
            this.gbxBox.Controls.Add(this.label2);
            this.gbxBox.Controls.Add(this.txbRoom);
            this.gbxBox.Controls.Add(this.label3);
            this.gbxBox.Controls.Add(this.txbAddress);
            this.gbxBox.Controls.Add(this.label4);
            this.gbxBox.Controls.Add(this.txbName);
            this.gbxBox.Location = new System.Drawing.Point(12, 12);
            this.gbxBox.Name = "gbxBox";
            this.gbxBox.Size = new System.Drawing.Size(407, 285);
            this.gbxBox.TabIndex = 9;
            this.gbxBox.TabStop = false;
            this.gbxBox.Text = "MainBox";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(298, 213);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 55);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Plaats in database";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnOverView
            // 
            this.btnOverView.Location = new System.Drawing.Point(465, 225);
            this.btnOverView.Name = "btnOverView";
            this.btnOverView.Size = new System.Drawing.Size(85, 55);
            this.btnOverView.TabIndex = 10;
            this.btnOverView.Text = "Naar het overzicht";
            this.btnOverView.UseVisualStyleBackColor = true;
            this.btnOverView.Click += new System.EventHandler(this.btnOverView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 333);
            this.Controls.Add(this.btnOverView);
            this.Controls.Add(this.gbxBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxBox.ResumeLayout(false);
            this.gbxBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbRoom;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox gbxBox;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnOverView;
    }
}

