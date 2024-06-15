using System.Runtime.CompilerServices;

namespace PTbac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true) // vòng lặp vô hạn
                {
                    double[] arr = new double[3];

                    int index = 0;

                    foreach (double number in arr)
                    {
                        Console.WriteLine($"Nhập giá trị lần lượt cho a, b, c");

                        arr[index] = double.Parse(Console.ReadLine());
                        index++;
                    }
                    PTbac2 PT2 = new PTbac2(arr[0], arr[1], arr[2]);
                    PT2.Cal();
                    Console.WriteLine("Bạn có muốn thực hiện phép toán khác không? Y/N");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() != "y") // chuyển Y từ hoa về thường nếu có
                    {
                        break;// Trả lời bằng khác Y thì dừng chương trình.
                    }


                }

            }
            catch (Exception ex) {
                Console.WriteLine("có lỗi xảy ra {0}", ex.Message);
            }
           
            Console.ReadKey();
        }
    }
}