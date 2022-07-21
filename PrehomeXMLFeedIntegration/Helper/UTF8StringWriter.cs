using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrehomeXMLFeedIntegration.Helper
{
    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}
