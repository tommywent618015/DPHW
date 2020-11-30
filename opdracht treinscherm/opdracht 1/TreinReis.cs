using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht_1
{
    public class TreinReis : ITreinReis
    {
        private List<TreinStation> stations;
        private int huidigStation;
        List<ITreinDisplay> displays = new List<ITreinDisplay>();
        public TreinReis()
        {
            stations = new List<TreinStation>();
            TreinStation station1 = new TreinStation("haarlem", "B2", new DateTime(2020, 7, 5, 12, 35, 0), new DateTime(2020, 7, 5, 12, 40, 0));
            TreinStation station2 = new TreinStation("heemstede", "A", new DateTime(2020, 7, 5, 12, 50, 0), new DateTime(2020, 7, 5, 12, 52, 0));
            TreinStation station3 = new TreinStation("vogelenzang", "A2", new DateTime(2020, 7, 5, 13, 5, 0), new DateTime(2020, 7, 5, 13, 10, 0));
            TreinStation station4 = new TreinStation("leiden", "C3", new DateTime(2020, 7, 5, 14, 4, 0), new DateTime(2020, 7, 5, 14, 10, 0));
            stations.Add(station1);
            stations.Add(station2);
            stations.Add(station3);
            stations.Add(station4);
            huidigStation = -1;
        }

        public void AddObserver(ITreinDisplay display)
        {
            displays.Add(display);
        }

        public void RemoveObserver(ITreinDisplay display)
        {
            displays.Remove(display);
        }

        public void NotifyObserver(TreinStation station)
        {
            foreach(ITreinDisplay display in displays)
            {
                display.Update(station);
            }
        }

        public void VolgendStation()
        {
            huidigStation++;
            NotifyObserver(stations[huidigStation]);
        }
    }
}
