using System.Text.RegularExpressions;
namespace baithuchanh2003.Models.Process
{
    public class StringProcess
    {
        //phuong thức nhập mã tự động
        public string AutoGenerateKey ( string strInput )
        {
            string strResult="", numPart="", strPart=""; //khai báo
            numPart=Regex.Match(strInput,@"\d+").Value; //truyền vào dữ liệu tách ra phần số(d) và chữ(D)
            strPart=Regex.Match(strInput,@"\D+").Value;
            int intPart=(Convert.ToInt32(numPart)+1);
            for (int i=0; i<numPart.Length - intPart.ToString().Length;i++)// BỔ SUNG CÁC PHẦN CHỮ SỐ CÒN THIẾU
            {
                strPart +=0;
            }
            strResult=strPart+intPart; //GHÉP CHỮ VÀ SỐ
            return strResult;
        }
        //phuong thuc chuyen chu sang in hoa
        public string LowerToUpper(string strInput)
        {
            //strInput = strInput.ToUpper();
            return (strInput.ToUpper());
        }
        //phuong thuc chuyen chu sang in thuong
        public string UpperToLower(string abc)
        {
            return abc.ToLower();
        }
        public string HelloWord(string fullName)
        {
            return ("Hello " + fullName);
        }
        public int BinhPhuong(int a)
        {
            return a * a;
        }
    }
}
