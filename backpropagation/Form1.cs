using Backprop;
using System.Windows.Forms;
using System;

namespace backpropagation
{
    public partial class Form1 : Form
    {
        private NeuralNet neuralNet;

        public Form1()
        {
            InitializeComponent();
            AddInputValidation();
        }

        private void AddInputValidation()
        {
            inputBox1.KeyPress += ValidateNumericInput;
            inputBox2.KeyPress += ValidateNumericInput;
            inputBox3.KeyPress += ValidateNumericInput;
            inputBox4.KeyPress += ValidateNumericInput;
        }

        private void ValidateNumericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as RichTextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void TrainNeuralNetButton_Click(object sender, EventArgs e)
        {
            if (neuralNet == null)
            {
                MessageBox.Show("Please create the neural network first.");
                return;
            }

            TrainNeuralNetwork();
        }

        private void TrainNeuralNetwork()
        {
            for (int epoch = 0; epoch < 500; epoch++) {}
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            inputBox1.Clear();
            inputBox2.Clear();
            inputBox3.Clear();
            inputBox4.Clear();
            neuralNetOutputBox.Clear();
            testResultBox.Clear();
        }

        private void CreateNeuralNetButton_Click(object sender, EventArgs e)
        {
            neuralNet = new NeuralNet(4, 50, 1);
            testResultBox.Text = "Neural network created.";
        }

        private void TestNeuralNetButton_Click(object sender, EventArgs e)
        {
            if (neuralNet == null)
            {
                MessageBox.Show("Please create the neural network first.");
                return;
            }

            PerformNeuralNetTest();
        }

        private void PerformNeuralNetTest()
        {
            neuralNet.setInputs(0, Convert.ToDouble(inputBox1.Text));
            neuralNet.setInputs(1, Convert.ToDouble(inputBox2.Text));
            neuralNet.setInputs(2, Convert.ToDouble(inputBox3.Text));
            neuralNet.setInputs(3, Convert.ToDouble(inputBox4.Text));

            neuralNet.run();

            double output = neuralNet.getOuputData(0);
            neuralNetOutputBox.Text = output.ToString();
            testResultBox.Text = output > 0.6 ? "True" : "False";
        }
    }
}
