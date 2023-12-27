using Coffee;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Coffeemachine caffe;
        public Form1()
        {
            InitializeComponent();
            caffe = new Coffeemachine();

        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void button_Click_1(object sender, EventArgs e)
        {
            //กาแฟดำ 
            bool canMake = caffe.makeBlackCoffee();
            if (canMake)
            {
                picture.Image = Properties.Resources.BlackC;
            }
            else 
            {
                picture.Image = Properties.Resources.co;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //มอลค่า
            bool canMake = caffe.makeMocha();
            if (canMake)
            {
                picture.Image = Properties.Resources.Mocha;
            }
            else
            {
                picture.Image = Properties.Resources.co;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ลาเต้
            bool canMake = caffe.makeLatte();
            if (canMake)
            {
                picture.Image = Properties.Resources.Latte;
            }
            else
            {
                picture.Image = Properties.Resources.co;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ช๊อตโกแลต
            bool canMake = caffe.makechoclate();
            if (canMake)
            {
                picture.Image = Properties.Resources.choclate;
            }
            else
            {
                picture.Image = Properties.Resources.co;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
