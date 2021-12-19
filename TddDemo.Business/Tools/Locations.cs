using System.Collections.Generic;
using TddDemo.Entities;

namespace TddDemo.Business
{
    public class Locations
    {
        public List<Region> RegionsGenerate()
        {
            return new List<Region>
            {
                new Region{Name="Благоевград",minValues= 0,maxValues= 43 },
                new Region{Name="Бургас",minValues= 44, maxValues=93},
                new Region{Name="Варна", minValues=94, maxValues=139},
                new Region{Name="Велико Търново", minValues=140, maxValues=169},
                new Region{Name="Видин", minValues=170,maxValues=183},
                new Region{Name="Враца", minValues=184, maxValues=217},
                new Region{Name="Габрово", minValues=218, maxValues=233},
                new Region{Name="Кърджали",minValues= 234, maxValues=281},
                new Region{Name="Кюстендил",minValues= 282, maxValues=301},
                new Region{Name="Ловеч", minValues=302, maxValues=319},
                new Region{Name="Монтана",minValues= 320,maxValues= 341},
                new Region{Name="Пазарджик",minValues= 342,maxValues= 377},
                new Region{Name="Перник",minValues= 378,maxValues= 395},
                new Region{Name="Плевен", minValues=396,maxValues= 435},
                new Region{Name="Пловдив", minValues=436,maxValues= 501},
                new Region{Name="Разград",minValues=  502, maxValues=527},
                new Region{Name="Русе",minValues= 528,maxValues= 555},
                new Region{Name="Силистра", minValues=556,maxValues= 575},
                new Region{Name="Сливен",minValues=  576,maxValues= 601},
                new Region{Name="Смолян", minValues=602,maxValues= 623},
                new Region{Name="София - град", minValues=624, maxValues=721},
                new Region{Name="София - окръг",minValues= 722, maxValues=751},
                new Region{Name="Стара Загора",minValues= 752, maxValues=789},
                new Region{Name="Добрич",minValues= 790,maxValues= 821},
                new Region{Name="Търговище",minValues= 822, maxValues=843},
                new Region{Name="Хасково",minValues= 844,maxValues= 871},
                new Region{Name="Шумен",minValues= 872,maxValues= 903},
                new Region{Name="Ямбол",minValues= 904, maxValues=925},
                new Region{Name="Друг",minValues= 926,maxValues= 999}
            };
           
        }

    }
}
