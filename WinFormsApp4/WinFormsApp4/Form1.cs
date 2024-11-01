namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Car
        {
            public string name;
            public string color;
            
            

            public Car(string name, string color)
            {
                name = name;
               color = color;

               name = "Benz";
                color = "blue";
            }
            public void Destructors()
            {
                MessageBox.Show($"Name is:{name}, and Color: {color}");

            }
                
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car("Benz","blue");
            
            
             


        }
    }
}
