// See https://aka.ms/new-console-template for more information
public class Calculator
{
    public static void Main()
    {
        double result = 0;
        double firstNumber = 0;
        double secondNumber = 0;
        double newResult;
        double newNumber = 0;
        string switchCasesArifmeticOperations = "";
        string question;
        string secondSwitchCasesArifmeticOperations = "";
        bool check = true;
        decimal quantityOperations = 1;
        string quantityOperationsFocus = "не скажу";

        try//делаю проверку на ошибки при вводе данных
        {
            Console.WriteLine("Введите число");
            firstNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Введите знак:");
            switchCasesArifmeticOperations = Console.ReadLine();

            Console.WriteLine("Введите второе число");
            secondNumber = Convert.ToInt64(Console.ReadLine());
        }

        catch (Exception)
        {
            Console.WriteLine("ошибка");
            Console.ReadLine();
        }

        switch (switchCasesArifmeticOperations)//далее создаю кейсы с арифметическими операциями
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

        while (check == true)//создал цикл для возможности продолжать или нет работу над нашим результатом
        {
            quantityOperations++;
            Console.Write("Продолжить?");
            question = Console.ReadLine();
            if (question == "Yes" || question == "yes") 
            {

                try //снова проверка на ввод числа
                {
                    Console.WriteLine("Введите знак");
                    secondSwitchCasesArifmeticOperations = Console.ReadLine();

                    Console.WriteLine("Введите  новое число");
                    newNumber = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("ошибка");
                }

                switch (secondSwitchCasesArifmeticOperations)//снова кейсы для арифметических операций с нашим прошлым result, для вычисления newResult
                {
                    case "/":
                        if (newNumber != 0)
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

            else if (question == "No" || question == "no")
            {
            Console.WriteLine("Покеда");
                Console.ReadLine();
                check = false;
                quantityOperations += quantityOperations - quantityOperations - 1;
            }

            else
            {
                Console.WriteLine("Ошибка");
                check = false;
                Console.ReadLine();
                quantityOperations += quantityOperations - quantityOperations - 1;
            }
        }
        Console.WriteLine("Количество выполненных операций: " + quantityOperations);
    }
}
