namespace WinFormsControlsTwoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            //if(sender is CheckBox check)
            //{
            //    //MessageBox.Show($"{check.Checked} {check.CheckState}");

            //    switch (check.CheckState)
            //    {
            //        case CheckState.Indeterminate:
            //            check.CheckState = CheckState.Checked;
            //            break;
            //        case CheckState.Checked:
            //            check.CheckState = CheckState.Unchecked;
            //            break;
            //        case CheckState.Unchecked:
            //            check.CheckState = CheckState.Indeterminate;
            //            break;
            //    }                    
            //}
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radio && radio.Checked)
                MessageBox.Show($"{radio.Text}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> cities = new() { "Москва", "Калуга", "Тула", "Воронеж", "Брянск" };
            cmbBoxCities.Items.AddRange(cities.ToArray());
            chkListCities.Items.AddRange(cities.ToArray());


            //listCities.Items.Add("Новгород");
            //listCities.Items.Insert(2, "Томск");

            //Employee employee = new Employee() {  Name = "Bobby", Age = 30 };

            //listCities.Items.Add(employee);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCity.Text.Trim().Length > 0)
            {
                listCities.Items.Add(txtCity.Text.Trim());
                cmbBoxCities.Items.Add(txtCity.Text);
                txtCity.Text = "";
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listCities.SelectedItem is not null)
                listCities.Items.Remove(listCities.SelectedItem);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach (var item in listCities.SelectedItems)
                message += item + "\n";
            MessageBox.Show(message);
        }

        private void listCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string message = "";
            foreach (var item in listCities.SelectedItems)
                message += item + "\n";
            lblCities.Text = message;
        }

        private void listCities_DoubleClick(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void cmbBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCities.Text = cmbBoxCities.SelectedItem.ToString();
        }

        private void btnCheckListInfo_Click(object sender, EventArgs e)
        {
            string message = $"Selected: {chkListCities.SelectedItem}\nChecked:\n";
            foreach (var check in chkListCities.CheckedItems)
                message += check + "\n";
            MessageBox.Show(message);

        }

        private void btnUnCheck_Click(object sender, EventArgs e)
        {
            chkListCities.SetItemCheckState(chkListCities.SelectedIndex, CheckState.Unchecked);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            chkListCities.SetItemCheckState(chkListCities.SelectedIndex, CheckState.Checked);
        }

        private void btnIndet_Click(object sender, EventArgs e)
        {
            chkListCities.SetItemChecked(chkListCities.SelectedIndex, true);
            chkListCities.SetItemCheckState(chkListCities.SelectedIndex, CheckState.Indeterminate);
        }
    }
}
