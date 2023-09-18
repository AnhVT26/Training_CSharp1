using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class SERVICE
    {
        List<SinhVien> _lstSinhViens = new List<SinhVien>()
        {
            new SinhVien("ph1","A",2001,6),
            new SinhVien("ph2","B",2002,9),
            new SinhVien("ph3","C",2003,7),
            new SinhVien("ph4","D",1990,9),
            new SinhVien("ph5","E",1999,10)
        };
        SinhVien _sinhVien;
        public virtual void Nhap()
        {
            string tiepTuc;
            do
            {
                _sinhVien = new SinhVien();
                Console.Write("Ma sinh vien: ");
                _sinhVien.MaSV = Console.ReadLine();
                Console.Write("Ten sinh vien: ");
                _sinhVien.Ten = Console.ReadLine();
                Console.Write("Nam sinh: ");
                _sinhVien.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.Write("Diem: ");
                _sinhVien.Diem = Convert.ToDouble(Console.ReadLine());
                _lstSinhViens.Add(_sinhVien);
                Console.WriteLine("Do you want more? (co/khong)");
                tiepTuc = Console.ReadLine();
            } while (tiepTuc.Equals("co"));
        }
        
        public void Xuat()
        {
            if (_lstSinhViens.Count == 0)
            {
                Console.WriteLine("DS trống!!");
            }
            else
            {
                foreach (var item in _lstSinhViens)
                {
                    item.InThongTin();
                }
            }
        }

        public List<SinhVien> YesHappyBee()
        {
            List<SinhVien> lst = _lstSinhViens.Where(x => x.Diem >= 8).ToList();
            if (lst.Count == 0)
            {
                Console.WriteLine("Không tìm được sinh viên nào");
                return lst;
            }
            return lst;
        }
        public void NoHappyBee()
        {
            int cnt = 0;
            Console.WriteLine("DS sv bị xóa");
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].Diem < 8 || (DateTime.Now.Year - _lstSinhViens[i].NamSinh) > 25)
                {
                    _lstSinhViens[i].InThongTin();
                    _lstSinhViens.RemoveAt(i);
                    cnt++;
                }
            }
            if (cnt == 0)
            {
                Console.WriteLine("Không tìm được sv nào");
            }
            Console.WriteLine("DS sau khi xóa");
            Xuat();
        }
        public void KeThua()
        {
            SinhVienUD sv = new SinhVienUD("ph6", "A", 2001, 6, 5);
            SinhVienUD sv2 = new SinhVienUD("ph7", "A", 2001, 6, 11);
            sv.InThongTin();
            sv2.InThongTin();
        }
    }
}
