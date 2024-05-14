using System;

class Program
{
    public static void Main(string[] args)
    {
        Point myPoint = new Point(0, 0);
        Form myForm = new Form();
        Test1(myPoint, myForm);
        Console.WriteLine(myPoint.X);   // действие было произведено на копии объекта и соответственно не сохранилось
        Console.WriteLine(myForm.Text); // string,obj,class (в отличии от struct) ссылочные, и соответственное передаются как ссылки
                                        // из-за чего значение передаётся в оригинальный объект, но так как не передана ссылка на сам объект
                                        // то присвоение null не проходит

        Test2(ref myPoint, ref myForm);
        Console.WriteLine(myPoint.X);   // передана ссылка на сам объект и соответственно его изменения отражаются на нашем значении
        Console.WriteLine(myForm.Text); // передана ссылка на сам объект и соответственно присвоение его к null с последующей попыткой вызвать метод вызывают ошибку
                                        // null reference exception
    }

    static void Test1(Point p, Form f)
    {
        p.X = 100;
        f.Text = "Hello, World!";
        f = null;
    }

    static void Test2(ref Point p, ref Form f)
    {
        p.X = 200;
        f.Text = "Bye, World!";
        f = null;
    }

    public struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Form
    {
        public String Text { get; set; }
    }
}