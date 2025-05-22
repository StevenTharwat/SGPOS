namespace SGPOS
{
    partial class EditInv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInv));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCustomer = new Syncfusion.WinForms.ListView.SfComboBox();
            this.txtNoteB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoteA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labCustomerType = new System.Windows.Forms.Label();
            this.txtInvCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudTotoalDiscPre = new System.Windows.Forms.NumericUpDown();
            this.btnInvEdit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.labQty = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.labPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labPriceAfterDisc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labPriceBeforeDisc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemsGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotoalDiscPre)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbCustomer);
            this.groupBox1.Controls.Add(this.txtNoteB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNoteA);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labCustomerType);
            this.groupBox1.Controls.Add(this.txtInvCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(776, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbCustomer
            // 
            this.cbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCustomer.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cbCustomer.Location = new System.Drawing.Point(464, 62);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCustomer.Size = new System.Drawing.Size(229, 23);
            this.cbCustomer.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCustomer.TabIndex = 2;
            // 
            // txtNoteB
            // 
            this.txtNoteB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoteB.Location = new System.Drawing.Point(464, 138);
            this.txtNoteB.Name = "txtNoteB";
            this.txtNoteB.Size = new System.Drawing.Size(229, 23);
            this.txtNoteB.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(712, 137);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "ملاحظة 2 :";
            // 
            // txtNoteA
            // 
            this.txtNoteA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoteA.Location = new System.Drawing.Point(464, 101);
            this.txtNoteA.Name = "txtNoteA";
            this.txtNoteA.Size = new System.Drawing.Size(229, 23);
            this.txtNoteA.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(712, 100);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "ملاحظة 1 :";
            // 
            // labCustomerType
            // 
            this.labCustomerType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labCustomerType.AutoSize = true;
            this.labCustomerType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labCustomerType.Location = new System.Drawing.Point(725, 59);
            this.labCustomerType.Name = "labCustomerType";
            this.labCustomerType.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labCustomerType.Size = new System.Drawing.Size(46, 21);
            this.labCustomerType.TabIndex = 11;
            this.labCustomerType.Text = "العميل :";
            // 
            // txtInvCode
            // 
            this.txtInvCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvCode.Location = new System.Drawing.Point(464, 26);
            this.txtInvCode.Name = "txtInvCode";
            this.txtInvCode.Size = new System.Drawing.Size(229, 23);
            this.txtInvCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(701, 25);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "كود الفاتوره :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.nudTotoalDiscPre);
            this.groupBox3.Controls.Add(this.btnInvEdit);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 177);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تعديلات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 19);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "خصم اجمالي % : ";
            // 
            // nudTotoalDiscPre
            // 
            this.nudTotoalDiscPre.DecimalPlaces = 2;
            this.nudTotoalDiscPre.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudTotoalDiscPre.Location = new System.Drawing.Point(9, 48);
            this.nudTotoalDiscPre.Name = "nudTotoalDiscPre";
            this.nudTotoalDiscPre.Size = new System.Drawing.Size(85, 23);
            this.nudTotoalDiscPre.TabIndex = 9;
            this.nudTotoalDiscPre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudTotoalDiscPre_KeyPress);
            // 
            // btnInvEdit
            // 
            this.btnInvEdit.Location = new System.Drawing.Point(6, 148);
            this.btnInvEdit.Name = "btnInvEdit";
            this.btnInvEdit.Size = new System.Drawing.Size(108, 23);
            this.btnInvEdit.TabIndex = 10;
            this.btnInvEdit.Text = "تطبيق";
            this.btnInvEdit.UseVisualStyleBackColor = true;
            this.btnInvEdit.Click += new System.EventHandler(this.btnInvEdit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 626);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.cbItems);
            this.flowLayoutPanel1.Controls.Add(this.labQty);
            this.flowLayoutPanel1.Controls.Add(this.nudQty);
            this.flowLayoutPanel1.Controls.Add(this.labPrice);
            this.flowLayoutPanel1.Controls.Add(this.nudPrice);
            this.flowLayoutPanel1.Controls.Add(this.btnAddItem);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 207);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 29);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "الصنف";
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbItems.Location = new System.Drawing.Point(604, 3);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(121, 23);
            this.cbItems.TabIndex = 5;
            this.cbItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbItems_KeyPress);
            // 
            // labQty
            // 
            this.labQty.AutoSize = true;
            this.labQty.Location = new System.Drawing.Point(561, 0);
            this.labQty.Name = "labQty";
            this.labQty.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labQty.Size = new System.Drawing.Size(37, 21);
            this.labQty.TabIndex = 3;
            this.labQty.Text = "الكمية";
            this.labQty.Visible = false;
            // 
            // nudQty
            // 
            this.nudQty.DecimalPlaces = 2;
            this.nudQty.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudQty.Location = new System.Drawing.Point(435, 3);
            this.nudQty.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(120, 23);
            this.nudQty.TabIndex = 6;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Visible = false;
            this.nudQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudQty_KeyPress);
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(393, 0);
            this.labPrice.Name = "labPrice";
            this.labPrice.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labPrice.Size = new System.Drawing.Size(36, 21);
            this.labPrice.TabIndex = 5;
            this.labPrice.Text = "السعر";
            this.labPrice.Visible = false;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrice.Location = new System.Drawing.Point(267, 3);
            this.nudPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 23);
            this.nudPrice.TabIndex = 7;
            this.nudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrice.Visible = false;
            this.nudPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudPrice_KeyPress);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(186, 3);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 8;
            this.btnAddItem.Text = "اضف";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Visible = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.btnOk);
            this.flowLayoutPanel2.Controls.Add(this.btnDelete);
            this.flowLayoutPanel2.Controls.Add(this.btnCancel);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 579);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(776, 44);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Location = new System.Drawing.Point(676, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 36);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "اضافة";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(573, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 36);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "مسح";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(470, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 36);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "رجوع";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.labPriceAfterDisc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labPriceBeforeDisc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(130, 335);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // labPriceAfterDisc
            // 
            this.labPriceAfterDisc.AutoSize = true;
            this.labPriceAfterDisc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labPriceAfterDisc.Location = new System.Drawing.Point(6, 110);
            this.labPriceAfterDisc.Name = "labPriceAfterDisc";
            this.labPriceAfterDisc.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labPriceAfterDisc.Size = new System.Drawing.Size(77, 38);
            this.labPriceAfterDisc.TabIndex = 4;
            this.labPriceAfterDisc.Text = "10.50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 89);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "الاجمالي بعد الخصم : ";
            // 
            // labPriceBeforeDisc
            // 
            this.labPriceBeforeDisc.AutoSize = true;
            this.labPriceBeforeDisc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labPriceBeforeDisc.Location = new System.Drawing.Point(6, 40);
            this.labPriceBeforeDisc.Name = "labPriceBeforeDisc";
            this.labPriceBeforeDisc.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labPriceBeforeDisc.Size = new System.Drawing.Size(77, 38);
            this.labPriceBeforeDisc.TabIndex = 2;
            this.labPriceBeforeDisc.Text = "11.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاجمالي قبل الخصم : ";
            // 
            // itemsGrid
            // 
            this.itemsGrid.AccessibleName = "Table";
            this.itemsGrid.AllowDraggingColumns = true;
            this.itemsGrid.AllowFiltering = true;
            this.itemsGrid.AllowResizingColumns = true;
            this.itemsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.itemsGrid.GroupCaptionTextFormat = "";
            this.itemsGrid.Location = new System.Drawing.Point(148, 245);
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemsGrid.ShowGroupDropArea = true;
            this.itemsGrid.ShowRowHeader = true;
            this.itemsGrid.Size = new System.Drawing.Size(640, 328);
            this.itemsGrid.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.itemsGrid.Style.CheckBoxStyle.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.itemsGrid.Style.CheckBoxStyle.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.itemsGrid.Style.CheckBoxStyle.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.itemsGrid.Style.HyperlinkStyle.DefaultLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.itemsGrid.TabIndex = 5;
            this.itemsGrid.Text = "itemsGrid";
            this.itemsGrid.CurrentCellEndEdit += new Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventHandler(this.itemsGrid_CurrentCellEndEdit);
            this.itemsGrid.CurrentCellKeyPress += new Syncfusion.WinForms.DataGrid.Events.CurrentCellKeyPressEventHandler(this.itemsGrid_CurrentCellKeyPress);
            // 
            // EditInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.itemsGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditInv";
            this.Text = "EditInv";
            this.Load += new System.EventHandler(this.EditInv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotoalDiscPre)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private StatusStrip statusStrip1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private ComboBox cbItems;
        private Label labQty;
        private NumericUpDown nudQty;
        private Label labPrice;
        private NumericUpDown nudPrice;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnOk;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnAddItem;
        private GroupBox groupBox2;
        private Label labPriceBeforeDisc;
        private Label label2;
        private Label labPriceAfterDisc;
        private Label label5;
        private Syncfusion.WinForms.DataGrid.SfDataGrid itemsGrid;
        private GroupBox groupBox3;
        private Label label3;
        private NumericUpDown nudTotoalDiscPre;
        private Button btnInvEdit;
        private Syncfusion.WinForms.ListView.SfComboBox cbCustomer;
        private TextBox txtNoteB;
        private Label label7;
        private TextBox txtNoteA;
        private Label label8;
        private Label labCustomerType;
        private TextBox txtInvCode;
        private Label label4;
    }
}