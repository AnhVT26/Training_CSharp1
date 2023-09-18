using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Menu();
        }
        static void Menu()
        {
            SERVICE sv = new SERVICE(); 
            int chon;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhập");
                Console.WriteLine("2. Xuất");
                Console.WriteLine("3. SV có vé HappyBee");
                Console.WriteLine("4. Xóa sv không tham gia HappyBee");
                Console.WriteLine("5. Kế thừa");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("Mời chọn chức năng: ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1: sv.Nhap();
                        break;
                    case 2:sv.Xuat();
                        break;
                    case 3:List<SinhVien> aa = sv.YesHappyBee();
                        foreach (var item in aa)
                        {
                            item.InThongTin();
                        }
                        break;
                    case 4:sv.NoHappyBee();
                        break;
                    case 5:sv.KeThua();
                        break;
                    case 0:
                        Console.WriteLine("Nhấn phím bất kì để thoát");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("lại\n");
                        break;
                }
            } while (chon!=0);   
        }
    }
}
