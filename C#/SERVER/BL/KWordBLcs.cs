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
            using (SmoothsurfingEntities db = new SmoothsurfingEntities())
            {
                db.tbKWord.Add(CONVERTORS.TbKWordConvertor.ConvertKWordToDAL(kWord));
                db.SaveChanges();
            }
        }
    }

}
