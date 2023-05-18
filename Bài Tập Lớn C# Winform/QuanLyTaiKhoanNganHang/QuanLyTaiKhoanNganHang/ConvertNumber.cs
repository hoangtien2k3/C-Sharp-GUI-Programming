using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoanNganHang
{
    class ConvertNumber
    {

        // dùng để đọc số tiền trong tài khoản
        private static string[] units = { "", "nghìn", "triệu", "tỷ", "nghìn tỷ", "triệu tỷ", "tỷ tỷ" };
        private static string[] ones = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        private static string[] tens = { "", "", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        private static string[] hundreds = { "", "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };

        /*static void Main(string[] args)
        {
            Console.WriteLine("Nhập một số nguyên lớn: ");
            string number = Console.ReadLine();

            string result = ConvertNumberToVietnamese(number);
            Console.WriteLine("Cách đọc tiếng Việt của số {0} là: {1}", number, result);
        }*/

        public static string ConvertNumberToVietnamese(string number)
        {
            string result = "";

            // Chia số thành các đoạn 3 chữ số
            List<string> chunks = new List<string>();
            while (number.Length > 0)
            {
                int chunkLength = Math.Min(3, number.Length);
                string chunk = number.Substring(number.Length - chunkLength);
                number = number.Remove(number.Length - chunkLength);

                chunks.Insert(0, chunk);
            }

            // Đọc từng đoạn 3 chữ số
            for (int i = 0; i < chunks.Count; i++)
            {
                int chunkNumber = int.Parse(chunks[i]);

                if (chunkNumber == 0)
                {
                    continue; // Bỏ qua đoạn có số 0
                }

                string chunkText = ConvertChunkToVietnamese(chunkNumber);
                string unit = units[chunks.Count - i - 1];

                if (!string.IsNullOrEmpty(chunkText))
                {
                    if (!string.IsNullOrEmpty(result))
                    {
                        result += " ";
                    }
                    result += chunkText + " " + unit;
                }
            }

            return result;
        }

        static string ConvertChunkToVietnamese(int chunkNumber)
        {
            string chunkText = "";

            if (chunkNumber < 20)
            {
                chunkText = ones[chunkNumber];
            }
            else if (chunkNumber < 100)
            {
                int tensDigit = chunkNumber / 10;
                int onesDigit = chunkNumber % 10;

                chunkText = tens[tensDigit] + " " + ones[onesDigit];
            }
            else
            {
                int hundredsDigit = chunkNumber / 100;
                int tensDigit = (chunkNumber % 100) / 10;
                int onesDigit = chunkNumber % 10;

                chunkText = hundreds[hundredsDigit] + " " + tens[tensDigit] + " " + ones[onesDigit];
                // Xử lý trường hợp số hàng trăm là 0
                if (hundredsDigit == 0)
                {
                    chunkText = tens[tensDigit] + " " + ones[onesDigit];
                }
                else
                {
                    chunkText = hundreds[hundredsDigit] + " " + tens[tensDigit] + " " + ones[onesDigit];
                }
            }

            return chunkText;
        }

    }
}
