using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;

namespace Reading_Sql
{
    public class DataReader
    {
        public byte[] ConvertToByte(string path)
        {
            var bytes = File.ReadAllBytes(path);
            return bytes;
        }

        public void ConvertToImage(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                using (var fs = new FileStream("savePath", FileMode.Create))
                {
                    ms.WriteTo(fs);
                }
            }
        }
    }
}
