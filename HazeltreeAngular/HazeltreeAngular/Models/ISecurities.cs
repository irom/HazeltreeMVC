using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazeltreeAngular.Models
{
    public interface ISecurities
    {
        IList<Security> Search(string SecurityCode, string SearchText);
    }
}
