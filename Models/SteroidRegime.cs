using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Models
{

    public class SteroidRegime
{
    public int RegimeId { get; set; }
    public TimeSpan Time { get; set; }
    public string? Dose { get; set; }

    public string? Period { get; set; }


}
}
