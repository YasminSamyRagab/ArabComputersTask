namespace ArabComputersTask.HotelReservation
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
            this.Reserve = new System.Windows.Forms.Button();
            this.CheckOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.VistorsSSN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomsNumberEmpty = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RoomsNumberReserved = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdminID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reserve
            // 
            this.Reserve.Location = new System.Drawing.Point(337, 207);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(75, 23);
            this.Reserve.TabIndex = 3;
            this.Reserve.Text = "Reserve";
            this.Reserve.UseVisualStyleBackColor = true;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // CheckOut
            // 
            this.CheckOut.Location = new System.Drawing.Point(335, 128);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(75, 23);
            this.CheckOut.TabIndex = 4;
            this.CheckOut.Text = "Check Out";
            this.CheckOut.UseVisualStyleBackColor = true;
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EndDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.StartDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.VistorsSSN);
            this.groupBox1.Controls.Add(this.Reserve);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RoomsNumberEmpty);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 259);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " New Reservation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "End Date ";
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(174, 164);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(230, 20);
            this.EndDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start Date ";
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(174, 126);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(230, 20);
            this.StartDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vistor\'s SSN";
            // 
            // VistorsSSN
            // 
            this.VistorsSSN.FormattingEnabled = true;
            this.VistorsSSN.Location = new System.Drawing.Point(174, 86);
            this.VistorsSSN.Name = "VistorsSSN";
            this.VistorsSSN.Size = new System.Drawing.Size(230, 21);
            this.VistorsSSN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Number";
            // 
            // RoomsNumberEmpty
            // 
            this.RoomsNumberEmpty.FormattingEnabled = true;
            this.RoomsNumberEmpty.Location = new System.Drawing.Point(174, 41);
            this.RoomsNumberEmpty.Name = "RoomsNumberEmpty";
            this.RoomsNumberEmpty.Size = new System.Drawing.Size(230, 21);
            this.RoomsNumberEmpty.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.RoomsNumberReserved);
            this.groupBox2.Controls.Add(this.CheckOut);
            this.groupBox2.Location = new System.Drawing.Point(500, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 252);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check Out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room Number";
            // 
            // RoomsNumberReserved
            // 
            this.RoomsNumberReserved.FormattingEnabled = true;
            this.RoomsNumberReserved.Location = new System.Drawing.Point(180, 45);
            this.RoomsNumberReserved.Name = "RoomsNumberReserved";
            this.RoomsNumberReserved.Size = new System.Drawing.Size(230, 21);
            this.RoomsNumberReserved.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(959, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // AdminID
            // 
            this.AdminID.AutoSize = true;
            this.AdminID.Location = new System.Drawing.Point(512, 258);
            this.AdminID.Name = "AdminID";
            this.AdminID.Size = new System.Drawing.Size(0, 13);
            this.AdminID.TabIndex = 8;
            this.AdminID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.AdminID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Reserve;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RoomsNumberEmpty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VistorsSSN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RoomsNumberReserved;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label AdminID;
    }
}

