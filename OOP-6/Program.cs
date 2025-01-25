using System.ComponentModel.Design;
using System.Drawing;
using OOP_6.Q2;
using OOP_6.Q3;

namespace OOP_6 
{
    internal class Program
    {
        public static Point3D makePoint(string m)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            bool isParsedX = int.TryParse(parts[0], out int x);
            bool isParsedY = int.TryParse(parts[1], out int y);
            bool isParsedZ = int.TryParse(parts[2], out int z);

            if (isParsedX && isParsedY && isParsedZ)
            {
                return new Point3D(x, y, z);
            }
            else
                return new Point3D();
        }
        static void Main(string[] args)
        {

            #region Q1
            //Point3D point1 = new Point3D(10, 10, 10);
            //Console.WriteLine(point1.ToString());
            //Point3D P1 = makePoint("Enter coordinates for P1 (format: X Y Z): ");
            //Point3D P2 = makePoint("Enter coordinates for P2 (format: X Y Z): ");
            //if (P1 == P2)
            //    Console.WriteLine("\nP1 and P2 are equal\n");
            //else
            //    Console.WriteLine("\nP1 and P2 aren't equal\n");

            //// It didnt work becasue it is reference type so it will compare the addreses 

            //Point3D[] pointArr = new Point3D[5] { 
            //    new Point3D(10, 20, 30),
            //    new Point3D(30,10,30), 
            //    new Point3D(40, 50, 60),
            //    new Point3D(2,6,9),
            //    new Point3D(1,0,32)
            //    };
            //Array.Sort(pointArr);
            //for (int i = 0; i < pointArr.Length; i++) {
            //    Console.WriteLine($"{pointArr[i]}");
            //}

            //Console.WriteLine("\nAfter cloning , the new point is :");

            //Point3D cloneP1 = (Point3D)P1.Clone();
            //Console.WriteLine($"new point : {cloneP1.ToString()} with hash code {cloneP1.GetHashCode()}");
            //Console.WriteLine($"old point : {P1.ToString()} with hash code {P1.GetHashCode()}");


            #endregion
            #region Q2
            //int x = 10;
            //int y = 5;
            //Console.WriteLine($"{x} + {y} = {Maths.Add(x, y)}");
            //Console.WriteLine($"{x} - {y} = {Maths.Subtract(x, y)}");
            //Console.WriteLine($"{x} * {y} = {Maths.Multiply(x, y)}");
            //Console.WriteLine($"{x} / {y} = {Maths.Divide(x, y)}");
            #endregion
            #region Q3
            //Console.Write("Enter user type (regular, premium, guest):");
            //string userType = Console.ReadLine();
            //User user;

            //if (userType == "regular")
            //    user = new RegularUser();
            //else if (userType == "premium")
            //    user = new PremiumUser();
            //else
            //    user = new GuestUser();

            //Console.Write("Enter product quantity:");
            //int quantity = int.Parse(Console.ReadLine());
            //Console.Write("Enter product price:");
            //int price = int.Parse(Console.ReadLine());

            //Discount discount = user.GetDiscount();
            //decimal discountAmount = discount?.CalculateDiscount(price, quantity) ?? 0;
            //decimal finalPrice = (price * quantity) - discountAmount;

            //Console.WriteLine($"User Type: {user.Name}");
            //Console.WriteLine($"Discount Applied: {discount?.Name ?? "No Discount"}");
            //Console.WriteLine($"Total Discount: {discountAmount:C}");
            //Console.WriteLine($"Final Price: {finalPrice:C}");




            #endregion


        }
    }   
}
