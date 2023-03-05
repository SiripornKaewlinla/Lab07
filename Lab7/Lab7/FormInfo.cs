using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Lab7
{
    public partial class FormInfo : Form
    {
        Player _newPlayer;
        public FormInfo()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbLastname.Text;
            string Lastname = tb.Text;
            string Game = tbGame.Text;
            string Mail = tbMail.Text;
            string Number = tbNumber.Text;
            int Age = 0;
            try
            {
                string age = tbAge.Text;
                Age = Int32.Parse(age);
            }
            catch (FormatException ex)
            {
                //Do something if have some exception
                MessageBox.Show("คุณใส่ข้อมูลไม่ถูกต้อง");
                return;
            }

            _newPlayer = new Player(name, Lastname, Game, Mail, Number, Age);

            this.DialogResult= DialogResult.OK;

            this.Close();
        
        }
        public Player getPlayer() { return _newPlayer; }    
    }
}