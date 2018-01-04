using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionGeneric
{
    public interface IEntityBreed
    {
        string Breed { get; set; }
    }

    public class DataBase
    {
        public List<Roll> RollBreeds { get; set; }
        public List<Boad> BoadBreeds { get; set; }

        public DataBase()
        {
            RollBreeds = new List<Roll>
            {
                new Roll {Breed = "Oak", Width = 450}
            };

            BoadBreeds = new List<Boad>
            {
                new Boad {Breed = "Boad дуб", Length = 300}
            };
        }

        public IList<TEntity> GetTable<TEntity>() where TEntity : class
        {
            if (typeof(TEntity).Name == typeof(Roll).Name)
            {
                return RollBreeds as IList<TEntity>;
            }

            if (typeof(TEntity).Name == typeof(Boad).Name)
            {
                return BoadBreeds as IList<TEntity>;
            }

            return new List<TEntity>();
        }
    }

    public class Roll: IEntityBreed
    {
        public string Breed { get; set; }
        public int Width { get; set; }
    }

    public class Boad: IEntityBreed
    {
        public string Breed { get; set; }
        public double Length { get; set; }
    }
}
