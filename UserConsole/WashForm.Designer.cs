namespace Aqua.User
{
    partial class WashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WashForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBarCode = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxClock = new System.Windows.Forms.PictureBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxOffer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDateRegistered = new System.Windows.Forms.TextBox();
            this.comboBoxLicensePlates = new System.Windows.Forms.ComboBox();
            this.pictureBoxCustomer = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWashesLeft = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.buttonWash = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxBarcode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxBarCode);
            this.groupBox1.Location = new System.Drawing.Point(11, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(773, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.Location = new System.Drawing.Point(13, 18);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(73, 59);
            this.pictureBoxBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBarcode.TabIndex = 17;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(97, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Κωδικός Κάρτας:";
            // 
            // textBoxBarCode
            // 
            this.textBoxBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxBarCode.Location = new System.Drawing.Point(473, 18);
            this.textBoxBarCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBarCode.Name = "textBoxBarCode";
            this.textBoxBarCode.Size = new System.Drawing.Size(285, 62);
            this.textBoxBarCode.TabIndex = 0;
            this.textBoxBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxBarCode.TextChanged += new System.EventHandler(this.textBoxBarCode_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxClock);
            this.groupBox5.Controls.Add(this.labelDateTime);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(772, 94);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ημερομηνία";
            // 
            // pictureBoxClock
            // 
            this.pictureBoxClock.Location = new System.Drawing.Point(13, 33);
            this.pictureBoxClock.Name = "pictureBoxClock";
            this.pictureBoxClock.Size = new System.Drawing.Size(73, 53);
            this.pictureBoxClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClock.TabIndex = 16;
            this.pictureBoxClock.TabStop = false;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelDateTime.Location = new System.Drawing.Point(107, 32);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(0, 39);
            this.labelDateTime.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxOffer);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxDateRegistered);
            this.groupBox2.Controls.Add(this.comboBoxLicensePlates);
            this.groupBox2.Controls.Add(this.pictureBoxCustomer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxWashesLeft);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxCustomerName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(773, 292);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Στοιχεία Πελάτη";
            // 
            // textBoxOffer
            // 
            this.textBoxOffer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxOffer.Location = new System.Drawing.Point(370, 141);
            this.textBoxOffer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOffer.Name = "textBoxOffer";
            this.textBoxOffer.ReadOnly = true;
            this.textBoxOffer.Size = new System.Drawing.Size(391, 46);
            this.textBoxOffer.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(6, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 39);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ημ/νία εγγραφής:";
            // 
            // textBoxDateRegistered
            // 
            this.textBoxDateRegistered.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxDateRegistered.Location = new System.Drawing.Point(370, 198);
            this.textBoxDateRegistered.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDateRegistered.Name = "textBoxDateRegistered";
            this.textBoxDateRegistered.ReadOnly = true;
            this.textBoxDateRegistered.Size = new System.Drawing.Size(391, 31);
            this.textBoxDateRegistered.TabIndex = 23;
            // 
            // comboBoxLicensePlates
            // 
            this.comboBoxLicensePlates.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBoxLicensePlates.FormattingEnabled = true;
            this.comboBoxLicensePlates.Location = new System.Drawing.Point(370, 84);
            this.comboBoxLicensePlates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxLicensePlates.Name = "comboBoxLicensePlates";
            this.comboBoxLicensePlates.Size = new System.Drawing.Size(391, 47);
            this.comboBoxLicensePlates.Sorted = true;
            this.comboBoxLicensePlates.TabIndex = 20;
            // 
            // pictureBoxCustomer
            // 
            this.pictureBoxCustomer.Location = new System.Drawing.Point(13, 29);
            this.pictureBoxCustomer.Name = "pictureBoxCustomer";
            this.pictureBoxCustomer.Size = new System.Drawing.Size(73, 59);
            this.pictureBoxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCustomer.TabIndex = 18;
            this.pictureBoxCustomer.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(5, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(398, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Πλύσεις που απομένουν:";
            // 
            // textBoxWashesLeft
            // 
            this.textBoxWashesLeft.Enabled = false;
            this.textBoxWashesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxWashesLeft.Location = new System.Drawing.Point(595, 239);
            this.textBoxWashesLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxWashesLeft.Name = "textBoxWashesLeft";
            this.textBoxWashesLeft.ReadOnly = true;
            this.textBoxWashesLeft.Size = new System.Drawing.Size(166, 46);
            this.textBoxWashesLeft.TabIndex = 8;
            this.textBoxWashesLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Πακέτο:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Οχήματα:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxCustomerName.Location = new System.Drawing.Point(104, 29);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.ReadOnly = true;
            this.textBoxCustomerName.Size = new System.Drawing.Size(656, 46);
            this.textBoxCustomerName.TabIndex = 2;
            // 
            // buttonWash
            // 
            this.buttonWash.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonWash.Location = new System.Drawing.Point(286, 519);
            this.buttonWash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonWash.Name = "buttonWash";
            this.buttonWash.Size = new System.Drawing.Size(226, 46);
            this.buttonWash.TabIndex = 7;
            this.buttonWash.Text = "ΠΛΥΣΗ";
            this.buttonWash.UseVisualStyleBackColor = true;
            this.buttonWash.Click += new System.EventHandler(this.buttonWash_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewHistory);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox3.Location = new System.Drawing.Point(11, 567);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(771, 203);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Πλύσεις";
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Location = new System.Drawing.Point(6, 32);
            this.dataGridViewHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.RowHeadersWidth = 50;
            this.dataGridViewHistory.RowTemplate.Height = 24;
            this.dataGridViewHistory.Size = new System.Drawing.Size(760, 163);
            this.dataGridViewHistory.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // WashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 772);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonWash);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Πλύση Οχήματος";
            this.Load += new System.EventHandler(this.WashForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBarCode;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBoxClock;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxOffer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDateRegistered;
        private System.Windows.Forms.ComboBox comboBoxLicensePlates;
        private System.Windows.Forms.PictureBox pictureBoxCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWashesLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Button buttonWash;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.Timer timer;
    }
}

