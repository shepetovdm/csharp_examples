using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Building
    {
        public int Floors; //этажи
        public int Area; //общая площадь здания
        public int Occupants; //количество жильцов

        public Building(int f, int a, int o)
        {
            Floors = f;
            Area = a;
            Occupants = o;
        }

        public int AreaPerPerson() 
        {
            return (Area / Occupants);            
        }

        public int MaxOccupants(int minArea)
        {
            return (Area / minArea);
        }

    }

}
