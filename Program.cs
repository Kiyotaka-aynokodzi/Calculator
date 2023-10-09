// See https://aka.ms/new-console-template for more information
public class Calculator
{
    public static void Main()
    {
        double result = 0;
        double firstNumber = 0;
        double secondNumber = 0;
        string caseArifmeticOperations = "";
        bool check = true;
        string question;
        double newNumber = 0;
        string secondCaseArifmeticOperations = "";
        double newResult;

        try
        {
            Console.WriteLine("Введите число");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знак:");
            caseArifmeticOperations = Console.ReadLine();

            Console.WriteLine("Введите второе число");
            secondNumber = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("ошибка");
            Console.ReadLine();
        }
        switch (caseArifmeticOperations)
        {
            case "/":
                if (secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                }
                else
                {
                    Console.WriteLine("ошибка");
                }
                break;

            case "*":
                result = firstNumber * secondNumber;
                break;

            case "+":
                result = firstNumber + secondNumber;
                break;

            case "-":
                result = firstNumber - secondNumber;
                break;

        }
        newResult = result;
        Console.WriteLine(result);
        while (check == true)
        {
            Console.Write("Продолжить?");
            question = Console.ReadLine();
            if (question == "Да" || question == "да" || question == "Yes" || question == "yes")
            {

                try
                {
                    Console.WriteLine("Введите знак");
                    secondCaseArifmeticOperations = Console.ReadLine();

                    Console.WriteLine("Введите  новое число");
                    newNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("ошибка");
                }

                switch (secondCaseArifmeticOperations)
                {
                    case "/":
                        if (secondNumber != 0)
                        {
                            newResult = newResult / newNumber;
                        }
                        else
                        {
                            Console.WriteLine("ошибка");
                        }
                        break;

                    case "*":
                        newResult = newResult * newNumber;
                        break;

                    case "+":
                        newResult = newResult + newNumber;
                        break;

                    case "-":
                        newResult = newResult - newNumber;
                        break;
                }
                Console.WriteLine(newResult);
                check = true;

            }
            else if (question == "Нет" || question == "нет" || question == "No" || question == "no")
            {
                Console.ReadLine();
                check = false;
            }
            else
            {
                Console.WriteLine("Ошибка");
                check = false;
                Console.ReadLine();
            }
        }
    }
}