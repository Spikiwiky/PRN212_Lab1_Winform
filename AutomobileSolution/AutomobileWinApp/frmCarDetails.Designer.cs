namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            lbCarId = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarId = new TextBox();
            txtCarName = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            cboManufacturer = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // lbCarId
            // 
            lbCarId.AutoSize = true;
            lbCarId.Location = new Point(136, 85);
            lbCarId.Name = "lbCarId";
            lbCarId.Size = new Size(39, 15);
            lbCarId.TabIndex = 0;
            lbCarId.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(136, 124);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(136, 166);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(136, 204);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(136, 252);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(71, 15);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(267, 82);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(168, 23);
            txtCarId.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(267, 121);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(168, 23);
            txtCarName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(267, 204);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(168, 23);
            txtPrice.TabIndex = 7;
            txtPrice.Text = "0";
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(267, 249);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(168, 23);
            txtReleaseYear.TabIndex = 8;
            txtReleaseYear.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(267, 163);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(168, 23);
            cboManufacturer.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(267, 309);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(360, 309);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(501, 234);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(8, 23);
            maskedTextBox1.TabIndex = 12;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 391);
            Controls.Add(maskedTextBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtCarId);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarId);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarId;
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarId;
        private TextBox txtCarName;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private ComboBox cboManufacturer;
        private Button btnSave;
        private Button btnCancel;
        private MaskedTextBox maskedTextBox1;
    }
}