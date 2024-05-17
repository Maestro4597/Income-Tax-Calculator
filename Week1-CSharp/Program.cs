// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Welcome, to your very own Federal Income Tax Calculator!");
Console.Write("\nFirst we would like to know how many w2 forms you will be completing today...Enter a number: ");
string input;
int intVal;
input = Console.ReadLine();
intVal = Convert.ToInt32(input);
Console.WriteLine("\nYou entered {0}", intVal);

int grossSum = 0;
for (int i = 0; i < intVal; i++) {
    Console.WriteLine("\n Tell us your gross income for w2 form {0}:", i+1);
    string grossIncome = Console.ReadLine();
    int grossValue = Convert.ToInt32(grossIncome);
    grossSum = grossSum + grossValue;
    Console.WriteLine("Got it. For w2 Form {0} your Gross Income is ${1}", i+1, grossIncome);
    }

Console.WriteLine("\n Your total Gross income for the year is: {0} ", grossSum);



Console.WriteLine("\n Please enter your deductions & charitable donations as a list of values (When you are done, enter 0):");

double sum = 0;


for (int i=0; i<1000;i++)
{
   input = Console.ReadLine();
   int inputDeductions = Convert.ToInt32(input);
   sum = sum + inputDeductions;
   double totalGrossIncome = grossSum - sum;
   double adjustedGrosstax;
   double afterTaxes;
   

    if (inputDeductions <=0)
    {
        
        Console.WriteLine("\n Your total deductions are: ${0}", sum);
        if (sum < 12_950)
        {
            totalGrossIncome = grossSum - 12_950;
            Console.WriteLine("  This total is less than the standard deduction rate. $12,950 will be subtracted from your gross income before taxes.");
            Console.WriteLine("\nYour Adjusted Gross Income is: ${0} ", totalGrossIncome);
           

            if (totalGrossIncome <= 10_275)
            {
                Console.WriteLine("You are in the 10% Tax Bracket.");
                adjustedGrosstax = (totalGrossIncome-0) * .10;
                Console.WriteLine("Your owed amount in taxes comes to ${0} based on your Adjusted Gross Income", adjustedGrosstax);
                double grossIncomePercentage = (adjustedGrosstax / grossSum) * 100;
                double percentageOfAdjustedGross = (adjustedGrosstax / totalGrossIncome) * 100;
                Console.WriteLine(" -This is {0} % of your Adjusted Gross or {1} % of your Gross Income ", percentageOfAdjustedGross, grossIncomePercentage);
                afterTaxes = totalGrossIncome - adjustedGrosstax;
                Console.WriteLine("\nHere is your Salary After Taxes: ${0}", afterTaxes);
                break;
            }
            if (totalGrossIncome > 10_275 && totalGrossIncome < 41_775)
            {
                Console.WriteLine("You are in the 12% Tax Bracket.");
                adjustedGrosstax = (10_275 - 0) * .10 + (totalGrossIncome-10_275) * .12;
                Console.WriteLine("Your owed amount in taxes comes to ${0} based on your Adjusted Gross Income", adjustedGrosstax);
                double grossIncomePercentage = (adjustedGrosstax / grossSum) * 100;
                double percentageOfAdjustedGross = (adjustedGrosstax / totalGrossIncome) * 100;
                Console.WriteLine(" -This is {0} % of your Adjusted Gross or {1} % of your Gross Income ", percentageOfAdjustedGross, grossIncomePercentage);
                afterTaxes = totalGrossIncome - adjustedGrosstax;
                Console.WriteLine("\nHere is your Salary After Taxes: ${0}", afterTaxes);
                break;
            }
            if (totalGrossIncome > 41_775 && totalGrossIncome < 89_075)
            {
                Console.WriteLine("You are in the 22% Tax Bracket.");
                adjustedGrosstax = (10_275 - 0) * .10 + (41_775 - 10_275) * .12 + (totalGrossIncome-41_775) * .22;
                Console.WriteLine("Your owed amount in taxes comes to ${0} based on your Adjusted Gross Income", adjustedGrosstax);
                double grossIncomePercentage = (adjustedGrosstax / grossSum) * 100;
                double percentageOfAdjustedGross = (adjustedGrosstax / totalGrossIncome) * 100;
                Console.WriteLine(" -This is {0} % of your Adjusted Gross or {1} % of your Gross Income ", percentageOfAdjustedGross, grossIncomePercentage);
                afterTaxes = totalGrossIncome - adjustedGrosstax;
                Console.WriteLine("\nHere is your Salary After Taxes: ${0}", afterTaxes);
                break;
            }
            if (totalGrossIncome > 89_075 && totalGrossIncome < 170_075)
            {
                Console.WriteLine("You are in the 24% Tax Bracket.");
                adjustedGrosstax = (10_275 - 0) * .10 + (41_775 - 10_275) * .12 + (89_075 - 41_775) * .22 + (totalGrossIncome-89_075) * .24;
                Console.WriteLine("Your owed amount in taxes comes to ${0} based on your Adjusted Gross Income", adjustedGrosstax);
                double grossIncomePercentage = (adjustedGrosstax / grossSum) * 100;
                double percentageOfAdjustedGross = (adjustedGrosstax / totalGrossIncome) * 100;
                Console.WriteLine(" -This is {0} % of your Adjusted Gross or {1} % of your Gross Income ", percentageOfAdjustedGross, grossIncomePercentage);
                afterTaxes = totalGrossIncome - adjustedGrosstax;
                Console.WriteLine("\nHere is your Salary After Taxes: ${0}", afterTaxes);
                break;
            }
            if (totalGrossIncome > 170_075 && totalGrossIncome < 215_950)
            {
                Console.WriteLine("You are in the 32% Tax Bracket.");
                adjustedGrosstax = (10_275 - 0) * .10 + (41_775 - 10_275) * .12 + (89_075 - 41_775) * .22 + (170_075 - 89_075) * .24 + (totalGrossIncome-170_075) * .32;
                Console.WriteLine("Your owed amount in taxes comes to ${0} based on your Adjusted Gross Income", adjustedGrosstax);
                double grossIncomePercentage = (adjustedGrosstax / grossSum) * 100;
                double percentageOfAdjustedGross = (adjustedGrosstax / totalGrossIncome) * 100;
                Console.WriteLine(" -This is {0} % of your Adjusted Gross or {1} % of your Gross Income ", percentageOfAdjustedGross, grossIncomePercentage);
                afterTaxes = totalGrossIncome - adjustedGrosstax;
                Console.WriteLine("\nHere is your Salary After Taxes: ${0}", afterTaxes);
                break;
            }
            if (totalGrossIncome > 215_950 && totalGrossIncome < 539_900)
            {
                Console.WriteLine("You are in the 35% Tax Bracket.");
                adjustedGrosstax = (10_275 - 0) * .10 + (41_775 - 10_275) * .12 + (89_075 - 41_775) * .22 + (170_075 - 89_075) * .24 + (215_950 - 170_075) * .32 + (totalGrossIncome-215_950) * .35;
                Console.WriteLine("Your owed amount in taxes comes to ${0} based on your Adjusted Gross Income", adjustedGrosstax);
                double grossIncomePercentage = (adjustedGrosstax / grossSum) * 100;
                double percentageOfAdjustedGross = (adjustedGrosstax / totalGrossIncome) * 100;
                Console.WriteLine(" -This is {0} % of your Adjusted Gross or {1} % of your Gross Income ", percentageOfAdjustedGross, grossIncomePercentage);
                afterTaxes = totalGrossIncome - adjustedGrosstax;
                Console.WriteLine("\nHere is your Salary After Taxes: ${0}", afterTaxes);
                break;
            }
            if (totalGrossIncome > 539_900)
            {
                Console.WriteLine("You are in the 37% Tax Bracket.");
                adjustedGrosstax = (10_275 - 0) * .10 + (41_775 - 10_275) * .12 + (89_075 - 41_775) * .22 + (170_075 - 89_075) * .24 + (215_950 - 170_075) * .32 + (539_900 - 215_950) * .35 + (totalGrossIncome-539_900) * .37;
                Console.WriteLine("Your owed amount in taxes comes to ${0} based on your Adjusted Gross Income", adjustedGrosstax);
                double grossIncomePercentage = (adjustedGrosstax / grossSum) * 100;
                double percentageOfAdjustedGross = (adjustedGrosstax / totalGrossIncome) * 100;
                Console.WriteLine(" -This is {0} % of your Adjusted Gross or {1} % of your Gross Income ", percentageOfAdjustedGross, grossIncomePercentage);
                afterTaxes = totalGrossIncome - adjustedGrosstax;
                Console.WriteLine("\nHere is your Salary After Taxes: ${0}", afterTaxes);
                break;
            }

        }
        else
        {
            Console.WriteLine("\nYour Adjusted Gross Income is: ${0} ", totalGrossIncome);
            if (totalGrossIncome <= 10_275)
            {
                Console.WriteLine("You are in the 10% Tax Bracket.");
                adjustedGrosstax = totalGrossIncome * .10;
                Console.WriteLine("Your owed amount in taxes comes to ${0} based on your Adjusted Gross Income", adjustedGrosstax);
                double grossIncomePercentage = (adjustedGrosstax / grossSum) * 100;
                double percentageOfAdjustedGross = (adjustedGrosstax / totalGrossIncome) * 100;
                Console.WriteLine(" -This is {0} % of your Adjusted Gross or {1} % of your Gross Income ", percentageOfAdjustedGross, grossIncomePercentage);
                afterTaxes = totalGrossIncome - adjustedGrosstax;
                Console.WriteLine("\nHere is your Salary After Taxes: ${0}", afterTaxes);
                break;
            }
            if (totalGrossIncome > 10_275 && totalGrossIncome < 41_775)
            {
                Console.WriteLine("You are in the 12% Tax Bracket.");
                adjustedGrosstax = totalGrossIncome * .12;
                Console.WriteLine("Your owed amount in taxes comes to ${0} based on your Adjusted Gross Income", adjustedGrosstax);
                double grossIncomePercentage = (adjustedGrosstax / grossSum) * 100;
                double percentageOfAdjustedGross = (adjustedGrosstax / totalGrossIncome) * 100;
                Console.WriteLine(" -This is {0} % of your Adjusted Gross or {1} % of your Gross Income ", percentageOfAdjustedGross, grossIncomePercentage);
                afterTaxes = totalGrossIncome - adjustedGrosstax;
                Console.WriteLine("\nHere is your Salary After Taxes: ${0}", afterTaxes);
                break;
            }
            if (totalGrossIncome > 41_775 && totalGrossIncome < 89_075)
            {
                Console.WriteLine("You are in the 22% Tax Bracket.");
                adjustedGrosstax = totalGrossIncome * .22;
                Console.WriteLine("Your owed amount in taxes comes to ${0} based on your Adjusted Gross Income", adjustedGrosstax);
                double grossIncomePercentage = (adjustedGrosstax / grossSum) *100;
                double percentageOfAdjustedGross = (adjustedGrosstax / totalGrossIncome) * 100;
                Console.WriteLine(" -This is {0} % of your Adjusted Gross or {1} % of your Gross Income ", percentageOfAdjustedGross, grossIncomePercentage);
                afterTaxes = totalGrossIncome - adjustedGrosstax;
                Console.WriteLine("\nHere is your Salary After Taxes: ${0}", afterTaxes);
                break;
            }
            if (totalGrossIncome > 89_075 && totalGrossIncome < 170_075)
            {
                Console.WriteLine("You are in the 24% Tax Bracket.");
                adjustedGrosstax = totalGrossIncome * .24;
                Console.WriteLine("Your owed amount in taxes comes to ${0} based on your Adjusted Gross Income", adjustedGrosstax);
                double grossIncomePercentage = (adjustedGrosstax / grossSum) * 100;
                double percentageOfAdjustedGross = (adjustedGrosstax / totalGrossIncome) * 100;
                Console.WriteLine(" -This is {0} % of your Adjusted Gross or {1} % of your Gross Income ", percentageOfAdjustedGross, grossIncomePercentage);
                afterTaxes = totalGrossIncome - adjustedGrosstax;
                Console.WriteLine("\nHere is your Salary After Taxes: ${0}", afterTaxes);
                break;
            }
            if (totalGrossIncome > 170_075 && totalGrossIncome < 215_950)
            {
                Console.WriteLine("You are in the 32% Tax Bracket.");
                adjustedGrosstax = totalGrossIncome * .32;
                Console.WriteLine("Your owed amount in taxes comes to ${0} based on your Adjusted Gross Income", adjustedGrosstax);
                double grossIncomePercentage = (adjustedGrosstax / grossSum) * 100;
                double percentageOfAdjustedGross = (adjustedGrosstax / totalGrossIncome) * 100;
                Console.WriteLine(" -This is {0} % of your Adjusted Gross or {1} % of your Gross Income ", percentageOfAdjustedGross, grossIncomePercentage);
                afterTaxes = totalGrossIncome - adjustedGrosstax;
                Console.WriteLine("\nHere is your Salary After Taxes: ${0}", afterTaxes);
                break;
            }
            if (totalGrossIncome > 215_950 && totalGrossIncome < 539_900)
            {
                Console.WriteLine("You are in the 35% Tax Bracket.");
                adjustedGrosstax = totalGrossIncome * .35;
                Console.WriteLine("Your owed amount in taxes comes to ${0} based on your Adjusted Gross Income", adjustedGrosstax);
                double grossIncomePercentage = (adjustedGrosstax / grossSum) * 100;
                double percentageOfAdjustedGross = (adjustedGrosstax / totalGrossIncome) * 100;
                Console.WriteLine(" -This is {0} % of your Adjusted Gross or {1} % of your Gross Income ", percentageOfAdjustedGross, grossIncomePercentage);
                afterTaxes = totalGrossIncome - adjustedGrosstax;
                Console.WriteLine("\nHere is your Salary After Taxes: ${0}", afterTaxes);
                break;
            }
            if (totalGrossIncome > 539_900)
            {
                Console.WriteLine("You are in the 37% Tax Bracket.");
                adjustedGrosstax = totalGrossIncome * .37;
                Console.WriteLine("Your owed amount in taxes comes to ${0} based on your Adjusted Gross Income", adjustedGrosstax);
                double grossIncomePercentage = (adjustedGrosstax / grossSum) * 100;
                double percentageOfAdjustedGross = (adjustedGrosstax / totalGrossIncome) * 100;
                Console.WriteLine(" -This is {0} % of your Adjusted Gross or {1} % of your Gross Income ", percentageOfAdjustedGross, grossIncomePercentage);
                afterTaxes = totalGrossIncome - adjustedGrosstax;
                Console.WriteLine("\nHere is your Salary After Taxes: ${0}", afterTaxes);
                break;
            }
        }

    }
   

}

Console.WriteLine("The 2022 Taxable bracket is Generating... \n");
Console.WriteLine("Your Range of Income.                                     Your Tax Bracket.");
Console.WriteLine("$0 - $10, 275                                                  10 %");
Console.WriteLine("$10,275 - $41,775                                              12 %");
Console.WriteLine("$41,775 - 89,075                                               22 % ");
Console.WriteLine("$89,075 - $170,050                                             24 % ");
Console.WriteLine("$170,050 - $215,950                                            32 % ");
Console.WriteLine("$215,950 - 539,900                                             35 % ");
Console.WriteLine("$539,900 and above                                             37 %");

