namespace Bai2
{
    public class QuanLyPhuongTien
    {
        private List<PhuongTien> danhSach = new List<PhuongTien>();

        public void AddPhuongTien(PhuongTien pt)
        {
            if (pt == null)
                throw new ArgumentNullException(nameof(pt));

            danhSach.Add(pt);
        }

        public void DisplayAll()
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách phương tiện trống!");
                return;
            }

            Console.WriteLine("\n===== DANH SÁCH PHƯƠNG TIỆN =====");

            foreach (PhuongTien pt in danhSach)
            {
                Console.WriteLine(pt.GetInfo());
                Console.WriteLine($"Giá lăn bánh: {pt.TinhGiaLanBanh():N0} VNĐ");
                Console.WriteLine("------------------------------------------");
            }
        }

        public PhuongTien FindMaxGiaLanBanh()
        {
            if (danhSach.Count == 0)
                return null;

            PhuongTien max = danhSach[0];

            foreach (PhuongTien pt in danhSach)
            {
                if (pt.TinhGiaLanBanh() > max.TinhGiaLanBanh())
                    max = pt;
            }

            return max;
        }

        public List<PhuongTien> SearchByName(string keyword)
        {
            List<PhuongTien> ketQua = new List<PhuongTien>();

            if (string.IsNullOrWhiteSpace(keyword))
                return ketQua;

            foreach (PhuongTien pt in danhSach)
            {
                if (pt.TenHang.Contains(keyword.Trim(), StringComparison.OrdinalIgnoreCase))
                    ketQua.Add(pt);
            }

            return ketQua;
        }
    }
}