using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerManagement.Utils
{
    public class Utils
    {
        public static byte[] ImageToByteArray(Image image)
        {
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image));
            }

            using (var ms = new MemoryStream())
            {
                // Specify the image format explicitly
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
