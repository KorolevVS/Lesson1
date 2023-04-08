// пишем программу сложения 2-х чисел
// int numberA = 31;
// int numberB = 5;
// int result = numberA + numberB;
// Console.WriteLine(result);


// пигем программу сложения 2 случайно сгенерированных чисел
// new Random().Next (1, 31) - команда генерит случайные числа в диапазоне [min, max-1] или [min, max]
int numberA = new Random().Next (1, 31); // 1 2 3 4 . . . . 30
Console.WriteLine("первое число" + " " + "= " + numberA);
int numberB = new Random().Next (1, 31); // 1 2 3 4 . . . . 30
Console.WriteLine("второе число" + " " + "= " + numberB);
int result = numberA + numberB;
Console.WriteLine("сумма" + " " + "= " + result);

