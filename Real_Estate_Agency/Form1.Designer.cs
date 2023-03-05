namespace Real_Estate_Agency
{
    partial class F
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stringAddress = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.floatSqFtTotal = new System.Windows.Forms.TextBox();
            this.floatPrice = new System.Windows.Forms.TextBox();
            this.byteQuality = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.squareFtLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.averageLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listBox = new System.Windows.Forms.ListBox();
            this.houseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // stringAddress
            // 
            this.stringAddress.Location = new System.Drawing.Point(54, 54);
            this.stringAddress.Name = "stringAddress";
            this.stringAddress.Size = new System.Drawing.Size(125, 27);
            this.stringAddress.TabIndex = 0;
            this.stringAddress.TextChanged += new System.EventHandler(this.stringAddress_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(296, 214);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 29);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Visible = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // floatSqFtTotal
            // 
            this.floatSqFtTotal.Location = new System.Drawing.Point(208, 54);
            this.floatSqFtTotal.Name = "floatSqFtTotal";
            this.floatSqFtTotal.Size = new System.Drawing.Size(125, 27);
            this.floatSqFtTotal.TabIndex = 2;
            this.floatSqFtTotal.TextChanged += new System.EventHandler(this.floatSqFtTotal_TextChanged);
            // 
            // floatPrice
            // 
            this.floatPrice.Location = new System.Drawing.Point(353, 54);
            this.floatPrice.Name = "floatPrice";
            this.floatPrice.Size = new System.Drawing.Size(125, 27);
            this.floatPrice.TabIndex = 3;
            this.floatPrice.TextChanged += new System.EventHandler(this.floatPrice_TextChanged);
            // 
            // byteQuality
            // 
            this.byteQuality.Location = new System.Drawing.Point(495, 54);
            this.byteQuality.Name = "byteQuality";
            this.byteQuality.Size = new System.Drawing.Size(125, 27);
            this.byteQuality.TabIndex = 4;
            this.byteQuality.TextChanged += new System.EventHandler(this.byteQuality_TextChanged);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(54, 31);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 20);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Address";
            // 
            // squareFtLabel
            // 
            this.squareFtLabel.AutoSize = true;
            this.squareFtLabel.Location = new System.Drawing.Point(208, 31);
            this.squareFtLabel.Name = "squareFtLabel";
            this.squareFtLabel.Size = new System.Drawing.Size(160, 20);
            this.squareFtLabel.TabIndex = 6;
            this.squareFtLabel.Text = "Square Ft Total             ";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(353, 31);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(41, 20);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Price";
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Location = new System.Drawing.Point(495, 31);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(56, 20);
            this.qualityLabel.TabIndex = 8;
            this.qualityLabel.Text = "Quality";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(296, 179);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 29);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(628, 216);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.Size = new System.Drawing.Size(125, 27);
            this.averageTextBox.TabIndex = 10;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(598, 179);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(167, 20);
            this.averageLabel.TabIndex = 11;
            this.averageLabel.Text = "Average Price Per Sq. Ft.";
            this.averageLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(312, 140);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 20);
            this.warningLabel.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(54, 314);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(725, 124);
            this.listBox.TabIndex = 13;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // houseLabel
            // 
            this.houseLabel.AutoSize = true;
            this.houseLabel.Location = new System.Drawing.Point(396, 274);
            this.houseLabel.Name = "houseLabel";
            this.houseLabel.Size = new System.Drawing.Size(57, 20);
            this.houseLabel.TabIndex = 14;
            this.houseLabel.Text = "Houses";
            // 
            // F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.houseLabel);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.qualityLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.squareFtLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.byteQuality);
            this.Controls.Add(this.floatPrice);
            this.Controls.Add(this.floatSqFtTotal);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.stringAddress);
            this.Name = "F";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox stringAddress;
        private Button submitButton;
        private TextBox floatSqFtTotal;
        private TextBox floatPrice;
        private TextBox byteQuality;
        private Label addressLabel;
        private Label squareFtLabel;
        private Label priceLabel;
        private Label qualityLabel;
        private Button startButton;
        private TextBox averageTextBox;
        private Label averageLabel;
        private Label warningLabel;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ListBox listBox;
        private Label houseLabel;
    }
}