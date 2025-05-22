using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utilities;

namespace SGPOS
{
    public partial class EditItems : Form
    {

        public int mainId ;
        public string code, name, sellerCode, cat, noteA, noteB = string.Empty;
        double buyprice, sellPrice;
        public Dictionary<string, string> customersDic = new Dictionary<string, string>();

        public EditItems()
        {
            InitializeComponent();
        }

        public void init(int _operation)
        {
            mainId = _operation;
            customersDic = POSData.getCustomerDic();
            cbSellerCode.DataSource = customersDic.getKeys();
            if (mainId == -1)
            {
                this.Text = "New Item";
                this.btnOk.Text = "ادخال";
                this.btnDelete.Visible = false;
            }
            else
            {
                this.Text = "Edit Item";
                this.btnOk.Text = "موافق";
                setFields(mainId);
            }

            Form_Show();
        }

        private void Form_Show()
        {
            this.CenterToScreen();
            this.ActiveControl = txtCode;
            this.ShowDialog();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

            POSData.deleteItem(mainId, 1);
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNoteB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnOk.Focus();
                btnOk.Select();
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
            map["code"] = code;
            map["name"] = name;
            map["cat"] = cat;
            map["seller_code"] = customersDic[sellerCode];
            map["buy_def_Price"] = buyprice.ToString();
            map["sell_def_Price"] = sellPrice.ToString();
            map["noteA"] = noteA;
            map["noteB"] = noteB;

            if (mainId == -1)
                POSData.insertNewItem(map);
            else
                POSData.updateItem(map);


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
            bool uniqe = POSData.isItemCodeUniqe(code, errrors);

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
            if (code.isEmpty() || name.isEmpty() || sellerCode.isEmpty())
            {
                MessageBox.Show("من فضلك املاء كل الحقول المطلوبة");
                cbSellerCode.Text = cbSellerCode.Items.Contains(cbSellerCode.Text) ? cbSellerCode.Text : "";
                complete= false;
            }
            return complete;
        }

        public void getFields()
        {
            code = txtCode.Text;
            name = txtName.Text;
            cat = txtCat.Text;
            sellerCode = cbSellerCode.Items.Contains(cbSellerCode.Text) ? cbSellerCode.Text : "";
            buyprice = (double) npBuyPrice.Value;
            sellPrice = (double) npSellPrice.Value;
            noteA = txtNoteA.Text;
            noteB = txtNoteB.Text;
        }

        public void setFields(int id)
        {
            StringBuilder errors = new StringBuilder();
            DataRow row = POSData.getItemRowById(id, errors);

            if (row == null)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            txtCode.Text = row["code"].ToString();
            txtName.Text = row["name"].ToString();
            txtCat.Text = row["cat"].ToString();
            cbSellerCode.Text = customersDic.FirstOrDefault(x => x.Value == row["seller_code"].ToString()).Key;
            npBuyPrice.Value = row["buy_def_Price"].ToString().isEmpty()? 1 : Convert.ToDecimal(row["buy_def_Price"]);
            npSellPrice.Value = row["sell_def_Price"].ToString().isEmpty() ? 1 : Convert.ToDecimal(row["sell_def_Price"]);
            txtNoteA.Text = row["note_a"].ToString();
            txtNoteB.Text = row["note_b"].ToString();
        }
    }
}
