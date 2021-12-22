using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    //Interface Segregation Principle
   public interface IPrintTasks
    {

        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotocopyContent(string content);
    
    }

    public interface IFaxContent
    {
        bool FaxContent(string content);

    }

    public interface IPrintDuplexContent
    {
     
        bool PrintDuplexContent(string content);
    }
}
