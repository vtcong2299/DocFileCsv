using System;
using System.Diagnostics;

namespace DocFileCsv
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourceFilePath = @"C:\Users\admin\Documents\HocLapTrinh\LapTrinhGameUnity\CongTapCode\C#\BaiTapCodeGym\DocFileCsv\QuocGia.csv"; // Đường dẫn đến tệp CSV của bạn
            string[] lines = File.ReadAllLines(sourceFilePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(','); // Cắt chuỗi thành các phần tử dựa trên dấu phẩy
                if (parts.Length >= 6) // Đảm bảo có đủ phần tử (IP start, IP end, mã quốc gia, tên quốc gia)
                {
                    string countryCode = parts[4];
                    string countryName = parts[5];
                    Console.WriteLine($"Ma Quoc Gia: {countryCode}, Ten Quoc Gia: {countryName}");
                }
            }

        }
    }
}
