using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            shoes = new List<Shoe>();
        }

        public string Name { get; set; }
        public int StorageCapacity { get; set; }

        private List<Shoe> shoes;

        public int Count => shoes.Count;
        public string AddShoe(Shoe shoe) 
        {
            if (shoes.Count == StorageCapacity)
            {
                return "No more space in the storage room.";
            }

            shoes.Add(shoe);
            return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
        }

        public int RemoveShoes(string material) 
        {
            int countRemove = 0;
            for (int i = 0; i < shoes.Count; i++)
            {
                if (shoes[i].Material == material)
                {
                    shoes.Remove(shoes[i]);
                    countRemove++;
                    i--;
                }
            }
            return countRemove;
        }

        public Shoe GetShoeBySize(double size)=>shoes.FirstOrDefault(s=>s.Size==size);

        public List<Shoe> GetShoesByType(string type)=>shoes.FindAll(s=>s.Type.ToLower()==type.ToLower());

        public string StockList(double size, string type)
        {
            IEnumerable<Shoe> currShoes = shoes
                .Where(s => s.Size == size && s.Type == type);

            StringBuilder sb = new StringBuilder();

            if (!currShoes.Any())
            {
                return "No matches found!";
            }
            else
            {
                sb.AppendLine($"Stock list for size {size} - {type} shoes:");
            }

            foreach (var shoe in currShoes)
            {
                sb.AppendLine(shoe.ToString());
            }
            return sb.ToString().TrimEnd();
        }


    }
}
