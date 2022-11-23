using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class KWordBLcs
    {
        public static void AddKWord(KWordDTO kWord)
        {
            using (SmoothSurfingEntities db = new SmoothSurfingEntities())
            {
                db.tbKWords.Add(CONVERTORS.TbKWordConvertor.ConvertKWordToDAL(kWord));
                db.SaveChanges();
            }
        }
    }

}
