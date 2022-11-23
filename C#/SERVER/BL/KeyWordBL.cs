
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BL
{
  public  class KeyWordBL
    {
        public static void AddKeyWord(KeyWordDTO KeyWord)
        {
            using (SmoothSurfingEntities db = new SmoothSurfingEntities())
            {
                db.tbKeyWord.Add(CONVERTORS.TdKeyWordConvertor.ConvertTdKeyWordToDAL(KeyWord));
                db.SaveChanges();
            }
        }
        public static List<tbKWord> GetAllKeyWords()
        {
            using (SmoothSurfingEntities db = new SmoothSurfingEntities())
            {


                return db.tbKWord.Include(k=>k.actio).ToList();

            }

        }

        public static List<string> Search(string searchText)
        {
            var allWords = GetAllKeyWords();
            var searchWords= searchText.Split(' ').ToList();
            var searchKeyWords = allWords.Where(w=>searchWords.Any(s=>s==w.name));
            //todo Change senid to macro FK
            //return searchKeyWords.SelectMany(sk => sk.tbKeyWord).Select(w => w.sen_id.ToString()).ToList();
            return searchKeyWords.SelectMany(sw => sw.action).Select(w => w.macro.ToString()).ToList();

        }
    }
}
