﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class VolunteerBL
    {//try git
        public static void AddVolunteer(VolunteerDTO volunteer)
        {
        using (SmoothSurfingEntities db = new SmoothSurfingEntities())
            {
                db.volunteer.Add(CONVERTORS.VolunteerConvertor.ConvertVolunteerToDAL(volunteer));
                db.SaveChanges();
            }
        }
    }
}
