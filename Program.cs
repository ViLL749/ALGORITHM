namespace project
{
    class Program
    {
        static void Main() {
            int a, b, c, v;
            Console.WriteLine("Выберите вариант выполняемого задания:\n1 - нахождение площади равнобедренного треугольника по его сторонам;\n2 - нахождение периметра равнобедренного треугольника по его сторонам;\n3 - нахождение углов альфа и бета равнобедренного треугольника по его сторонам.");
            v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стороны треугольника (a - боковые стороны, b - основание)");
            Console.WriteLine("Введите a: ");
            // a = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Введите b: ");
            // b = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Введите c: ");
            // c = Convert.ToInt32(Console.ReadLine());
            if (v == 1)
            {
                double h, s;
                h = 0.5 * Math.Sqrt(4 * Math.Pow(a, 2) - Math.Pow(b, 2));
                s = 0.5 * b * h;
                Console.WriteLine($"Площадь: {Math.Round(h, 2)}");
            }
            else if (v == 2)
            {
                int p;
                p = 2 * a + b;
                Console.WriteLine($"Периметр: {p}");
            }
            else if 
             (v == 3)
             {
                 
                // double angle_alpha, angle_beta, angle_gamma;
                // double cos_alpha, angel_alpha, angel_beta;
                // cos_alpha = (Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b);  
                // Console.WriteLine(cos_alpha);
                // angel_alpha = Math.Cos(cos_alpha) * 57.2958;
                // angel_beta = 180 - angel_alpha * 2;
                // Console.WriteLine($"Угол альфа: {Math.Round(angel_alpha, 2)}\n Угол бета: {Math.Round(angel_beta, 2)}");
             }
        }
    }
}