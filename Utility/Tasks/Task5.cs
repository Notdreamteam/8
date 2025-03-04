using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task5
    {
        private int _nm;

        public Task5(int month)
        {
            _nm = month;
        }

        public string Month()
        {
            if (_nm >= 3 && _nm <= 5) return "Весна";
            else if (_nm >= 6 && _nm <= 8) return "Лето";
            else if (_nm >= 9 && _nm <= 11) return "Осень";
            else if (_nm > 12 && _nm < 1) return "Некорректный ввод";
            else return "Зима";
        }
    }
}
