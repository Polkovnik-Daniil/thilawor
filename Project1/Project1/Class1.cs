using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project1
{
    //1)
    //1.1)
    class MyClass
    {
        public string Name;
        public byte Age;
        // Создаем параметрический конструктор
        public MyClass(string s, byte b)
        {
            Name = s;
            Age = b;
        }
        public void reWrite()
        {
            Console.WriteLine("Имя: \t\t\t {0}\nВозраст: \t\t {1}", Name, Age);
        }
    }
    class nothing_
    {
        public void nothing()
        {
            Console.WriteLine("nothing: \t");
        }
    }
    class MyClass1
    {
        private string name;
        private string surname;
        public void reWrite()
        {
            Console.WriteLine($"Имя: \t {name}  Фамилия: \t {surname}");
        }
    }
    //1.2)
    class SomeExampleNonStaticClass
    {
        // В следующей строке объявляется статическое поле, которое инициализируется во время выполнения статическим конструктором.
        static double somestaticfield;
        // В следующей строке кода объявлен статический конструктор, который должен инициализировать статическое поле при создании объекта класса либо при обращении к полю.
        static SomeExampleNonStaticClass()// Статический конструктор имеет то же имя , что и класс в котором он определен.
        {
            // Инициализируем статические поля класса.
            somestaticfield = 99.99;
        }
        public void reWrite()
        {
            Console.WriteLine($"Static constructor: \t {somestaticfield} ");
        }
    }
    //1.3)
    class One
    {
        //закрытый конструктор не допускает создания объекта
        private One() { }
        public static double PI = Math.PI;
    }
    //1.4)
    public class Pensioner
    {
        public Pensioner()
        {
            Pension = 90;
        }
        public readonly int Pension;

        public void reWrite()
        {
            Console.WriteLine($"Static constructor: \t {Pension} ");
        }
    }
    //1.5)
    class Calendar1
    {
        public const int Months = 12;
        public void reWrite()
        {
            Console.WriteLine($"Const constructor: \t {Months} ");
        }
    }
    //1.6)
    class Person_
    {
        private string name;
        private string Surname;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                Console.WriteLine($"value name (set,get): \t {name}");

            }
        }
        public string SurName
        {
            get
            {
                return Surname;
            }
            set
            {
                if (value != null)
                {
                    Surname = value;
                    Console.WriteLine($"value surname (set,get): \t {Surname}");

                }
            }
        }
    }
    //1.8)
    public class Student
    {
        static int count = 0;
        public Student()
        {
            count++;
        }
        public void Student_()
        {
            Console.WriteLine($"Number object: \t\t {count}");
        }
        public static void Method()
        {
            Console.WriteLine("Static method");
        }
    }
    //1.9)
    public partial class partic {
        public void move()
        {
            Console.WriteLine("Result partial class: \t");
        }
    }

    class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            // If this and obj do not refer to the same type, then they are not equal.
            if (obj.GetType() != this.GetType()) return false;

            // Return true if  x and y fields match.
            var other = (Point)obj;
            return (this.x == other.x) && (this.y == other.y);
        }

        // Return the XOR of the x and y fields.
        public override int GetHashCode()
        {
            return x ^ y;
        }

        // Return the point's value as a string.
        public override String ToString()
        {
            return $"({x}, {y})";
        }

        // Return a copy of this point object by making a simple field copy.
        public Point Copy()
        {
            return (Point)this.MemberwiseClone();
        }
    }
    public class Money
    {
        public decimal Amount { get; set; }
        public string Unit { get; set; }

        public Money(decimal amount, string unit)
        {
            Amount = amount;
            Unit = unit;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Money m = obj as Money; // возвращает null если объект нельзя привести к типу Money
            if (m as Money == null)
                return false;

            return m.Amount == this.Amount && m.Unit == this.Unit;
        }
    }
    public class Dog
    {
        // Public field.
        public string Breed;

        // Class constructor.
        public Dog(string dogBreed)
        {
            this.Breed = dogBreed;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Dog))
                return false;
            else
                return this.Breed == ((Dog)obj).Breed;
        }

        public override int GetHashCode()
        {
            return this.Breed.GetHashCode();
        }

        public override string ToString()
        {
            return this.Breed;
        }
    }
    class Program
    {
        //1.7)
        static void AddValue(ref int value)
        {
            Console.WriteLine($"value before ref: \t {value}");
            value = 7; // присваиваем новое значение 
            Console.WriteLine($"new value ref: \t\t {value}");
        }
        static void AddValue1(out int value)
        {
            value = 5; // обязательно нужно присвоить значение (если не присвоить будет ошибка компиляции) 
        }

        static void Main(string[] args)
        {
            //1.1)
            nothing_ not = new nothing_();
            not.nothing();
            MyClass ex_;
            MyClass ex = new MyClass("Alexandr", 26);
            ex.reWrite();
            MyClass1 ex1 = new MyClass1();
            ex1.reWrite();
            
            //1.2)
            SomeExampleNonStaticClass exer_1_2 = new SomeExampleNonStaticClass();
            exer_1_2.reWrite();

            //1.3)
            Console.WriteLine($"Static constructor: \t {One.PI}");
            
            //1.4)
            Pensioner pen1 = new Pensioner(); // вызовет первый конструктор. Если вызвать конструктор без параметров компилятор выдаст ошибку, поскольку он не определен и в его реализации нет инициализации поля только для чтения Pensioneer
            pen1.reWrite();
            //Console.WriteLine(Pensioner.pen1); // выводим в консоль значение константы Bonus классаPensioner

            //1.5)
            Calendar1 calen = new Calendar1();
            calen.reWrite();
            //1.6)
            Person_ p = new Person_();
            
            // Устанавливаем свойство - срабатывает блок Set
            // значение "Tom" и есть передаваемое в свойство value
            p.Name = "Tom";
            
            // Получаем значение свойства и присваиваем его переменной - срабатывает блок Get
            string personName = p.Name;
            Console.WriteLine($"properties(get,set): \t {personName}");
            //1.7)
            int price = 7;
            AddValue(ref price);
            AddValue1(out price);

            //1.8)
            Student stud = new Student();
            stud.Student_();
            Student.Method();
            //1.9)
            partic ne1 = new partic();
            ne1.move();
            //1.10)
            Money m1 = new Money(100, "RUR");
            Money m2 = new Money(100, "RUR");
            Money m3 = new Money(100, "USD");
            Money m4 = m1;
            Console.WriteLine(m1.Equals(m2)); // true
            Console.WriteLine(m1.Equals(m3)); // false
            Console.WriteLine(m1 == m2); // false
            Console.WriteLine(m1 == m4); // true
            Console.WriteLine(m1.GetHashCode()); // 456...
            Console.WriteLine(m2.GetHashCode()); // 411...
            
            //1.10.1)
            Dog m1_ = new Dog("Alaskan Malamute");
            Dog m2_ = new Dog("Alaskan Malamute");
            Dog g1 = new Dog("Great Pyrenees");
            Dog g2 = g1;
            Dog d1 = new Dog("Dalmation");
            Dog n1 = null;
            Dog n2 = null;

            Console.WriteLine("null = null: {0}", Object.Equals(n1, n2));
            Console.WriteLine("null Reference Equals null: {0}\n", Object.ReferenceEquals(n1, n2));

            Console.WriteLine("{0} = {1}: {2}", g1, g2, Object.Equals(g1, g2));
            Console.WriteLine("{0} Reference Equals {1}: {2}\n", g1, g2, Object.ReferenceEquals(g1, g2));

            Console.WriteLine("{0} = {1}: {2}", m1_, m2_, Object.Equals(m1_, m2_));
            Console.WriteLine("{0} Reference Equals {1}: {2}\n", m1, m2, Object.ReferenceEquals(m1_, m2_));

            Console.WriteLine("{0} = {1}: {2}", m1_, d1, Object.Equals(m1_, d1));
            Console.WriteLine("{0} Reference Equals {1}: {2}", m1, d1, Object.ReferenceEquals(m1_, d1));

            //2)
            // Construct a Point object.
            var p1 = new Point(1, 2);

            // Make another Point object that is a copy of the first.
            var p2 = p1.Copy();

            // Make another variable that references the first Point object.
            var p3 = p1;

            // The line below displays false because p1 and p2 refer to two different objects.
            Console.WriteLine("The line below displays false because p1 and p2 refer to two different objects.\t" + Object.ReferenceEquals(p1, p2));

            // The line below displays true because p1 and p2 refer to two different objects that have the same value.
            Console.WriteLine("The line below displays true because p1 and p2 refer to two different objects that have the same value.\t" + Object.Equals(p1, p2));

            // The line below displays true because p1 and p3 refer to one object.
            Console.WriteLine("The line below displays true because p1 and p3 refer to one object\t" + Object.ReferenceEquals(p1, p3));

            // The line below displays: p1's value is: (1, 2)
            Console.WriteLine($"p1's value is: \t {p1.ToString()}");


            //4)
            var student = "kaha";
            Console.WriteLine($"var: \t {student}");
            Console.ReadKey();
        }
    }
}