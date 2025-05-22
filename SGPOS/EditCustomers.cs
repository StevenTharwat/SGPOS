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
    public partial class EditCustomers : Form
    {
        public int mainId;
        public string code, name, type, gender, cat, address, phone, noteA, noteB = string.Empty;


        public EditCustomers()
        {
            InitializeComponent();
        }

        public void init(int _operation)
        {
            mainId = _operation;

            if (mainId == -1)
            {
                this.Text = "New Customer";
                this.btnOk.Text = "ادخال";
                this.btnDelete.Visible = false;
            }
            else
            {
                this.Text = "Edit Customer";
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
            POSData.deleteCustomer(mainId, 1);
            this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNotB_KeyPress(object sender, KeyPressEventArgs e)
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
            map["code"] = code;
            map["name"] = name;
            map["cat"] = cat;
            map["gender"] = gender;
            map["type"] = type;
            map["address"] = address;
            map["phone"] = phone;
            map["noteA"] = noteA;
            map["noteB"] = noteB;

            if (mainId == -1) 
                POSData.insertNewCustomer(map);
            else 
                POSData.updateCustomer(map);

            
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
            bool uniqe = POSData.isCustomerCodeUniqe(code, errrors);

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
            if(code.isEmpty() || name.isEmpty() || type.isEmpty())
            {
                MessageBox.Show("من فضلك املاء كل الحقول المطلوبة");
                cbType.Text = cbType.Items.Contains(cbType.Text) ? cbType.Text : "";
                cbGender.Text = cbGender.Items.Contains(cbGender.Text) ? cbGender.Text : "";
                return false;
            }
            return complete;
        }

        public void getFields()
        {
            code = txtCode.Text;
		    name = txtName.Text;
		    cat = txtCat.Text;
		    type = cbType.Items.Contains(cbType.Text)? cbType.Text : "";
            gender = cbGender.Items.Contains(cbGender.Text)? cbGender.Text : "";
		    address = txtAddress.Text;
		    phone = txtPhone.Text;
		    noteA = txtNotA.Text;
            noteB = txtNotB.Text;
        }
        
        public void setFields(int id)
        {
            StringBuilder errors = new StringBuilder();
            DataRow row = POSData.getCustomerRowById(id, errors);
            
            if(row == null)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            
            txtCode.Text = row["code"].ToString();
            txtName.Text = row["name"].ToString();
            txtCat.Text = row["cat"].ToString();
            cbType.Text = row["type"].ToString();
            cbGender.Text = row["Gender"].ToString();
            txtAddress.Text = row["address"].ToString();
            txtPhone.Text = row["number"].ToString();
            txtNotA.Text = row["note_a"].ToString();
            txtNotB.Text = row["note_b"].ToString();
        }
    }
}
