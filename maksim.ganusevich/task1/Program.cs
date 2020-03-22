using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1 = 0, side2 = 0, side3 = 0, area =0, perimeter=0, angle1=0, angle2 = 0, angle3 = 0, bigRadius=0, smallRadius = 0,
                height1=0, height2 = 0, height3 = 0, bisektrix1=0, bisektrix2 = 0, bisektrix3 = 0, median1=0, median2 = 0, median3 = 0,
                dopangle1=0, dopangle2 = 0, dopangle3 = 0;


            Console.WriteLine("Ведите периметр и 2 угла в градусах через пробел");
            perimeter = Convert.ToDouble(Console.ReadLine());
            angle1 = Convert.ToDouble(Console.ReadLine());
            angle2 = Convert.ToDouble(Console.ReadLine());
            angle3 = 180 - angle2 - angle1;
            dopangle1 = angle1 * 0.5 + angle2;
            dopangle2 = angle2 * 0.5 + angle3;
            dopangle3 = angle3 * 0.5 + angle1;
            angle1 *= (Math.PI / 180);
            angle2 *= (Math.PI / 180);
            angle3 *= (Math.PI / 180);
            dopangle1 *= (Math.PI / 180);
            dopangle2 *= (Math.PI / 180);
            dopangle3 *= (Math.PI / 180);
            bigRadius = perimeter / (2 * (Math.Sin(angle1) + Math.Sin(angle2) + Math.Sin(angle3)));
            side1 = 2 * bigRadius * Math.Sin(angle1);
            side2 = 2 * bigRadius * Math.Sin(angle2);
            side3 = 2 * bigRadius * Math.Sin(angle3);
            area = 0.5 * Math.Sin(angle3) * side1 * side2;
            smallRadius = area / (0.5 * perimeter);
            height1 = area * 2 / side1;
            height2 = area * 2 / side2;
            height3 = area * 2 / side3;
            median1 = Math.Sqrt(Math.Pow(0.5 * side1, 2) + Math.Pow(side2, 2) - side1 * side2 * Math.Cos(angle3));
            median2 = Math.Sqrt(Math.Pow(0.5 * side2, 2) + Math.Pow(side3, 2) - side2 * side3 * Math.Cos(angle1));
            median3 = Math.Sqrt(Math.Pow(0.5 * side3, 2) + Math.Pow(side1, 2) - side3 * side1 * Math.Cos(angle2));
            bisektrix1 = side2 * Math.Sin(angle3) / Math.Sin(dopangle1);
            bisektrix2 = side3 * Math.Sin(angle1) / Math.Sin(dopangle2);
            bisektrix3 = side1 * Math.Sin(angle2) / Math.Sin(dopangle3);
            Console.WriteLine($"angle1 = {angle1}");
            Console.WriteLine($"angle2 = {angle2}");
            Console.WriteLine($"angle3 = {angle3}");
            Console.WriteLine($"area = {area}");
            Console.WriteLine($"perimeter = {perimeter}");
            Console.WriteLine($"side1 = {side1}");
            Console.WriteLine($"side2 = {side2}");
            Console.WriteLine($"side3 = {side3}");
            Console.WriteLine($"bigRadius = {bigRadius}");
            Console.WriteLine($"smallRadius = {smallRadius}");
            Console.WriteLine($"median1 = {median1}");
            Console.WriteLine($"median2 = {median2}");
            Console.WriteLine($"median3 = {median3}");
            Console.WriteLine($"height1 = {height1}");
            Console.WriteLine($"height2 = {height2}");
            Console.WriteLine($"height3 = {height3}");
            Console.WriteLine($"bisektrix1 = {bisektrix1}");
            Console.WriteLine($"bisektrix2 = {bisektrix2}");
            Console.WriteLine($"bisektrix3 = {bisektrix3}");
        }
    }
}