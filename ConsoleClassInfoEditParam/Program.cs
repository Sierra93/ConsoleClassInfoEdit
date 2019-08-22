using System;

namespace ConsoleClassInfoEditParam {
    using System;

    namespace ConsoleClassInfoEdit {
        // Создать класс с двумя переменными.Добавить функцию вывода на экран и функцию изменения этих переменных.Добавить функцию, которая находит сумму значений этих переменных, и функцию которая находит наибольшее значение из этих двух переменных.
        class Program {
            static void Main(string[] args) {
                Console.WriteLine("Введите команду:\n" +
                    "info - вывести переменные\n" +
                    "edit - редактирование переменных\n" +
                    "findSum - найти сумму чисел\n" +
                    "maxSum - найти наибольшее число");
                string checkKey = Convert.ToString(Console.ReadLine());
                switch (checkKey) {
                    case "info":
                        // Выводим переменные
                        InfoEditParam.Info();
                        break;
                    case "edit":
                        // Изменяем переменные
                        InfoEditParam.Edit();
                        break;
                    case "findSum":
                        // Находим сумму переменных
                        InfoEditParam.FindSum();
                        break;
                    case "maxSum":
                        // Находим наибольшее значение
                        InfoEditParam.FindMaxSum();
                        break;
                }
                Console.ReadKey();
            }
        }
        internal class InfoEditParam {
            internal static int oneValue = 2;
            internal static int twoValue = 7;
            // Выводим переменные
            internal static void Info() {
                Console.WriteLine($"Первая переменная: {oneValue}\nВторая переменная: {twoValue}");
            }
            // Изменяем переменные
            internal static void Edit() {
                Console.WriteLine("Введите новые значения");
                Console.WriteLine("Введите первое число: ");
                int oneNewValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int twoNewValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Первое новое число: {oneNewValue}\n" +
                    $"Второе новое число: {twoNewValue}");
            }
            // Находим сумму чисел
            internal static void FindSum() {
                int resSum = oneValue + twoValue;
                Console.WriteLine($"Сумма чисел: {resSum}");
            }
            // Находим наибольшее число
            internal static void FindMaxSum() {
                int maxValue = 0;
                string valueNotFound = "Числа равны";
                if (oneValue > twoValue) {
                    maxValue = oneValue;
                }
                else if (oneValue < twoValue) {
                    maxValue = twoValue;
                }
                else {
                    Console.WriteLine(valueNotFound);
                }
                Console.WriteLine($"Наибольшее число: {maxValue}");
            }
        }
    }

}
