using System.Data;
using System.Text;
using utilities;

namespace SGPOS
{
    public partial class EditInv : Form
    {
        public int mainId; // -1 => new , 0 => edit
        public string type; // 0 => buy , 1 => sell
        double totalbefore = 0;
        double discAmount = 0;
        double TotaldiscAmount = 0;
        double TotalRowsdiscPre = 0;
        string invCode, customerCode, NoteA, noteB = string.Empty;

        Dictionary<string, string> ItemsDic = new Dictionary<string, string>();
        Dictionary<string, string> CustomerDic = new Dictionary<string, string>();
        Dictionary<string, string> GridHeaders = new Dictionary<string, string>
        {
            { "id" , "الرقم التسلسلي" },
            { "itemCode" , "الكود" },
            { "itemName" , "اسم الصنف" },
            { "qty" , "الكميه" },
            { "price" , "السعر" },
            { "itemDisPre" , "خصم للقطعة %" },
            { "rowDisPre" , "خصم للصف %" }
        };
        public List<items> itemsList = new List<items>();

        public EditInv()
        {
            InitializeComponent();
        }
        public void init(int _operation, string _type)
        {
            try
            {

                mainId = _operation;
                type = _type;

                CustomerDic = POSData.getCustomerDic();
                ItemsDic = POSData.getItemsDic();
                cbItems.DataSource = ItemsDic.getKeys();
                cbCustomer.DataSource = CustomerDic.getKeys();

                if (mainId == -1)
                {
                    this.btnDelete.Visible = false;
                }
                else
                {
                    setFields(mainId);
                }

                staticItemClass.idI = 0;
                this.ActiveControl = cbItems;
                cbItems.Select(0, 1000);
                cbItems.Text = String.Empty;

                if (type == "b")
                {
                    this.labCustomerType.Text = "المورد :";
                    if (mainId == -1)
                    {
                        this.Text = "فاتورة شراء";
                        this.btnOk.Text = "ادخال";
                    }
                    else
                    {
                        this.Text = "تعديل فاتورة شراء";
                        this.btnOk.Text = "موافق";
                    }
                }
                else if (type == "s")
                {
                    this.labCustomerType.Text = "العميل :";
                    if (mainId == -1)
                    {
                        this.Text = "فاتورة بيع";
                        this.btnOk.Text = "ادخال";
                    }
                    else
                    {
                        this.Text = "تعديل فاتورة بيع";
                        this.btnOk.Text = "موافق";
                    }
                }
                else if (type == "rb")
                {
                    this.labCustomerType.Text = "المورد";
                    if (mainId == -1)
                    {
                        this.Text = "فاتورة مرتجع";
                        this.btnOk.Text = "ادخال";
                    }
                    else
                    {
                        this.Text = "تعديل فاتورة مرتجع";
                        this.btnOk.Text = "موافق";
                    }
                }
                else if (type == "rs")
                {
                    this.labCustomerType.Text = "العميل :";
                    if (mainId == -1)
                    {
                        this.Text = "فاتورة مرتجع";
                        this.btnOk.Text = "ادخال";
                    }
                    else
                    {
                        this.Text = "تعديل فاتورة مرتجع";
                        this.btnOk.Text = "موافق";
                    }
                }
                refresh();
                Form_Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_Show()
        {
            this.WindowState = FormWindowState.Maximized;
            this.ShowDialog();
        }

        private void cbItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (Convert.ToInt32(e.KeyChar) == 13)
                {

                    if (cbItems.Items.Contains(cbItems.Text))
                    {
                        labQty.Visible = true;
                        nudQty.Visible = true;
                        labPrice.Visible = true;
                        nudPrice.Visible = true;
                        btnAddItem.Visible = true;
                        nudQty.Focus();
                        nudQty.Select(0, 1000);
                    }
                    else
                    {
                        cbItems.Text = "";
                        cbItems.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditInv_Load(object sender, EventArgs e)
        {

        }

        private void nudQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (Convert.ToInt32(e.KeyChar) == 13)
                {

                    if (true) // condition nudQty.Value % 1 == 0
                    {
                        nudPrice.Focus();
                        nudPrice.Select(0, 1000);
                    }
                    else
                    {
                        nudQty.Value = 1;
                        nudQty.Focus();
                        nudQty.Select(0, 1000);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {

                bool isVaildationErrorsFound;
                getFields();
                if (mainId == -1) isVaildationErrorsFound = anyValidationError(false);
                else isVaildationErrorsFound = anyValidationError(true);
                //validations
                if (isVaildationErrorsFound)
                {
                    return;
                }
                //send it to the database (add or ( update => [delete + add] ) )
                Dictionary<string, string> map = new Dictionary<string, string>();
                map["id"] = mainId.ToString();
                map["invCode"] = invCode;
                map["customerCode"] = customerCode;
                map["NoteA"] = NoteA;
                map["NoteB"] = noteB;
                map["nudTotoalDiscPre"] = ( TotalRowsdiscPre + (double) nudTotoalDiscPre.Value ).ToString();
                map["dis_global_pre"] = ( (double) nudTotoalDiscPre.Value ).ToString();
                map["type"] = type;
                map["labCustomerType"] = labCustomerType.Text;
                map["dis_pre"] = ( totalbefore - discAmount - TotaldiscAmount ).ToString();
                map["dis_amount"] = ( discAmount + TotaldiscAmount ).ToString();
                map["totalbeforeDisc"] = totalbefore.ToString();

                if (mainId == -1)
                    POSData.insertNewInvoice(map, itemsList);
                else
                    POSData.updateInvoice(map, itemsList);


                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool anyValidationError(bool update)
        {
            StringBuilder errrors = new StringBuilder();

            bool complete = isComplete();
            bool uniqe = POSData.isInvCodeUniqe(invCode, errrors);

            if (complete)
            {
                if (!update)
                {
                    if (uniqe) return false;
                    else
                    {
                        MessageBox.Show("من فضلك ادخل كود جديد");
                        return true;
                    }
                }
                else return false;
            }
            else
                return true;
        }

        private bool isComplete()
        {
            bool complete = true;
            if (invCode.isEmpty() || customerCode.isEmpty())
            {
                MessageBox.Show("من فضلك املاء كل الحقول المطلوبة");
                cbCustomer.Text = CustomerDic.ContainsKey(cbCustomer.Text) ? cbCustomer.Text : "";
                complete = false;
            }
            else if (itemsList.Count == 0)
            {
                MessageBox.Show("من فضلك ادخل اصناف للفاتورة");
                complete = false;
            }
            return complete;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {

                itemsList.Add(new items(cbItems.Text, (double) nudQty.Value, (double) nudPrice.Value));
                refresh();

                cbItems.Focus();
                cbItems.Select();
                cbItems.Text = "";
                nudPrice.Value = 1;
                nudQty.Value = 1;

                labQty.Visible = false;
                nudQty.Visible = false;
                labPrice.Visible = false;
                nudPrice.Visible = false;
                btnAddItem.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refresh()
        {
            totalbefore = 0;
            discAmount = 0;
            TotalRowsdiscPre = 0;
            foreach (items item in itemsList)
            {
                totalbefore += item.qty * item.price;
                discAmount += totalbefore * item.rowDisPre / 100;
                //discAmount += item.price * item.itemDisPre / 100;
                TotalRowsdiscPre += item.rowDisPre;
            }
            calcTotalDisc();
            labPriceBeforeDisc.Text = totalbefore.ToString();
            labPriceAfterDisc.Text = ( totalbefore - discAmount - TotaldiscAmount ).ToString();
            itemsGrid.DataSource = itemsList.ToArray();
            itemsGrid.AllowDraggingColumns = true;

            foreach (Syncfusion.WinForms.DataGrid.GridColumn col in itemsGrid.Columns)
            {
                //if (col.HeaderText == "disPre") col.Format = "{col.HeaderText}%";
                if (col.HeaderText.Contains(col.HeaderText)) col.HeaderText = GridHeaders[col.HeaderText];
            }
            this.itemsGrid.Columns["itemDisPre"].Visible = false;
            itemsGrid.Refresh();
        }

        private void nudPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (Convert.ToInt32(e.KeyChar) == 13)
                {

                    if (true) // condition
                    {
                        btnAddItem.Focus();
                        btnAddItem.Select();
                    }
                    else
                    {
                        nudPrice.Focus();
                        nudPrice.Select(0, 1000);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemsGrid_CurrentCellEndEdit(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs e)
        {
            try
            {

                items editItem = (items) e.DataRow.RowData;
                int id = editItem.id;
                string editcolumName = e.DataColumn.GridColumn.HeaderText;
                foreach (var item in itemsList.Where(x => x.id == id))
                {
                    if (editcolumName == "rowDisPre") item.rowDisPre = editItem.rowDisPre;
                    //if(editcolumName == "itemDisPre") item.itemDisPre = editItem.itemDisPre;
                }
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemsGrid_CurrentCellKeyPress(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellKeyPressEventArgs e)
        {
            try
            {

                if (e.KeyPressEventArgs.KeyChar == (char) Keys.Escape)
                {
                    items selectedItem = (items) itemsGrid.SelectedItems.First();
                    itemsList.Remove(selectedItem);
                    refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInvEdit_Click(object sender, EventArgs e)
        {
            try
            {
                calcTotalDisc();
                labPriceAfterDisc.Text = ( totalbefore - discAmount - TotaldiscAmount ).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calcTotalDisc()
        {
            TotaldiscAmount = ( totalbefore - discAmount ) * Convert.ToDouble(nudTotoalDiscPre.Value) / 100;
        }

        private void nudTotoalDiscPre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (Convert.ToInt32(e.KeyChar) == 13)
                {

                    if (true) // condition
                    {
                        btnInvEdit.Focus();
                        btnInvEdit.Select();
                    }
                    else
                    {
                        nudTotoalDiscPre.Focus();
                        nudTotoalDiscPre.Select(0, 1000);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (mainId != -1) POSData.deleteInv(mainId, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void getFields()
        {
            invCode = txtInvCode.Text;
            customerCode = CustomerDic.ContainsKey(cbCustomer.Text) ? CustomerDic[cbCustomer.Text] : "";
            NoteA = txtNoteA.Text;
            noteB = txtNoteB.Text;
        }

        public void setFields(int id)
        {
            StringBuilder errors = new StringBuilder();
            Dictionary<DataRow, DataTable> Dic = POSData.getInvRowByIdDic(id, errors); //row ,table

            if (Dic == null)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            DataRow row = Dic.First().Key;
            itemsList = Dic.First().Value.convertItemsTable();
            txtInvCode.Text = row["code_str"].ToString();
            txtNoteA.Text = row["note_a"].ToString();
            txtNoteB.Text = row["note_b"].ToString();
            cbCustomer.Text = CustomerDic.FirstOrDefault(x => x.Value == row["customer_code"].ToString()).Key;
            nudTotoalDiscPre.Value = row["dis_global_pre"].ToString().isEmpty() ? 0 : Convert.ToDecimal(row["dis_global_pre"]);
            labCustomerType.Text = row["type"].ToString() == "s" ? "العميل :" : "المورد :";
            labPriceBeforeDisc.Text = row["total"].ToString();
            labPriceAfterDisc.Text = ( Convert.ToDouble(row["total"]) - Convert.ToDouble(row["dis_amount"]) ).ToString();
        }
    }
}
