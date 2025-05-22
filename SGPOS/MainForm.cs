namespace SGPOS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void Browsing_Click(object sender, EventArgs e)
        {
            try
            {
            Button sender_btn = (Button)sender;
            new Browsing().init(sender_btn.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(e.KeyChar == 29)
            //{
            //    new EditCustomers().init(-1);
            //}
            //if (e.KeyChar == 27)
            //{
            //    new EditInv().init(-1, "s");
            //}
            //if (e.KeyChar == 16)
            //{
            //    new EditInv().init(-1, "b");
            //}
            //if (e.KeyChar == 9)
            //{
            //    new EditItems().init(-1);
            //}
            //if (e.KeyChar == 9)
            //{
            //    new EditInv().init(-1, "rs");
            //}
            //if (e.KeyChar == 9)
            //{
            //    new EditInv().init(-1, "rb");
            //}



            if (e.KeyChar == 9)
            {
                new EditInv().init(-1, "s");
            }
            else if(e.KeyChar == 32)
            {

            }
        }
    }
}