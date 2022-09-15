
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public  class KeyWordBL
    {
        public static void AddKeyWord(KeyWordDTO KeyWord)
        {
            using (SmoothsurfingEntities db = new SmoothsurfingEntities())
            {
                db.tbKeyWord.Add(CONVERTORS.TdKeyWordConvertor.ConvertTdKeyWordToDAL(KeyWord));
                db.SaveChanges();
            }
        }
        public static string FindKeyWord(string sentance)
        {
            using (SmoothsurfingEntities db = new SmoothsurfingEntities())
            {
                for (int i = 0; i < sentance.Length; i++)

                {
                    if (sentance[i] == db.tbkeyword("select * from tbkeyword"))
                    {
                        
                    }
                }

            }

        }
    }
}
