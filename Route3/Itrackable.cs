using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route3
{
    public interface ITrackable
    {
        string Name { get; set; }
        Point Location { get; set; }
        int calculated { get; set; }
    }
}
