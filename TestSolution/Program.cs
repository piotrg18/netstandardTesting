

using TestLibrary;

namespace NetCoreApp20
{
    public class Program
    {
        public static void Main()
        {
           TestLibrary.TestLibrary l = new TestLibrary.TestLibrary();
           l.Resolve<ClassImpl>("ClassImpl").Display();
           
           
        }
    }
}
