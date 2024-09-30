using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod();

        public void PublicMethod()
        {
            Console.WriteLine("Public Method Called");
            SamplePartialMethod();
        }
    }
}
