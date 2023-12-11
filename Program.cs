//11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111
//1----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;
//public class MyClass
//{
//    private char п;
//    public void SetSymbol(char value)
//    {
//        п = value;
//    }
//    public int GetSymbolCode()
//    {
//        return (int)п;
//    }
//    public void PrintSymbolAndCode()
//    {
//        Console.WriteLine($"Символ: {п}\nКод символа: {(int)п}");
//        Console.ReadKey();
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        MyClass myObject = new MyClass();
//        myObject.SetSymbol('F');
//        Console.WriteLine($"Код символа: {myObject.GetSymbolCode()}");
//        myObject.PrintSymbolAndCode();
//    }
//}
//2----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//public class CharacterClass
//{
//    private char startChar;
//    private char endChar;

//    public void SetStartChar(char start)
//    {
//        startChar = start;
//    }

//    public void SetEndChar(char end)
//    {
//        endChar = end;
//    }

//    public void PrintCharacters()
//    {
//        int startCode = (int)startChar;
//        int endCode = (int)endChar;

//        for (int i = startCode; i <= endCode; i++)
//        {
//            char currentChar = (char)i;
//            Console.Write(currentChar + " ");
//            Console.ReadKey();
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        CharacterClass myObject = new CharacterClass();

//        myObject.SetStartChar('A');
//        myObject.SetEndChar('D');

//        myObject.PrintCharacters();
//    }
//}
//3----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//public class MyClass
//{
//    private int number1;
//    private int number2;

//    public MyClass()
//    {
//        number1 = 0;
//        number2 = 0;
//    }

//    public MyClass(int num)
//    {
//        number1 = num;
//        number2 = 0;
//    }

//    public MyClass(int num1, int num2)
//    {
//        number1 = num1;
//        number2 = num2;
//    }

//    public void PrintNumbers()
//    {
//        Console.WriteLine("Number 1: " + number1);
//        Console.WriteLine("Number 2: " + number2);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        MyClass obj1 = new MyClass(); // Создание объекта без передачи аргументов
//        Console.WriteLine("Object 1:");
//        obj1.PrintNumbers();

//        MyClass obj2 = new MyClass(10); // Создание объекта с передачей одного аргумента
//        Console.WriteLine("Object 2:");
//        obj2.PrintNumbers();

//        MyClass obj3 = new MyClass(20, 30); // Создание объекта с передачей двух аргументов
//        Console.WriteLine("Object 3:");
//        obj3.PrintNumbers();
//    }
//}
//4----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//public class MyClass
//{
//    private char charField;
//    private int intField;

//    public MyClass(int intValue, char charValue)
//    {
//        intField = intValue;
//        charField = charValue;
//    }

//    public MyClass(double doubleValue)
//    {
//        intField = (int)(doubleValue % 1 * 100);
//        charField = (char)(int)(doubleValue);
//    }

//    public void PrintValues()
//    {
//        Console.WriteLine("Символьное поле: " + charField);
//        Console.WriteLine("Целочисленное поле: " + intField);
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        MyClass obj1 = new MyClass(12, 'A');
//        obj1.PrintValues();

//        Console.WriteLine();

//        MyClass obj2 = new MyClass(65.1267);
//        obj2.PrintValues();
//    }
//}
//5----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//public class MyClass
//{
//    private int intValue;

//    public MyClass()
//    {
//        intValue = 0;
//    }

//    public MyClass(int value)
//    {
//        if (value > 100)
//        {
//            intValue = 100;
//        }
//        else
//        {
//            intValue = value;
//        }
//    }

//    public void SetValue(int value)
//    {
//        if (value > 100)
//        {
//            intValue = 100;
//        }
//        else
//        {
//            intValue = value;
//        }
//    }

//    public int GetValue()
//    {
//        return intValue;
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        MyClass obj1 = new MyClass();
//        Console.WriteLine("Значение поля после вызова конструктора без аргументов: " + obj1.GetValue());

//        Console.WriteLine();

//        MyClass obj2 = new MyClass(150);
//        Console.WriteLine("Значение поля после вызова конструктора с аргументом 150: " + obj2.GetValue());

//        Console.WriteLine();

//        obj1.SetValue(75);
//        Console.WriteLine("Значение поля после вызова метода SetValue с аргументом 75: " + obj1.GetValue());
//    }
//}
//6----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//public class NumberRange
//{
//    private int max;
//    private int min;

//    public NumberRange()
//    {
//        max = 0;
//        min = 0;
//    }

//    public NumberRange(int value)
//    {
//        max = value;
//        min = value;
//    }

//    public NumberRange(int value1, int value2)
//    {
//        max = Math.Max(value1, value2);
//        min = Math.Min(value1, value2);
//    }

