namespace Paquibulan_Week05_04
{
    partial class ProductForm
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
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gboxManufactured = new System.Windows.Forms.GroupBox();
            this.rbtnAbroad = new System.Windows.Forms.RadioButton();
            this.rbtnLocal = new System.Windows.Forms.RadioButton();
            this.checkboxActive = new System.Windows.Forms.CheckBox();
            this.txtboxMarkup = new System.Windows.Forms.TextBox();
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.txtboxDescription = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtboxBarcode = new System.Windows.Forms.TextBox();
            this.lblMarkup = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.gboxManufactured.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxCategory
            // 
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Items.AddRange(new object[] {
            "Furniture",
            "Electrical"});
            this.cboxCategory.Location = new System.Drawing.Point(198, 192);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(121, 21);
            this.cboxCategory.TabIndex = 48;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Location = new System.Drawing.Point(592, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(235, 257);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.Location = new System.Drawing.Point(135, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gboxManufactured
            // 
            this.gboxManufactured.Controls.Add(this.rbtnAbroad);
            this.gboxManufactured.Controls.Add(this.rbtnLocal);
            this.gboxManufactured.Location = new System.Drawing.Point(469, 56);
            this.gboxManufactured.Name = "gboxManufactured";
            this.gboxManufactured.Size = new System.Drawing.Size(198, 47);
            this.gboxManufactured.TabIndex = 44;
            this.gboxManufactured.TabStop = false;
            this.gboxManufactured.Text = "Manufactured";
            // 
            // rbtnAbroad
            // 
            this.rbtnAbroad.AutoSize = true;
            this.rbtnAbroad.Location = new System.Drawing.Point(99, 19);
            this.rbtnAbroad.Name = "rbtnAbroad";
            this.rbtnAbroad.Size = new System.Drawing.Size(59, 17);
            this.rbtnAbroad.TabIndex = 19;
            this.rbtnAbroad.TabStop = true;
            this.rbtnAbroad.Text = "Abroad";
            this.rbtnAbroad.UseVisualStyleBackColor = true;
            // 
            // rbtnLocal
            // 
            this.rbtnLocal.AutoSize = true;
            this.rbtnLocal.Location = new System.Drawing.Point(4, 19);
            this.rbtnLocal.Name = "rbtnLocal";
            this.rbtnLocal.Size = new System.Drawing.Size(51, 17);
            this.rbtnLocal.TabIndex = 18;
            this.rbtnLocal.TabStop = true;
            this.rbtnLocal.Text = "Local";
            this.rbtnLocal.UseVisualStyleBackColor = true;
            // 
            // checkboxActive
            // 
            this.checkboxActive.AutoSize = true;
            this.checkboxActive.Location = new System.Drawing.Point(473, 125);
            this.checkboxActive.Name = "checkboxActive";
            this.checkboxActive.Size = new System.Drawing.Size(56, 17);
            this.checkboxActive.TabIndex = 43;
            this.checkboxActive.Text = "Active";
            this.checkboxActive.UseVisualStyleBackColor = true;
            // 
            // txtboxMarkup
            // 
            this.txtboxMarkup.Location = new System.Drawing.Point(573, 193);
            this.txtboxMarkup.Name = "txtboxMarkup";
            this.txtboxMarkup.Size = new System.Drawing.Size(68, 20);
            this.txtboxMarkup.TabIndex = 42;
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Location = new System.Drawing.Point(490, 193);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(68, 20);
            this.txtboxPrice.TabIndex = 41;
            // 
            // txtboxCost
            // 
            this.txtboxCost.Location = new System.Drawing.Point(406, 193);
            this.txtboxCost.Name = "txtboxCost";
            this.txtboxCost.Size = new System.Drawing.Size(68, 20);
            this.txtboxCost.TabIndex = 40;
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.Location = new System.Drawing.Point(198, 126);
            this.txtboxDescription.Multiline = true;
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(121, 50);
            this.txtboxDescription.TabIndex = 39;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(198, 90);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(121, 20);
            this.txtboxName.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 37;
            // 
            // txtboxBarcode
            // 
            this.txtboxBarcode.Location = new System.Drawing.Point(198, 56);
            this.txtboxBarcode.Name = "txtboxBarcode";
            this.txtboxBarcode.Size = new System.Drawing.Size(121, 20);
            this.txtboxBarcode.TabIndex = 36;
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Location = new System.Drawing.Point(570, 177);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(57, 13);
            this.lblMarkup.TabIndex = 35;
            this.lblMarkup.Text = "Markup(%)";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(487, 177);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 34;
            this.lblPrice.Text = "Price";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(409, 177);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 33;
            this.lblCost.Text = "Cost";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(404, 129);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 32;
            this.lblStatus.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 31;
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(409, 59);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(34, 13);
            this.lblOrigin.TabIndex = 30;
            this.lblOrigin.Text = "Origin";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(132, 195);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 29;
            this.lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(132, 129);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 28;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(132, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Name";
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(132, 59);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(47, 13);
            this.lblBarcode.TabIndex = 26;
            this.lblBarcode.Text = "Barcode";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxCategory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gboxManufactured);
            this.Controls.Add(this.checkboxActive);
            this.Controls.Add(this.txtboxMarkup);
            this.Controls.Add(this.txtboxPrice);
            this.Controls.Add(this.txtboxCost);
            this.Controls.Add(this.txtboxDescription);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtboxBarcode);
            this.Controls.Add(this.lblMarkup);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBarcode);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.gboxManufactured.ResumeLayout(false);
            this.gboxManufactured.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gboxManufactured;
        private System.Windows.Forms.RadioButton rbtnAbroad;
        private System.Windows.Forms.RadioButton rbtnLocal;
        private System.Windows.Forms.CheckBox checkboxActive;
        private System.Windows.Forms.TextBox txtboxMarkup;
        private System.Windows.Forms.TextBox txtboxPrice;
        private System.Windows.Forms.TextBox txtboxCost;
        private System.Windows.Forms.TextBox txtboxDescription;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtboxBarcode;
        private System.Windows.Forms.Label lblMarkup;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBarcode;
    }
}