using System;

namespace CurrencyConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tỉ giá: 1 USD = 23000 VND
            const double TI_GIA = 23000;

            // Nhập giá trị tiền USD từ người dùng
            Console.Write("Nhap vao gia tri $(USD): ");
            double usdAmount = Convert.ToDouble(Console.ReadLine());

            // Tính giá trị tương ứng trong VND
            double vndAmount = usdAmount * TI_GIA;

            // Hiển thị kết quả
            Console.WriteLine("Giia tri VND la: " + vndAmount + " VND");
        }
    }
}
