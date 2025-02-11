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
        new SteroidRegime { RegimeId = 1, Time=new TimeSpan(8, 00, 00), Dose="20 mg", TestTime = TimeSpan.FromHours(9)},
        new SteroidRegime { RegimeId = 2, Time=new TimeSpan(12, 00, 00), Dose="10 mg", TestTime = TimeSpan.FromHours(11,55)},
        new SteroidRegime { RegimeId = 3, Time=new TimeSpan(17, 00, 00), Dose="10 mg",TestTime = TimeSpan.FromHours(16,30)},
    ];
        
        public static List<SteroidRegime> GetRegimes() => _Regimes;

    public void CalcTestTime(int id, TimeSpan time)
    {
        if (id == 1)
        {
            time += TimeSpan.FromHours(1);
        } else if (id == 2)
        {
            time -= TimeSpan.FromMinutes(5);
        } else if (id == 3)
        {
            time -= TimeSpan.FromMinutes(30);
        }
    }

    public static SteroidRegime GetRegimebyId(int RegimeId)
    {
        
        var regime = _Regimes.FirstOrDefault(x => x.RegimeId == RegimeId);

        if (regime != null)
        {
            
            return new SteroidRegime
            {
                RegimeId = regime.RegimeId,
                Time = regime.Time,
                Dose = regime.Dose,
                TestTime = regime.TestTime
            };
        }
        return null;

    }

    public static void UpdateRegime(int RegimeId, SteroidRegime regime)
    {
        if (RegimeId != regime.RegimeId) return;
        
         var RegimeToUpdate = _Regimes.FirstOrDefault(x => x.RegimeId == RegimeId);
        if (RegimeToUpdate != null)
        {
            RegimeToUpdate.Time = regime.Time;
            RegimeToUpdate.Dose = regime.Dose;
            RegimeToUpdate.TestTime = regime.TestTime;
        }
       
}
}
}
