using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    public class QuanLy
    {
        private int tongtien;
        public int TongTien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        public QuanLy(int money)
        {
            TongTien = money;
        }

        public int WithDraw(int amount)
        {
            TongTien += amount; 
            return TongTien;
        }
       
        public int Deposit(int amount)
        {
            TongTien -= amount;
            return TongTien;
        }

        public int Balance()
        {
            Console.WriteLine("khoản tiền hiện tại của bạn là {0} : ", TongTien);
            return TongTien;
        }
        public void WithDrawUser()
        {
            Console.WriteLine("xin mời nhập khoảng tiền :     (Ấn Q để quay trở lại menu)");
            String ADDuser = Console.ReadLine();
            int a = 0;
            if (Int32.TryParse(ADDuser, out a))
            {
                WithDraw(a);
                Console.WriteLine(" bạn đã thêm {0} vào trong tài khoản",a);
            }
            else if (ADDuser.ToUpper().Equals("Q"))
            {
                Console.Clear();
                Showmenu();
            }
            else
            {
                Console.WriteLine("lỗi xin mời nhập khoản tiền cần thanh toán");
            }
        }
        public void DepositUser()
        {          
            Console.WriteLine("xin mời nhập khoảng tiền :     (Ấn Q để quay trở lại menu)");
            String ADDuser = Console.ReadLine();
            int a = 0;
            if (Int32.TryParse(ADDuser, out a))
            {
                Deposit(a);
                Console.WriteLine(" bạn đã rút {0} Đồng vào khỏi tài khoản", a);
            }
            else if (ADDuser.ToUpper().Equals("Q"))
            {
                Console.Clear();
                Showmenu();
            }
            else
            {
                Console.WriteLine("lỗi xin mời nhập số tiền hợp lệ");
            }
        }
        public void Showmenu()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("\t bank account management"
                + Environment.NewLine
                +"1. WithDraw"
                +Environment.NewLine
                +"2. Deposit"
                +Environment.NewLine
                +"3. Balance");
            Console.Write("Nhập: ");
            string usercomand = Console.ReadLine();
            Console.Clear();
            int a = 0;
            if(int.TryParse(usercomand, out a))
            {
                switch (a)
                {
                    case 1:
                        Console.WriteLine("you have choose DrawUser on your Account");
                        WithDrawUser();
                        break;
                    case 2:
                        Console.WriteLine("you have choose Deposit on your Account");
                        DepositUser();
                        break;
                    case 3:
                        Console.WriteLine("you have choose Banlance on your Account");
                        Balance();
                        break;
                    default:
                        break;
                }
            }else
            {
                Console.WriteLine("xin mời nhập lại đúng chỉ mục trong menu");
            }
        }
    }
}
