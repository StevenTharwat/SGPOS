namespace SGPOS
{
    partial class EditItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItems));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.GB_main = new System.Windows.Forms.GroupBox();
            this.cbSellerCode = new System.Windows.Forms.ComboBox();
            this.npSellPrice = new System.Windows.Forms.NumericUpDown();
            this.npBuyPrice = new System.Windows.Forms.NumericUpDown();
            this.txtNoteB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoteA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.GB_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npSellPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npBuyPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(219, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(106, 33);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "ادخال";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(106, 33);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "رجوع";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnOk);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(162, 407);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(328, 42);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(116, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 33);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "مسح";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GB_main
            // 
            this.GB_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_main.Controls.Add(this.cbSellerCode);
            this.GB_main.Controls.Add(this.npSellPrice);
            this.GB_main.Controls.Add(this.npBuyPrice);
            this.GB_main.Controls.Add(this.txtNoteB);
            this.GB_main.Controls.Add(this.label5);
            this.GB_main.Controls.Add(this.txtNoteA);
            this.GB_main.Controls.Add(this.label6);
            this.GB_main.Controls.Add(this.label7);
            this.GB_main.Controls.Add(this.txtCat);
            this.GB_main.Controls.Add(this.label8);
            this.GB_main.Controls.Add(this.label3);
            this.GB_main.Controls.Add(this.label4);
            this.GB_main.Controls.Add(this.txtName);
            this.GB_main.Controls.Add(this.label2);
            this.GB_main.Controls.Add(this.txtCode);
            this.GB_main.Controls.Add(this.label1);
            this.GB_main.Location = new System.Drawing.Point(12, 12);
            this.GB_main.Name = "GB_main";
            this.GB_main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GB_main.Size = new System.Drawing.Size(473, 389);
            this.GB_main.TabIndex = 24;
            this.GB_main.TabStop = false;
            this.GB_main.Text = "اضافة صنف";
            // 
            // cbSellerCode
            // 
            this.cbSellerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSellerCode.FormattingEnabled = true;
            this.cbSellerCode.Location = new System.Drawing.Point(23, 203);
            this.cbSellerCode.Name = "cbSellerCode";
            this.cbSellerCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSellerCode.Size = new System.Drawing.Size(359, 23);
            this.cbSellerCode.TabIndex = 4;
            // 
            // npSellPrice
            // 
            this.npSellPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.npSellPrice.DecimalPlaces = 2;
            this.npSellPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.npSellPrice.Location = new System.Drawing.Point(23, 157);
            this.npSellPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.npSellPrice.Name = "npSellPrice";
            this.npSellPrice.Size = new System.Drawing.Size(359, 23);
            this.npSellPrice.TabIndex = 3;
            this.npSellPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // npBuyPrice
            // 
            this.npBuyPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.npBuyPrice.DecimalPlaces = 2;
            this.npBuyPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.npBuyPrice.Location = new System.Drawing.Point(23, 115);
            this.npBuyPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.npBuyPrice.Name = "npBuyPrice";
            this.npBuyPrice.Size = new System.Drawing.Size(359, 23);
            this.npBuyPrice.TabIndex = 2;
            this.npBuyPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNoteB
            // 
            this.txtNoteB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoteB.Location = new System.Drawing.Point(23, 330);
            this.txtNoteB.Name = "txtNoteB";
            this.txtNoteB.Size = new System.Drawing.Size(359, 23);
            this.txtNoteB.TabIndex = 7;
            this.txtNoteB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoteB_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "ملاحظة 2 :";
            // 
            // txtNoteA
            // 
            this.txtNoteA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoteA.Location = new System.Drawing.Point(23, 288);
            this.txtNoteA.Name = "txtNoteA";
            this.txtNoteA.Size = new System.Drawing.Size(359, 23);
            this.txtNoteA.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "ملاحظة 1 :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "تصنيف :";
            // 
            // txtCat
            // 
            this.txtCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCat.Location = new System.Drawing.Point(23, 244);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(359, 23);
            this.txtCat.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "اسم المورد :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "سعر البيع :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "سعر الشراء :";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(23, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(359, 23);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "الاسم :";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(23, 33);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(359, 23);
            this.txtCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "الكود :";
            // 
            // EditItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 461);
            this.Controls.Add(this.GB_main);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(5000, 580);
            this.MinimumSize = new System.Drawing.Size(0, 500);
            this.Name = "EditItems";
            this.Text = "Edit Items";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.GB_main.ResumeLayout(false);
            this.GB_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npSellPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npBuyPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnOk;
        private Button btnCancel;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox GB_main;
        private TextBox txtNoteB;
        private Label label5;
        private TextBox txtNoteA;
        private Label label6;
        private Label label7;
        private TextBox txtCat;
        private Label label8;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private Label label2;
        private TextBox txtCode;
        private Label label1;
        private Button btnDelete;
        private NumericUpDown npSellPrice;
        private NumericUpDown npBuyPrice;
        private ComboBox cbSellerCode;
    }
}