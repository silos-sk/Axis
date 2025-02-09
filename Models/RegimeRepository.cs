using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Models
{

    public class RegimeRepository
{

        public static List<SteroidRegime> _Regimes =
    [
        new SteroidRegime { RegimeId = 1, Time=new TimeSpan(8, 00, 00), Dose="20 mg", Period="AM" },
        new SteroidRegime { RegimeId = 2, Time=new TimeSpan(12, 00, 00), Dose="10 mg", Period="NN" },
        new SteroidRegime { RegimeId = 3, Time=new TimeSpan(17, 00, 00), Dose="10 mg", Period="PM" },
    ];

    public static List<SteroidRegime> GetRegimes() => _Regimes;

    public static SteroidRegime GetRegimebyId(int RegimeId)
    {
#pragma warning disable CS8603 // Possible null reference return.
            return _Regimes.FirstOrDefault(x => x.RegimeId == RegimeId);
#pragma warning restore CS8603 // Possible null reference return.

        }

    public static void UpdateRegime(int RegimeId, SteroidRegime regime)
    {
        if (RegimeId != regime.RegimeId) return;
        
        var RegimeToUpdate = GetRegimebyId(RegimeId);
        if (RegimeToUpdate != null)
        {
            RegimeToUpdate.Time = regime.Time;
            RegimeToUpdate.Dose = regime.Dose;
            RegimeToUpdate.Period = regime.Period;
        }

}
}
}
