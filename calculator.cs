namespace Beigerock_s_Calculator_App
{
    public partial class calculator : Form
    {
        string inputNow = "";
        string oper = "";
        double res = 0;
        bool operPend = false;

        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void calcbutton1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            inputNow += button.Text;
            calculatorOutput.Text = inputNow;
        }

        private void calcbutton2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            inputNow += button.Text;
            calculatorOutput.Text = inputNow;
        }

        private void calcbutton3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            inputNow += button.Text;
            calculatorOutput.Text = inputNow;
        }

        private void calcbutton4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            inputNow += button.Text;
            calculatorOutput.Text = inputNow;
        }

        private void calcbutton5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            inputNow += button.Text;
            calculatorOutput.Text = inputNow;
        }

        private void calcbutton6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            inputNow += button.Text;
            calculatorOutput.Text = inputNow;
        }

        private void calcbutton7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            inputNow += button.Text;
            calculatorOutput.Text = inputNow;
        }

        private void calcbutton8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            inputNow += button.Text;
            calculatorOutput.Text = inputNow;
        }

        private void calcbutton9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            inputNow += button.Text;
            calculatorOutput.Text = inputNow;
        }

        private void calcbutton0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            inputNow += button.Text;
            calculatorOutput.Text = inputNow;
        }

        private void Eval()
        {
            if (operPend)
            {
                double secondNumber = double.Parse(inputNow);

                switch (oper)
                {
                    case "+":
                        res += secondNumber;
                        break;
                    case "-":
                        res -= secondNumber;
                        break;
                    case "*":
                        res *= secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            res /= secondNumber;
                        }
                        else
                        {
                            calculatorOutput.Text = "Error";
                            return;
                        }
                        break;
                }

                calculatorOutput.Text = res.ToString();
                inputNow = "";
                operPend = false;
            }
        }

        private void addition_Click(object sender, EventArgs e)
        {
            if (operPend)
            {
                Eval();
            }

            Button button = (Button)sender;
            oper = button.Text;
            res = double.Parse(inputNow);
            inputNow = "";
            operPend = true;
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            if (operPend)
            {
                Eval();
            }

            Button button = (Button)sender;
            oper = button.Text;
            res = double.Parse(inputNow);
            inputNow = "";
            operPend = true;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            if (operPend)
            {
                Eval();
            }

            Button button = (Button)sender;
            oper = button.Text;
            res = double.Parse(inputNow);
            inputNow = "";
            operPend = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (operPend)
            {
                Eval();
            }

            Button button = (Button)sender;
            oper = button.Text;
            res = double.Parse(inputNow);
            inputNow = "";
            operPend = true;
        }

        private void equalto_Click(object sender, EventArgs e)
        {
            Eval();
        }

        private void clearcalc_Click(object sender, EventArgs e)
        {
            inputNow = "";
            res = 0;
            oper = "";
            operPend = false;
            calculatorOutput.Text = "";
        }
    }
}
