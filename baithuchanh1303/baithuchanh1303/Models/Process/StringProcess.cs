namespace baithuchanh1303.Models.Process
{
    public class StringProcess
    {
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
