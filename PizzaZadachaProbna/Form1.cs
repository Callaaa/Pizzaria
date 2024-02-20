namespace PizzaZadachaProbna
{
    public partial class Form1 : Form
    {
        string pizza;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string razmer=comboBox1.Text;
            List<string> sos = new List<string>();
            bool isAllChecked = false;

            



            if (rdB4Sirene.Checked)
            {
                pizza = rdB4Sirene.Text;
                isAllChecked = true;
            }
            else
                if (rdBItaly.Checked)
            {
                pizza = rdBItaly.Text;
                isAllChecked = true;
            }
            else
                if (rdBKarlovo.Checked)
            {
                pizza = rdBKarlovo.Text;
                isAllChecked = true;
            }
            else
                if (rdBLyta.Checked)
            {
                pizza = rdBLyta.Text;
                isAllChecked = true;
            }
            else
                if (rdBMikelan.Checked)
            {
                pizza = rdBMikelan.Text;
                isAllChecked = true;
            }
            else
                if (rdBPile.Checked)
            {
                pizza = rdBPile.Text;
                isAllChecked = true;
            }
            else
                if (rdBShunka.Checked)
            {
                pizza = rdBShunka.Text;
                isAllChecked = true;
            }
            else
                if (rdBSuperPizza.Checked)
            {
                pizza = rdBSuperPizza.Text;
                isAllChecked = true;
            }
            else
                if (rdBVegetar.Checked)
            {
                pizza = rdBVegetar.Text;
                isAllChecked = true;
            }

            if (string.IsNullOrEmpty(razmer))
            {
                isAllChecked = false;
            }

            if (chbChubrica.Checked)
            {
                sos.Add(chbChubrica.Text);
            }
            if (chbKetchup.Checked)
            {
                sos.Add(chbKetchup.Text);
            }
            if (chbMayo.Checked)
            {
                sos.Add(chbMayo.Text);

            }
            if (chbParmezan.Checked)
            {
                sos.Add(chbParmezan.Text);

            }
            if (chbSosLyt.Checked)
            {
                sos.Add(chbSosLyt.Text);

            }

            if (isAllChecked)
            {
                DialogResult result=MessageBox.Show($"Вие избрахте:{razmer} пица:{pizza}" +
                    $"\nСъставки:{string.Join(" ",sos)}",
                    "Потвърждавате ли?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Изпратено!", "Информация!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Application.Restart();
                }
                
                
            }
            else
            {
                MessageBox.Show("Има невъведени данни!","Внимание!",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
