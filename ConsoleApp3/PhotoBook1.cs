using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class PhotoBookTest
    {
        public static void Main()
        {
            PhotoBook1 myAlbum1 = new PhotoBook1();
            Console.WriteLine(myAlbum1.GetNumberPages());

            PhotoBook1 myAlbum2 = new PhotoBook1(24);
            Console.WriteLine(myAlbum2.GetNumberPages());

            SuperPhotoBook myBigPhotoAlbum1 = new SuperPhotoBook();
            Console.WriteLine(myBigPhotoAlbum1.GetNumberPages());
        }
    }
    public class PhotoBook1
    {
        protected int numPages;

        public PhotoBook1()
        {
            numPages = 16;
        }

        public PhotoBook1(int numPages)
        {
            this.numPages = numPages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }

    public class SuperPhotoBook : PhotoBook1
    {
        public SuperPhotoBook()
        {
            numPages = 64;
        }

    }
}
