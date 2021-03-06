﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Variables
{
    class MKQueries
    {
        public static String normalconsultant = "Select top 1 ID from Const..consultants cs join Const..InterConsultants ic on cs.ID=ic.ID where suffix='CA' and status in ('A1', 'A2', 'A3') order by NEWID()";

        public String consultantname = "select fName from const..consultants where suffix='CA' and id=" + "'" + Variables.consultantid + "'";
        //"Select top 1 FirstName from contacts..consultants where consultantid="+"'"+Variables.consultantid+"'";



        public static String queryselector(String queries)
        {
            MKQueries mq = new MKQueries();

            if (queries == "Smoke")
            {
                return normalconsultant;
            }
            else if (queries == "consultantname")
            {
                Console.WriteLine("Query for findingConsultant name for " + Variables.consultantid);
                // return "select FirstName from contacts..consultants where ConsultantSuffix='CA' and consultantid=" + "'" + Variables.consultantid + "'";
                return mq.consultantname;
            }

            else
            {
                MKInstances.cd.AssertFail(null, "No query found");
                return null;
            }

        }
    }
}
