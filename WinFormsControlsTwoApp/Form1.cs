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
    }
}