//    public void SetValues(int value)
//    {
//        max = Math.Max(value, max);
//        min = Math.Min(value, min);
//    }

//    public void SetValues(int value1, int value2)
//    {
//        max = Math.Max(value1, value2);
//        min = Math.Min(value1, value2);
//    }

//    public void DisplayValues()
//    {
//        Console.WriteLine("Max: " + max);
//        Console.WriteLine("Min: " + min);
//        Console.ReadKey();
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        NumberRange range = new NumberRange();
//        range.DisplayValues();

//        range.SetValues(10);
//        range.DisplayValues();

//        range.SetValues(5, 15);
//        range.DisplayValues();
//    }
//}
//7----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//public class CharacterText
//{
//    private char charField;
//    private string textField;

//    public void SetValue(char value)
//    {
//        charField = value;
//    }

//    public void SetValue(string value)
//    {
//        textField = value;
//    }

//    public void SetValue(char[] value)
//    {
//        if (value.Length == 1)
//        {
//            charField = value[0];
//        }
//        else
//        {
//            textField = new string(value);
//        }
//    }

//    public void DisplayValues()
//    {
//        Console.WriteLine("Char: " + charField);
//        Console.WriteLine("Text: " + textField);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        CharacterText ct = new CharacterText();
//        ct.DisplayValues();

//        ct.SetValue('A');
//        ct.DisplayValues();

//        ct.SetValue("Hello");
//        ct.DisplayValues();

//        char[] charArray = { 'B', 'C', 'D' };
//        ct.SetValue(charArray);
//        ct.DisplayValues();
//    }
//}
//8----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//public class NumberCounter
//{
//    private static int count = 0;

//    public static void DisplayCount()
//    {
//        Console.WriteLine("Текущее значение счетчика: " + count);
//        count++;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        NumberCounter.DisplayCount(); // Выведет: "Текущее значение счетчика: 0"
//        NumberCounter.DisplayCount(); // Выведет: "Текущее значение счетчика: 1"
//        NumberCounter.DisplayCount(); // Выведет: "Текущее значение счетчика: 2"
//    }
//}
//9----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;

//public class NumberOperations
//{
//    public static int FindMax(params int[] numbers)
//    {
//        if (numbers.Length == 0)
//        {
//            throw new ArgumentException("No numbers provided.");
//        }

//        int max = numbers[0];
//        for (int i = 1; i < numbers.Length; i++)
//        {
//            if (numbers[i] > max)
//            {
//                max = numbers[i];
//            }
//        }

//        return max;
//    }

//    public static int FindMin(params int[] numbers)
//    {
//        if (numbers.Length == 0)
//        {
//            throw new ArgumentException("No numbers provided.");
//        }

//        int min = numbers[0];
//        for (int i = 1; i < numbers.Length; i++)
//        {
//            if (numbers[i] < min)
//            {
//                min = numbers[i];
//            }
//        }

//        return min;
//    }

//    public static double FindAverage(params int[] numbers)
//    {
//        if (numbers.Length == 0)
//        {
//            throw new ArgumentException("No numbers provided.");
//        }

//        int sum = 0;
//        foreach (int num in numbers)
//        {
//            sum += num;
//        }

//        return (double)sum / numbers.Length;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = { 10, 5, 15, 8, 12 };

//        int max = NumberOperations.FindMax(numbers);
//        Console.WriteLine("Максимальное значение: " + max); // Выведет: "Максимальное значение: 15"

//        int min = NumberOperations.FindMin(numbers);
//        Console.WriteLine("Минимальное значение: " + min); // Выведет: "Минимальное значение: 5"

//        double average = NumberOperations.FindAverage(numbers);
//        Console.WriteLine("Среднее значение: " + average); // Выведет: "Среднее значение: 10"
//    }
//}
//22222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222
//1----------------------------------------------------------------------------------------------------------------------------------------------------
//using System;
//class Program
//{
//    static string InsertSpaces(string text)
//    {
//        string result = "";
//        foreach (char c in text)
//        {
//            result += c + "";
//        }
//        return result;
//    }
//    static void Main(string[] args);
//}
//2----------------------------------------------------------------------------------------------------------------------------------------------------

//3----------------------------------------------------------------------------------------------------------------------------------------------------

//4----------------------------------------------------------------------------------------------------------------------------------------------------

//5----------------------------------------------------------------------------------------------------------------------------------------------------

//6----------------------------------------------------------------------------------------------------------------------------------------------------

//7----------------------------------------------------------------------------------------------------------------------------------------------------

//8----------------------------------------------------------------------------------------------------------------------------------------------------

//9----------------------------------------------------------------------------------------------------------------------------------------------------

//10----------------------------------------------------------------------------------------------------------------------------------------------------
