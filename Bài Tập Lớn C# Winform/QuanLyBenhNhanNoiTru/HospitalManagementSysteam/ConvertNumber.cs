using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhNhanNoiTru
{
    class ConvertNumber
    {
        // dùng để đọc số tiền trong tài khoản
        private static string[] units = { "", "nghìn", "triệu", "tỷ", "nghìn tỷ", "triệu tỷ", "tỷ tỷ" };
        private static string[] ones = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        private static string[] tens = { "", "", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        private static string[] hundreds = { "", "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };

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
                if (long.TryParse(chunks[i], out long chunkNumber))
                {
                    if (chunkNumber == 0)
                    {
                        continue; // Bỏ qua đoạn có số 0
                    }

                    string chunkText = ConvertChunkToVietnamese(chunkNumber);
                    string unit = units[Math.Min(units.Length - 1, chunks.Count - i - 1)];

                    if (!string.IsNullOrEmpty(chunkText))
                    {
                        if (!string.IsNullOrEmpty(result))
                        {
                            result += " ";
                        }
                        result += chunkText + " " + unit;
                    }
                }
                else
                {
                    // Xử lý khi chuỗi không đúng định dạng số
                    // return hoặc xử lý theo yêu cầu của bạn
                }
            }

            return result;
        }

        private static string ConvertChunkToVietnamese(long chunkNumber)
        {
            string chunkText = "";

            try
            {
                if (chunkNumber < 20)
                {
                    chunkText = ones[(int)chunkNumber];
                }
                else if (chunkNumber < 100)
                {
                    int tensDigit = (int)(chunkNumber / 10);
                    int onesDigit = (int)(chunkNumber % 10);

                    chunkText = tens[tensDigit] + " " + ones[onesDigit];
                }
                else
                {
                    int hundredsDigit = (int)(chunkNumber / 100);
                    int tensDigit = (int)((chunkNumber % 100) / 10);
                    int onesDigit = (int)(chunkNumber % 10);

                    if (hundredsDigit == 0)
                    {
                        chunkText = tens[tensDigit] + " " + ones[onesDigit];
                    }
                    else
                    {
                        chunkText = hundreds[hundredsDigit] + " " + tens[tensDigit] + " " + ones[onesDigit];
                    }
                }
            }
            catch
            {

            }

            return chunkText;
        }

    }
}
