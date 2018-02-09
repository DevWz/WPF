using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingAsync.Controllers
{
    class Manager
    {
        internal Task<string> AlgoAsync()
        {
            return Task.Run(() => { return "Hellor World"; });
        }
    }
}
