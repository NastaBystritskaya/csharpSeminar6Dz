// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] getArrayNumbers() {
    System.Console.WriteLine("Введите числа через запятую с пробелами: ");
    string userInput = Console.ReadLine()!;
    string[] arr = userInput.Split(", ");
    int[] arrNumbers = Array.ConvertAll(arr, int.Parse);
    return arrNumbers;
}

int sumPositive(int[] Array) {
    int sum = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0) {
            sum++;
        }
    }
    return sum;
}

void Main () {
    int[] array = getArrayNumbers();
    int sum = sumPositive(array);
    System.Console.WriteLine(sum);
}

Main();



