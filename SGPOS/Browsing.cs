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
    public partial class Browsing : Form
    {
        public string form_name;
        public string dialogValue;
        public int pageNumber;
        DataTable GridDataSourse = new DataTable();
        public Browsing()
        {
            InitializeComponent();
        }

        public void init(string _form_name)
        {
            try
            {

                form_name = _form_name;
                this.Text = form_name;
                this.dpFrom.Value = dpFrom.MinDate;
                this.dpTo.Value = DateTime.Now;

                if (form_name == "اصناف البرنامج")
                {
                    pageNumber = 4;
                }
                else if (form_name == "عملاء البرنامج")
                {
                    pageNumber = 5;
                }
                else if (form_name == "فاتورة بيع")
                {
                    pageNumber = 6;
                }
                else if (form_name == "فاتورة شراء") 
                { 
                    pageNumber = 7;
                }
                else if (form_name == "مرتجع شراء")
                {
                    pageNumber = 8;
                }
                else if (form_name == "مرتجع بيع")
                {
                    pageNumber = 9;
                }
                else if (form_name == "جرد اصناف")
                {
                    pageNumber = 10;
                    btnAdd.Visible = false;
                    btnDelete.Visible = false;
                    btnEdit.Visible = false;
                }
                refreshGrid();
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

        private void btnToday_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime today = DateTime.Now;
                this.dpFrom.Value = today;
                this.dpTo.Value = today;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (pageNumber == 4) new EditItems().init(-1);
                else if (pageNumber == 5) new EditCustomers().init(-1);
                else if (pageNumber == 6) new EditInv().init(-1, "s");
                else if (pageNumber == 7) new EditInv().init(-1, "b");
                else if (pageNumber == 8) new EditInv().init(-1, "rs");
                else if (pageNumber == 9) new EditInv().init(-1, "rb");
                refreshGrid();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

            string inputPass = Dialog("Adminstrator Password", "Authentication");
            string dbAdminPass = connection.sqlReturnValue("select value_ from Adminstrator where field = 'AdminPassword';");
            if(inputPass == dbAdminPass){
                if (grid.SelectedItems.Count == 1)
                {
                    var dataRow = (grid.SelectedItems[0] as DataRowView).Row;
                    int selectedRowId = Convert.ToInt32(dataRow["رقم تسلسلي"]);
                    //int selectedRowId = Convert.ToInt32(grid.SelectedItem.GetType.Cells["رقم تسلسلي"].Value);
                    if (pageNumber == 4) new EditItems().init(selectedRowId);
                    else if (pageNumber == 5) new EditCustomers().init(selectedRowId);
                        else if (pageNumber == 6) new EditInv().init(selectedRowId, "s");
                        else if (pageNumber == 7) new EditInv().init(selectedRowId, "b");
                        else if (pageNumber == 8) new EditInv().init(selectedRowId, "rs");
                        else if (pageNumber == 9) new EditInv().init(selectedRowId, "rb");
                }
                else
                {
                    MessageBox.Show("من فضلك حدد صف واحد للتعديل");
                }
            }else
            {
                MessageBox.Show("Wrong Adminstrator Password !");
            }
            connection.sqlStatment($"insert into accessPasswords values (N'{inputPass}','{dbAdminPass}','{DateTime.Now}');");
            refreshGrid();
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

            string inputPass = Dialog("Adminstrator Password", "Authentication");
            string dbAdminPass = connection.sqlReturnValue("select value_ from Adminstrator where field = 'AdminPassword';");
            if (inputPass == dbAdminPass)
            {
                if(grid.SelectedItems.Count != 1)
                {
                    MessageBox.Show("من فضلك حدد صف واحد للمسح");
                    return;
                }
                else
                {
                    var dataRow = (grid.SelectedItems[0] as DataRowView).Row;

                    if(pageNumber == 5)
                    {
                        int selectedRowId = Convert.ToInt32(dataRow["رقم تسلسلي"]);
                        POSData.deleteCustomer(selectedRowId, 1);
                    }
                    if (pageNumber == 4)
                    {
                        int selectedRowId = Convert.ToInt32(dataRow["رقم تسلسلي"]);
                        POSData.deleteItem(selectedRowId, 1);
                    }
                    if (pageNumber == 6 || pageNumber == 7 || pageNumber == 8 || pageNumber == 9)
                    {
                        int selectedRowId = Convert.ToInt32(dataRow["رقم تسلسلي"]);
                        POSData.deleteInv(selectedRowId, 1);
                    }
                    refreshGrid();
                }
            }
            else if(!inputPass.isEmpty())
            {
                MessageBox.Show("Wrong Adminstrator Password !");
            }
            connection.sqlStatment($"insert into accessPasswords values (N'{inputPass}','{dbAdminPass}','{DateTime.Now}');");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string Dialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 510,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            textBox.PasswordChar = '*';
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        public void refreshGrid()
        {
            try
            {

            DateTime from = dpFrom.Value;
            DateTime to = dpTo.Value;
            if (pageNumber == 5)
            {
                GridDataSourse = POSData.getCustomerTable(from, to);
                grid.DataSource = GridDataSourse;
                this.grid.Columns["رقم تسلسلي"].Visible = false;
            }
                else if (pageNumber == 4)
            {
                GridDataSourse = POSData.getItemTable(from, to);
                grid.DataSource = GridDataSourse;
                this.grid.Columns["رقم تسلسلي"].Visible = false;
            }
                else if (pageNumber == 6)
            {
                GridDataSourse = POSData.getSInvsTable(from, to);
                grid.DataSource = GridDataSourse;
                this.grid.Columns["رقم تسلسلي"].Visible = false;
            }
                else if (pageNumber == 7)
            {
                GridDataSourse = POSData.getBInvsTable(from, to);
                grid.DataSource = GridDataSourse;
                this.grid.Columns["رقم تسلسلي"].Visible = false;
            }
                else if (pageNumber == 8)
            {
                GridDataSourse = POSData.getRSInvsTable(from, to);
                grid.DataSource = GridDataSourse;
                this.grid.Columns["رقم تسلسلي"].Visible = false;
            }
                else if (pageNumber == 9)
            {
                GridDataSourse = POSData.getRBInvsTable(from, to);
                grid.DataSource = GridDataSourse;
                this.grid.Columns["رقم تسلسلي"].Visible = false;
            }
                else if (pageNumber == 10)
                {
                    GridDataSourse = POSData.getItemsReport(from, to);
                    grid.DataSource = GridDataSourse;
                }
                grid.DataSource = GridDataSourse;
            labTotalCount.Text = GridDataSourse.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
            refreshGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDateAll_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime today = DateTime.Now;
                this.dpFrom.Value = dpFrom.MinDate;
                this.dpTo.Value = today;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
