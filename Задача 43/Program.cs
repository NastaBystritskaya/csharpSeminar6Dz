// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetUserInput(string text) {
    System.Console.WriteLine(text);
    double input = double.Parse(Console.ReadLine()!);
    return input;
}

void PrintCrossCoordinates() {
    double b1 = GetUserInput("Введите b1: ");
    double k1 = GetUserInput("Введите k1: ");
    double b2 = GetUserInput("Введите b2: ");
    double k2 = GetUserInput("Введите k2: ");


    double dw = (k1 - k2);
    double x = 0;
    if(dw != 0) {
        x = (b1 - b2) / (k1 - k2);  
    } else {
        x = 0;
    }

    x = -x;
    
    double y = k2 * x + b2;
    System.Console.WriteLine($"x = {x}, y = {y}");
}

void Main() {
    PrintCrossCoordinates();
}
Main();