////1

//using System;
//using System.Xml.Linq;
//class Program
//{
//    static void Main(string[] args)
//    {
//        //Animal animal1 = new Animal("Max", "Labrador", "Qara", 3);
//        //Console.WriteLine(animal1.GetInfo());
//        //Building building = new Building("Ayhan", 200, 70, "bakixanov");
//        //Console.WriteLine(building.GetInfo());
//        int[] homeworkGrades = { 90, 85, 95 };
//        int[] projectGrades = { 80, 75 };
//        int[] quizGrades = { 70, 85, 90 };
//        int finalGrade = 85;
//        bool[] continuity = { true, true, false, true };

//        Student student = new Student("Ayhan", "Qasimli", 18, homeworkGrades, projectGrades, quizGrades, finalGrade, continuity);

//        string netice = student.GetOverallGrade();
//        Console.WriteLine("Netice: " + netice);
        //}
        //        Gun assaultGun = new Gun("AK-47", 30, 90, 0, "assault");
        //        assaultGun.PrintStatus();
        //        assaultGun.Fire();
        //        assaultGun.PrintStatus();
        //        assaultGun.Reload();
        //        assaultGun.PrintStatus();

        //        Gun sniperGun = new Gun("AWP", 5, 10, 0, "sniper");
        //        sniperGun.PrintStatus();
        //        sniperGun.Fire();
        //        //        sniperGun.PrintStatus();
        //         Calculator calculator = new Calculator();

        //        Console.WriteLine("Enter first number:");
        //        double num1 = Convert.ToDouble(Console.ReadLine());

        //        Console.WriteLine("Enter second number:");
        //        double num2 = Convert.ToDouble(Console.ReadLine());

        //        Console.WriteLine("Choose operation (+, -, *, /):");
        //        char operation = Convert.ToChar(Console.ReadLine());

        //        double result = 0;

        //        switch (operation)
        //        {
        //            case '+':
        //                result = calculator.Add(num1, num2);
        //                break;
        //            case '-':
        //                result = calculator.Subtract(num1, num2);
        //                break;
        //            case '*':
        //                result = calculator.Multiply(num1, num2);
        //                break;
        //            case '/':
        //                result = calculator.Divide(num1, num2);
        //                break;
        //            default:
        //                Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
        //                break;
        //        }

        //        Console.WriteLine("Result: " + result);
//    }
//}
//class Animal
//{
//    public string Name;
//    public string Breed;
//    public string Color;
//    public int Age;

//    public Animal(string name, string breed, string color, int age)
//    {
//        Name = name;
//        Breed = breed;
//        Color = color;
//        Age = age;
//    }

//    public string GetInfo()
//    {
//        return $"Ad: {Name}, Cins: {Breed}, Rəng: {Color}, Yaş: {Age}";
//    }
//}



//2

//class Building
//{
//    public string name;
//    public int height;
//    public int area;
//    public string address;

//    public Building(string name, int height, int area, string address)
//    {
//        this.name = name;
//        this.height = height;
//        this.area = area;
//        this.address = address;
//    }

//    public string GetInfo()
//    {
//        int volume = height * area;
//        return $"Ad:{name} , Hundurluk:{height} , Area{area} , Adres:{address} , Hecm:{volume} ";
//    }

//}




//3




//class Student
//    {
//        public string name;
//        public string surname;
//        public int age;
//        public int[] homeworkGrades;
//        public int[] projectGrades;
//        public int[] quizGrades;
//        public int FinalGrade;
//        public bool[] continuity;
//        public Student(string name, string surname, int age, int[] homeworkGrades, int[] projectGrades, int[] quizGrades, int finalGrade, bool[] continuity)
//        {
//            this.name = name;
//            this.surname = surname;
//            this.age = age;
//            this.homeworkGrades = homeworkGrades;
//            this.projectGrades = projectGrades;
//            this.quizGrades = quizGrades;
//            FinalGrade = finalGrade;
//            this.continuity = continuity;
//        }
//        public string GetOverallGrade()
//        {
//            double totalGrade = 0;
//            foreach (var grade in homeworkGrades)
//            {
//                totalGrade += grade;
//            }
//            foreach (var grade in projectGrades)
//            {
//                totalGrade += grade;
//            }
//            foreach (var grade in quizGrades)
//            {
//                totalGrade += grade;
//            }
//            totalGrade += FinalGrade;
//            foreach (var cont in continuity)
//            {
//                if (cont)
//                    totalGrade += 1;
//            }
//            double totalPercentage = (totalGrade / ((homeworkGrades.Length + projectGrades.Length + quizGrades.Length) * 100 + 100)) * 100;
//            if (totalPercentage >= 95)
//            {
//                return "HighHonour";
//            }
//            else if (totalPercentage >= 85)
//            {
//                return "Honour";
//            }
//            else if (totalPercentage >= 65)
//            {
//                return "Normal";
//            }
//            else
//            {
//                return "Fail";
//            }
//        }
//    }



//4


//class Gun
//{
//    public string name;
//    public int maxCapacity;
//    public int currentBullet;
//    public int totalBullet;
//    public string type;
//    public Gun(string name, int maxCapacity, int currentBullet, int totalBullet, string type)
//    {
//        this.name = name;
//        this.maxCapacity = maxCapacity;
//        this.currentBullet = currentBullet;
//        this.totalBullet = totalBullet;
//        this.type = type;
//        if (currentBullet > maxCapacity) ;
//        {
//            Console.WriteLine("Bu mumkun ola bilmez");
//        }

//    }
//    public void Fire()
//    {

//        if (type == "assault")

//        {
//            Console.WriteLine("Butun gulleler ateslensin");
//        }
//        else if (type == "sniper")

//        {
//            Console.WriteLine("Bir gulle ateslensin");
//        }
//    }
//    public void Reload()
//    {

//        int bulletsNeeded = maxCapacity - currentBullet;
//        if (bulletsNeeded <= totalBullet)
//        {
//            totalBullet -= bulletsNeeded;
//            currentBullet = maxCapacity;
//            Console.WriteLine("Reload ele");
//        }
//        else
//        {
//            Console.WriteLine("Ehtiyyac yoxdur");
//        }
//    }
//    public void PrintStatus()
//    {
//        Console.WriteLine($"adi: {name}, Gullelerin hal hazirda olan sayi: {currentBullet}, Gullerin umumi sayi:{totalBullet}, Novu {type}");
//    }
//}



//5

//class Calculator
//{
//    public double Add(double num1, double num2)
//    {
//        return num1 + num2;
//    }

//    public double Subtract(double num1, double num2)
//    {
//        return num1 - num2;
//    }

//    public double Multiply(double num1, double num2)
//    {
//        return num1 * num2;
//    }

//    public double Divide(double num1, double num2)
//    {
//        if (num2 == 0)
//        {
//            Console.WriteLine("Error: Cannot divide by zero.");
//            return 0;
//        }
//        return num1 / num2;
//    }
//}