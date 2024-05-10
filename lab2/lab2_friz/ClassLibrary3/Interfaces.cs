using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_friz
{
    public interface IDeviceFactory
    {
        ILaptop CreateLaptop();
        INetbook CreateNetbook();
        IEBook CreateEBook();
        ISmartphone CreateSmartphone();
    }

    public interface ILaptop { string GetDescription(); }
    public interface INetbook { string GetDescription(); }
    public interface IEBook { string GetDescription(); }
    public interface ISmartphone { string GetDescription(); }
}
