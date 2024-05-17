using System.Reflection.Emit;

namespace Week2_Project1
{
    public partial class Form1 : Form
    {

        //  https://github.com/EricCharnesky/CIS297-Winter2023/blob/main/Week2-TaxEstimator/Week2-TaxEstimator/Program.cs

        const int STANDARD_DEDUCTION = 12_950;

        const int START_OF_10_PERCENT_BRACKET = 0;
        const int START_OF_12_PERCENT_BRACKET = 10_275;
        const int START_OF_22_PERCENT_BRACKET = 41_775;
        const int START_OF_24_PERCENT_BRACKET = 89_075;
        const int START_OF_32_PERCENT_BRACKET = 170_050;
        const int START_OF_35_PERCENT_BRACKET = 215_950;
        const int START_OF_37_PERCENT_BRACKET = 539_900;

        const int START_OF_10_PERCENT_BRACKET_MARRIED = 0;
        const int START_OF_12_PERCENT_BRACKET_MARRIED = 20_550;
        const int START_OF_22_PERCENT_BRACKET_MARRIED = 83_550;
        const int START_OF_24_PERCENT_BRACKET_MARRIED = 178_150;
        const int START_OF_32_PERCENT_BRACKET_MARRIED = 340_100;
        const int START_OF_35_PERCENT_BRACKET_MARRIED = 431_900;
        const int START_OF_37_PERCENT_BRACKET_MARRIED = 647_850;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grossIncomeLabel.Hide();
            grossIncomeText.Hide();
            w2Label.Hide();
            w2Text.Hide();
            Total.Hide();
            deductables.Hide();
            deductableText.Hide();
            moreButton.Hide();
            label1.Hide();
            textBox1.Hide();


        }

        int numberofW2s = 0;
        int grossIncome = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            w2Label.Show();
            w2Text.Show();


        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            w2Label.Show();
            w2Text.Show();

        }

        private void w2Label_Click(object sender, EventArgs e)
        {

        }

        private void w2Text_TextChanged(object sender, EventArgs e)
        {
            numberofW2s = int.Parse(w2Text.Text);
            grossIncomeLabel.Show();
            grossIncomeText.Show();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            grossIncome = int.Parse(grossIncomeText.Text);
            Total.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        int loopNumber = 1;
        int amountGross = 0;
        private void Next_Click(object sender, EventArgs e)
        {
            loopNumber++;
            if (loopNumber <= numberofW2s + 1)
            {
                grossIncomeLabel.Text = "Gross income #" + loopNumber;
                amountGross += int.Parse(grossIncomeText.Text);
                Total.Text = amountGross.ToString();
            }

            deductables.Show();
            deductableText.Show();
            moreButton.Show();


        }


        private void deductables_Click(object sender, EventArgs e)
        {

        }

        int totalDeductables = 0;
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            totalDeductables = int.Parse(deductableText.Text);

        }

        private void moreButton_Click(object sender, EventArgs e)
        {

            int adjustedGrossIncome = amountGross - totalDeductables;

















        }


        private double getTaxesAtBracket(int income, int startOfBracket, int endOfBracket, double taxRate)
            {
            if (income > endOfBracket)
            {
                return (endOfBracket - startOfBracket) + taxRate;
            }

            else if (income < startOfBracket)
            {
                return 0;

            }
            else
                return (income - startOfBracket) * taxRate;
            }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }

}