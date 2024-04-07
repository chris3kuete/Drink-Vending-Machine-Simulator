namespace Drink_Vending_Machine_Simulator_chap9_prob2_
{
    struct vendingMachineDetails
    {
        public string drinkName;
        public double drinkCost;
        public int numDrinksMachine;
    }


    public partial class Form1 : Form
    {
        double total = 0;
        //Array of 5 structure objects
        vendingMachineDetails[] arr = new vendingMachineDetails[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var drinks = new vendingMachineDetails[5];
            drinks[0].drinkName = "cola";
            drinks[0].drinkCost = 1.00;

            drinks[0].numDrinksMachine = int.Parse(colalbl.Text);
            drinks[0].numDrinksMachine--;
            colalbl.Text = drinks[0].numDrinksMachine.ToString();
            total = total + 1;
            totalSaleslbl.Text = total.ToString("c");

            if (drinks[0].numDrinksMachine <= 0)
            {
                MessageBox.Show("Cola is Out of order");
            }



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var drinks = new vendingMachineDetails[5];

            drinks[1].numDrinksMachine = int.Parse(rootBeerlbl.Text);
            drinks[1].numDrinksMachine--;
            rootBeerlbl.Text = drinks[1].numDrinksMachine.ToString();
            total = total + 1;
            totalSaleslbl.Text = total.ToString("c");

            if (drinks[1].numDrinksMachine <= 0)
            {
                MessageBox.Show("Root Beer is Out of oreder");
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var drinks = new vendingMachineDetails[5];

            drinks[2].numDrinksMachine = int.Parse(limelbl.Text);
            drinks[2].numDrinksMachine--;
            limelbl.Text = drinks[2].numDrinksMachine.ToString();
            total = total + 1;
            totalSaleslbl.Text = total.ToString("c");

            if (drinks[2].numDrinksMachine <= 0)
            {
                MessageBox.Show("Lemon lime is Out of Order");
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var drinks = new vendingMachineDetails[5];

            drinks[3].numDrinksMachine = int.Parse(grapelbl.Text);
            drinks[3].numDrinksMachine--;
            grapelbl.Text = drinks[3].numDrinksMachine.ToString();
            total = total + 1.5;
            totalSaleslbl.Text = total.ToString("c");

            if (drinks[3].numDrinksMachine <= 0)
            {
                MessageBox.Show("Grape Soda is Out of Order");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var drinks = new vendingMachineDetails[5];

            drinks[4].numDrinksMachine = int.Parse(sodalbl.Text);
            drinks[4].numDrinksMachine--;
            sodalbl.Text = drinks[4].numDrinksMachine.ToString();
            total = total + 1.5;
            totalSaleslbl.Text = total.ToString("c");

            if (drinks[4].numDrinksMachine <= 0)
            {
                MessageBox.Show("Cream Soda is out of order");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
