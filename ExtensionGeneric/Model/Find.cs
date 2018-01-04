using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionGeneric.Model
{
    public static class Find
    {
        public static T FindBy<T>(this IRepository repo, string breed, DataBase db) where T : class, IEntityBreed
        {
            var items = db.GetTable<T>();
            var item = items.FirstOrDefault(it => it.Breed.Equals(breed));
            return item;
        } 
    }
}
