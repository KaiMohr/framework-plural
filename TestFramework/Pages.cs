﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public static class Pages
    {
        public static class HomePage
        {
            static string Url = "http://pluralsight.com";
            private static string PageTitle = "Unlimited Online Developer, IT and Cyber Security Training | Pluralsight";

            public static void Goto()
            {
                Browser.Goto(Url);
            }

            public static bool IsAt()
            {
           return Browser.Title == PageTitle;
            }
        }
    }
}