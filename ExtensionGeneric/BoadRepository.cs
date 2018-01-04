using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExtensionGeneric
{
    using Model;

    public interface IRepository
    {
        
    }

    public class BoadRepository: IRepository
    {
        private DataBase _db;

        public BoadRepository()
        {
            _db = new DataBase();
        }

        public T GetByBreed<T>(string breed) where T: class, IEntityBreed
        {
            var fb = this.FindBy<T>(breed, _db);
            return fb;
        }
    }
}
