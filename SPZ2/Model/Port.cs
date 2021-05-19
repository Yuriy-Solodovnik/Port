using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ2
{ 
    public class Port 
    {
        Random r = new Random();
        string _Name;
        string _Adress;
        int _Ships;
        int _Technique;
        int _Hours;
        int _Workers;
        int _Docks;
        double _TechPrice;
        double _ServiceCost;
        double _Profit=0;
        int _Time = 0;
        public Port (int technique = 200, int docks = 40)
        {
            
            _Technique = technique;
            _Docks = docks;
        }
        public Port()
        {
            _Name = "Морской порт";
            _Adress = $"Станковая {r.Next(1,100)}";

        }
        public Port(Port otherPort)
        {
            _Name = otherPort._Name;
            _Adress = otherPort._Adress;
        }
        public string Name
        {
            get
            {

                return _Name;
            } 
            set
            {
                if (value == "")
                    return;
                        _Name = value;
                    
            }
        }
        public string Adress
        {
            get
            {

                return _Adress;
            }
            set
            {
                if (value == "")
                    return;
                _Adress = value;                
            }
        }
        public int Workers
        {
            get
            {
                return _Workers;
            }
            set
            {
                _Workers = value;
            }
        }
        public double TechPrice
        {
            get
            {
                return _TechPrice;
            }
            set
            {
                _TechPrice = value;
            }
        }
        
        public int Technique
        {
            get
            {
                return _Technique;
            }
            set
            {
                _Technique = value;
            }
        }
        public double ServiceCost { get
            {
                return _ServiceCost;
            } 
            set
            {
                _ServiceCost = value;
            }
        }
        public int Hours
        {
            get
            {
                return _Hours;
            }
            set
            {
                _Hours = value;
            }
        }
        public int Ships
        {
            get
            {
                return _Ships;
            }
            set
            {
                _Ships = value;
            }
        }
        public double Profit
        {
            get
            { 
                return _Profit;
            }
            set
            {
                _Profit = ProfitCount(Ships, ServiceCost);
            }
        }
        public int Docks 
        {
            get
            {
                return _Docks;
            }
            set 
            {
                if (value > _Technique / 5)
                {
                    MessageBox.Show ($"Для такого количества причалов не хватает техники, вы можете добавить {NumderDocks(_Workers,_Technique)} причала-(ов)");
                    _Docks = _Technique / 5;
                }
                else
                    _Docks = value;
            }
        }
        public int Time
        {
            get
            {
                
                return _Time; 
            }
            set
            {
               _Time = TimeCount(_Ships, _Hours);
            }
        }
        int NumderDocks(int workers, int technique)
        { 
            return workers / 15 <= technique / 5 ? workers / 15 : technique / 5;
        }
        int TimeCount (int ships, int hours)
        {
            if (_Docks >= ships)
                return _Hours;
            else
            {
                do
                {
                    _Time += hours;
                    ships -= _Docks;
                }
                while (ships+_Docks> _Docks);
            }
            return _Time;
        }
        double ProfitCount (int ships, double serviceCost)
        {
            return Convert.ToDouble(ships) * serviceCost- _Technique* _TechPrice;
        }
        public static Port operator ++ (Port port)
        {
            return new Port(technique: port._Technique + 5, docks: port._Docks+1);
        }
        public static bool operator >=(Port port1, Port port2)
        {
            return port1._Docks >=port2._Docks;
        }
        public static bool operator <=(Port port1, Port port2)
        {
            return port1._Docks <= port2._Docks;
        }
    }
}
