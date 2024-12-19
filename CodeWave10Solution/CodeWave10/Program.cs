
namespace CodeWave10
{
   
    public enum TrafficLight
    {
        Red = 1,
        Yellow,
        Green
    }
    public enum OrderStatus { 
        Pending,
        Processing,
        Shipped
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //-Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.
            Console.WriteLine("*********************************** Problem 01 ***************************************");

            // Passing value type parameters by value:
            // A copy of the original value is passed to the method.
            // Any modifications made to the parameter inside the method do not affect the original value outside the method.
            int Value4 = 0;
            IncremeantByOne(Value4);
            Console.WriteLine($"The value after incremeant(passing by value) is: {Value4}");


            // Passing value type parameters by reference (using the 'ref' or 'out' keywords):
            // In this case, the reference to the original variable is passed to the method, not a copy of its value.
            // Any changes made to the parameter inside the method directly affect the original variable outside the method.
            DecremeantByOne(ref Value4);
            Console.WriteLine($"The value after decremant(passing by ref) is: {Value4}");
            //********************************************************************************************************************************************
            //********************************************************************************************************************************************
            //********************************************************************************************************************************************






            //-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            Console.WriteLine("\n*********************************** Problem 02 ***************************************");

            var employee = new Employee("ahmed" , 20 , 20);

            // Passing reference type parameters by value:
            // In this case, a copy of the reference (address) pointing to the object in the heap is passed to the method.
            // Any modifications made to the object's properties inside the method will affect the original object
            // because both the original and the copied reference point to the same object.
            // However, if the reference itself is reassigned inside the method, the reassignment will not affect the original reference outside the method.
            DoubleSalary(employee);
            Console.WriteLine($"The salary of employee {employee.Name} after double is: {employee.Salary}");// name will not be affected

 
            // Passing reference type parameters by reference (using the 'ref' keyword):
            // In this case, the method receives the actual reference to the object, not a copy of it.
            // This allows the method to modify both the object’s properties and reassign the reference itself.
            // Any changes made to the object or the reference inside the method will be visible to the caller.
            IncreaseSalaryBy20(ref employee);
            Console.WriteLine($"The salary of employee {employee.Name} after increasing by 20% is: {employee.Salary}"); // name will affected too
//********************************************************************************************************************************************
//********************************************************************************************************************************************
//********************************************************************************************************************************************





            //-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            Console.WriteLine("\n*********************************** Problem 03 ***************************************");
            Console.WriteLine($"Test if the number 23 is prime or not: {IsPrime(23)}");
//********************************************************************************************************************************************
//********************************************************************************************************************************************
//********************************************************************************************************************************************




            //-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            Console.WriteLine("\n*********************************** Problem 04 ***************************************");
            int min = 0;
            int max = 0;
            int[] numbers =  { 1, 8, 3, 78, 96, 10 };
            MinMaxArray(numbers, ref min, ref max);
            Console.WriteLine($"The max value in numbers array is:{max}, and the min value is: {min}");
            //********************************************************************************************************************************************
            //********************************************************************************************************************************************
            //********************************************************************************************************************************************







            //-Create an enum called TrafficLight with the following values: Red Yellow Green
            //- Write a C# class that demonstrates the use of the TrafficLight enum.
            Console.WriteLine("\n*********************************** Problem 05 ***************************************");

            TrafficLight CurrentLight = TrafficLight.Yellow;
            Console.WriteLine($"Traffic light is: {CurrentLight} now");

            switch (CurrentLight)
            {
                case TrafficLight.Red:
                    Console.WriteLine("Stop!");
                    break;
                case TrafficLight.Yellow:
                    Console.WriteLine("Caution!");
                    break;

                case TrafficLight.Green:
                    Console.WriteLine("Go!");
                    break;

                default:
                    Console.WriteLine("Invalid traffic light state.");
                    break;
            }
            //********************************************************************************************************************************************
            //********************************************************************************************************************************************
            //********************************************************************************************************************************************

            //Design a real - world scenario using enums.For example, create an enum called OrderStatus with values like: Pending Processing Shipped
            // Delivered-Write a class to simulate the change of an order’s status and print the current status at each step
            Console.WriteLine("\n*********************************** Problem 06 ***************************************");
            Orders order = new Orders();
            Console.WriteLine($"Status of order now is {order.OrderStatus}");
            order.UpdateStatus(OrderStatus.Processing);
        }


        // *************************************  problem 01   *********************************************
        static void IncremeantByOne (int n)
        {
           n++;
        }
        static void DecremeantByOne(ref int n)
        {
            n--;
        }

        // *************************************  problem 02   *********************************************
        static void DoubleSalary(Employee emp)
        {
            emp.Salary *= 2;
            emp = new Employee { Name = "mohamed" }; // this will not affect on the original obj as i reassing address to this obj

        }
        static void IncreaseSalaryBy20(ref Employee emp)
        {
            emp = new Employee { Name = "mohamed", Salary = emp.Salary + emp.Salary * 0.2 }; // this will affect on the original
        }



        // *************************************  problem 03   *********************************************
        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++) // improve performancereduces by reduce the number of iterations, especially for large number
            {
                if (num % i == 0)   
                    return false;
            }
            return true;
        }

        // *************************************  problem 03   *********************************************

        static void MinMaxArray(int[] array ,ref int min  , ref int max)
        {
            min = array[0];
            max = array[0];
            foreach (var item in array)
            {
                if (item > max)
                    max = item;
                if(item < min)
                    min = item;
            }

        }
    }
}
