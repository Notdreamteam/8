using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task19
    {
        public double Latitude { get; }
        public double Longitude { get; }

        public Task19(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public string Hemisphere()
        {
            if ((Latitude >= -90 && Latitude < 0) && (Longitude >= -180 && Longitude < 0)) return "Южно-восточное полушарие";
            else if ((Latitude >= -90 && Latitude < 0) && (Longitude > 0 && Longitude <= 180)) return "Южно-западное полушарие";
            else if ((Latitude > 0 && Latitude <= 180) && (Longitude >= -180 && Longitude < 0)) return "Северо-восточное полушарие";
            else if ((Latitude > 0 && Latitude <= 180) && (Longitude > 0 && Longitude <= 180)) return "Северо-западное полушарие";
            else if ((Latitude == 0) && (Longitude == 0)) return "Экватор";
            else return "Некорректный ввод";
        }
    }
}
