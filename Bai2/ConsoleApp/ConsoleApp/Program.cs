namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            QuanLyPhuongTien quanLy = new QuanLyPhuongTien();

            Console.WriteLine("===== HE THONG QUAN LY PHUONG TIEN =====");

            try
            {
                OTo oTo1 = new OTo("OT001", "Toyota", 2024, 1000000000m, 5, 2.0);
                XeMay xeMay1 = new XeMay("XM001", "Honda", 2023, 50000000m, 150);

                quanLy.AddPhuongTien(oTo1);
                quanLy.AddPhuongTien(xeMay1);

                Console.WriteLine("\n===== DANH SACH PHUONG TIEN =====");
                quanLy.DisplayAll();

                Console.WriteLine("\n===== TIM PHUONG TIEN CO GIA LAN BANH CAO NHAT =====");

                PhuongTien max = quanLy.FindMaxGiaLanBanh();

                if (max != null)
                    Console.WriteLine($"Phương tiện: {max.TenHang} | Giá lăn bánh: {max.TinhGiaLanBanh():N0} VNĐ");

                Console.WriteLine("\n===== TIM KIEM THEO TEN HANG =====");
                Console.Write("Nhập tên hãng cần tìm: ");
                string keyword = Console.ReadLine();

                List<PhuongTien> ketQua = quanLy.SearchByName(keyword);

                if (ketQua.Count == 0)
                    Console.WriteLine("Không tìm thấy phương tiện!");
                else
                {
                    foreach (PhuongTien pt in ketQua)
                        Console.WriteLine($"{pt.GetInfo()} | Giá lăn bánh: {pt.TinhGiaLanBanh():N0} VNĐ");
                }

                Console.WriteLine("\n===== TC01 - VALIDATION NAM SAN XUAT =====");

                try
                {
                    OTo oToLoi = new OTo("OT002", "Ford", 1850, 800000000m, 5, 2.0);
                    Console.WriteLine("TC01: FAIL");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"TC01: PASS - {ex.Message}");
                }

                Console.WriteLine("\n===== TC02 - TINH GIA LAN BANH OTO =====");
                Console.WriteLine($"TC02: Giá lăn bánh ô tô 5 chỗ = {oTo1.TinhGiaLanBanh():N0} VNĐ");

                Console.WriteLine("\n===== TC03 - TINH GIA LAN BANH XE MAY =====");
                Console.WriteLine($"TC03: Giá lăn bánh xe máy 150cc = {xeMay1.TinhGiaLanBanh():N0} VNĐ");

                Console.WriteLine("\n===== TC04 - DA HINH LIST<PHUONGTIEN> =====");

                List<PhuongTien> danhSachTest = new List<PhuongTien>();
                danhSachTest.Add(oTo1);
                danhSachTest.Add(xeMay1);

                foreach (PhuongTien pt in danhSachTest)
                    Console.WriteLine($"TC04: {pt.GetType().Name} -> {pt.TinhGiaLanBanh():N0} VNĐ");

                Console.WriteLine("\n===== TC05 - TIM GIA LAN BANH MAX =====");

                PhuongTien maxTest = quanLy.FindMaxGiaLanBanh();

                if (maxTest != null)
                    Console.WriteLine($"TC05: {maxTest.GetType().Name} {maxTest.TenHang} -> {maxTest.TinhGiaLanBanh():N0} VNĐ");

                Console.WriteLine("\n===== KET THUC KIEM THU =====");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }

            Console.WriteLine("Nhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }
    }
}