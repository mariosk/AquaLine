namespace Aqua.Admin
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAbbreviation = new System.Windows.Forms.TextBox();
            this.labelBarCode = new System.Windows.Forms.Label();
            this.textBoxBarCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDateRegistered = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.comboBoxLicensePlates = new System.Windows.Forms.ComboBox();
            this.pictureBoxCost = new System.Windows.Forms.PictureBox();
            this.pictureBoxCustomer = new System.Windows.Forms.PictureBox();
            this.comboBoxOffers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWashes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCustHistory = new System.Windows.Forms.DataGridView();
            this.buttonNewCust = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSaveCust = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDeleteCust = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxClock = new System.Windows.Forms.PictureBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustHistory)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxBarcode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAbbreviation);
            this.groupBox1.Controls.Add(this.labelBarCode);
            this.groupBox1.Controls.Add(this.textBoxBarCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1032, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.Location = new System.Drawing.Point(17, 15);
            this.pictureBoxBarcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(97, 73);
            this.pictureBoxBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBarcode.TabIndex = 17;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(56, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "Συντομογραφία:";
            // 
            // textBoxAbbreviation
            // 
            this.textBoxAbbreviation.Enabled = false;
            this.textBoxAbbreviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxAbbreviation.Location = new System.Drawing.Point(508, 91);
            this.textBoxAbbreviation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAbbreviation.Name = "textBoxAbbreviation";
            this.textBoxAbbreviation.Size = new System.Drawing.Size(505, 75);
            this.textBoxAbbreviation.TabIndex = 2;
            this.textBoxAbbreviation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxAbbreviation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAbbreviation_KeyPress);
            // 
            // labelBarCode
            // 
            this.labelBarCode.AutoSize = true;
            this.labelBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelBarCode.Location = new System.Drawing.Point(121, 22);
            this.labelBarCode.Name = "labelBarCode";
            this.labelBarCode.Size = new System.Drawing.Size(381, 65);
            this.labelBarCode.TabIndex = 1;
            this.labelBarCode.Text = "Κωδ. Κάρτας:";
            // 
            // textBoxBarCode
            // 
            this.textBoxBarCode.Enabled = false;
            this.textBoxBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxBarCode.Location = new System.Drawing.Point(508, 10);
            this.textBoxBarCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBarCode.Name = "textBoxBarCode";
            this.textBoxBarCode.Size = new System.Drawing.Size(506, 75);
            this.textBoxBarCode.TabIndex = 0;
            this.textBoxBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxDateRegistered);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxCost);
            this.groupBox2.Controls.Add(this.comboBoxLicensePlates);
            this.groupBox2.Controls.Add(this.pictureBoxCost);
            this.groupBox2.Controls.Add(this.pictureBoxCustomer);
            this.groupBox2.Controls.Add(this.comboBoxOffers);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxWashes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxCustomerName);
            this.groupBox2.Location = new System.Drawing.Point(12, 302);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1031, 443);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Στοιχεία Πελάτη";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(13, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(362, 51);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ημ/νία εγγραφής:";
            // 
            // textBoxDateRegistered
            // 
            this.textBoxDateRegistered.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxDateRegistered.Location = new System.Drawing.Point(493, 242);
            this.textBoxDateRegistered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDateRegistered.Name = "textBoxDateRegistered";
            this.textBoxDateRegistered.ReadOnly = true;
            this.textBoxDateRegistered.Size = new System.Drawing.Size(520, 37);
            this.textBoxDateRegistered.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(13, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 51);
            this.label6.TabIndex = 22;
            this.label6.Text = "Κόστος:";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Enabled = false;
            this.textBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxCost.Location = new System.Drawing.Point(793, 367);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(220, 56);
            this.textBoxCost.TabIndex = 21;
            this.textBoxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxLicensePlates
            // 
            this.comboBoxLicensePlates.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBoxLicensePlates.FormattingEnabled = true;
            this.comboBoxLicensePlates.Location = new System.Drawing.Point(493, 97);
            this.comboBoxLicensePlates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLicensePlates.Name = "comboBoxLicensePlates";
            this.comboBoxLicensePlates.Size = new System.Drawing.Size(520, 59);
            this.comboBoxLicensePlates.Sorted = true;
            this.comboBoxLicensePlates.TabIndex = 20;
            this.comboBoxLicensePlates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxLicensePlates_KeyPress);
            // 
            // pictureBoxCost
            // 
            this.pictureBoxCost.Location = new System.Drawing.Point(689, 360);
            this.pictureBoxCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxCost.Name = "pictureBoxCost";
            this.pictureBoxCost.Size = new System.Drawing.Size(97, 68);
            this.pictureBoxCost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCost.TabIndex = 19;
            this.pictureBoxCost.TabStop = false;
            // 
            // pictureBoxCustomer
            // 
            this.pictureBoxCustomer.Location = new System.Drawing.Point(17, 25);
            this.pictureBoxCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxCustomer.Name = "pictureBoxCustomer";
            this.pictureBoxCustomer.Size = new System.Drawing.Size(97, 73);
            this.pictureBoxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCustomer.TabIndex = 18;
            this.pictureBoxCustomer.TabStop = false;
            // 
            // comboBoxOffers
            // 
            this.comboBoxOffers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxOffers.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBoxOffers.FormattingEnabled = true;
            this.comboBoxOffers.Location = new System.Drawing.Point(493, 166);
            this.comboBoxOffers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxOffers.Name = "comboBoxOffers";
            this.comboBoxOffers.Size = new System.Drawing.Size(520, 59);
            this.comboBoxOffers.TabIndex = 10;
            this.comboBoxOffers.SelectedIndexChanged += new System.EventHandler(this.comboBoxOffers_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(13, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(496, 51);
            this.label5.TabIndex = 9;
            this.label5.Text = "Πλύσεις που απομένουν:";
            // 
            // textBoxWashes
            // 
            this.textBoxWashes.Enabled = false;
            this.textBoxWashes.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxWashes.Location = new System.Drawing.Point(793, 297);
            this.textBoxWashes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWashes.Name = "textBoxWashes";
            this.textBoxWashes.ReadOnly = true;
            this.textBoxWashes.Size = new System.Drawing.Size(220, 56);
            this.textBoxWashes.TabIndex = 8;
            this.textBoxWashes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 51);
            this.label4.TabIndex = 7;
            this.label4.Text = "Πακέτο πλύσεων:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Οχήματα:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxCustomerName.Location = new System.Drawing.Point(131, 34);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.ReadOnly = true;
            this.textBoxCustomerName.Size = new System.Drawing.Size(881, 56);
            this.textBoxCustomerName.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewCustHistory);
            this.groupBox3.Location = new System.Drawing.Point(11, 842);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1031, 238);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Επισκέψεις Πελάτη";
            // 
            // dataGridViewCustHistory
            // 
            this.dataGridViewCustHistory.AllowUserToAddRows = false;
            this.dataGridViewCustHistory.AllowUserToDeleteRows = false;
            this.dataGridViewCustHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustHistory.Location = new System.Drawing.Point(17, 26);
            this.dataGridViewCustHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCustHistory.Name = "dataGridViewCustHistory";
            this.dataGridViewCustHistory.ReadOnly = true;
            this.dataGridViewCustHistory.RowTemplate.Height = 24;
            this.dataGridViewCustHistory.Size = new System.Drawing.Size(997, 199);
            this.dataGridViewCustHistory.TabIndex = 0;
            // 
            // buttonNewCust
            // 
            this.buttonNewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonNewCust.Location = new System.Drawing.Point(15, 21);
            this.buttonNewCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNewCust.Name = "buttonNewCust";
            this.buttonNewCust.Size = new System.Drawing.Size(168, 54);
            this.buttonNewCust.TabIndex = 11;
            this.buttonNewCust.Text = "ΝΕΟΣ ΠΕΛΑΤΗΣ";
            this.buttonNewCust.UseVisualStyleBackColor = true;
            this.buttonNewCust.Click += new System.EventHandler(this.buttonNewCust_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSaveCust);
            this.groupBox4.Controls.Add(this.buttonExit);
            this.groupBox4.Controls.Add(this.buttonDeleteCust);
            this.groupBox4.Controls.Add(this.buttonNewCust);
            this.groupBox4.Location = new System.Drawing.Point(12, 750);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1027, 87);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Λειτουργίες";
            // 
            // buttonSaveCust
            // 
            this.buttonSaveCust.Enabled = false;
            this.buttonSaveCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonSaveCust.Location = new System.Drawing.Point(211, 21);
            this.buttonSaveCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveCust.Name = "buttonSaveCust";
            this.buttonSaveCust.Size = new System.Drawing.Size(168, 54);
            this.buttonSaveCust.TabIndex = 14;
            this.buttonSaveCust.Text = "ΑΠΟΘΗΚΕΥΣΗ";
            this.buttonSaveCust.UseVisualStyleBackColor = true;
            this.buttonSaveCust.Click += new System.EventHandler(this.buttonSaveCust_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonExit.Location = new System.Drawing.Point(844, 21);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(168, 54);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "ΕΞΟΔΟΣ";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDeleteCust
            // 
            this.buttonDeleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonDeleteCust.Location = new System.Drawing.Point(411, 21);
            this.buttonDeleteCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteCust.Name = "buttonDeleteCust";
            this.buttonDeleteCust.Size = new System.Drawing.Size(168, 54);
            this.buttonDeleteCust.TabIndex = 12;
            this.buttonDeleteCust.Text = "ΔΙΑΓΡΑΦΗ ΠΕΛΑΤΗ";
            this.buttonDeleteCust.UseVisualStyleBackColor = true;
            this.buttonDeleteCust.Click += new System.EventHandler(this.buttonDeleteCust_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxClock);
            this.groupBox5.Controls.Add(this.labelDateTime);
            this.groupBox5.Location = new System.Drawing.Point(12, 14);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(1029, 116);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ημερομηνία";
            // 
            // pictureBoxClock
            // 
            this.pictureBoxClock.Location = new System.Drawing.Point(17, 25);
            this.pictureBoxClock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxClock.Name = "pictureBoxClock";
            this.pictureBoxClock.Size = new System.Drawing.Size(97, 81);
            this.pictureBoxClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClock.TabIndex = 16;
            this.pictureBoxClock.TabStop = false;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelDateTime.Location = new System.Drawing.Point(143, 39);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(0, 51);
            this.labelDateTime.TabIndex = 15;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 1088);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AquaLine - Προπληρωμένες Κάρτες Πλύσεων";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustHistory)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxBarCode;
        private System.Windows.Forms.Label labelBarCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAbbreviation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewCustHistory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWashes;
        private System.Windows.Forms.ComboBox comboBoxOffers;
        private System.Windows.Forms.Button buttonNewCust;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonDeleteCust;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxClock;
        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.PictureBox pictureBoxCustomer;
        private System.Windows.Forms.PictureBox pictureBoxCost;
        private System.Windows.Forms.Button buttonSaveCust;
        private System.Windows.Forms.ComboBox comboBoxLicensePlates;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDateRegistered;
        private System.Windows.Forms.Timer timer;

    }
}

