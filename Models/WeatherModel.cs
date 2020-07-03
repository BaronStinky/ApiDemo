using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTechDemo.Models
{


    public class WeatherModel
    {
        public DayForecastModel[] Consolidated_Weather { get; set; }
        public DateTime Sun_Rise { get; set; }
        public DateTime Sun_Set { get; set; }
        public string Title { get; set; }
        public string Timezone { get; set; }
        public string Weather_State_Name { get; set; }
        public string Applicable_Date { get; set; }
        public float Min_Temp { get; set; }
        public float Max_Temp { get; set; }
    }
}
