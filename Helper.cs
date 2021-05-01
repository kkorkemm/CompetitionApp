using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionApp
{
    using Base;

    class Helper
    {
        public static string WhatTimeOfDay()
        {
            int time = int.Parse(DateTime.Now.ToString("HH"));

            if (4 < time && time <= 11)
            {
                return "Доброе утро, ";
            }
            else if (12 < time && time <= 16)
            {
                return "Добрый день, ";
            }
            else if (17 < time && time <= 23)
            {
                 return "Добрый вечер, ";
            }
            else
            {
                return "Доброй ночи, ";
            }
        }

        public static string WhatDay()
        {
            var compDay = CompetitionDBEntities.currentCompettion;
            string day = "";

            if (compDay.BeginDate > DateTime.Now)
            {
                day = $"C-{(compDay.BeginDate - DateTime.Now).Days}";
            }

            if (compDay.BeginDate <= DateTime.Now)
            {
                if (((DateTime.Now - compDay.BeginDate).Days + 1) > compDay.DaysCount)
                {
                    day = "C+1";
                }
                else
                {
                    day = $"C{(DateTime.Now - compDay.BeginDate).Days + 1}";
                }
            }

            return day;
        }

    }
}
