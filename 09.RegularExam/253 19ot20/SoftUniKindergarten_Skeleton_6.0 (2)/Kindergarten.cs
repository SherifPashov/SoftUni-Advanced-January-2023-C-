using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public string name;
        public int capacity;

        private List<Child> children;
        public int Capacity { get; set; }
        public string Name { get; set; }

        public Kindergarten(string name, int capacity)
        {
            this.Name = name;
            Capacity = capacity;
            children = new();
        }

        public bool AddChild(Child child)
        {
            if (children.Count < Capacity)
            {
                children.Add(child);
                return true;
            }
            
            return false;
        }

        public bool RemoveChild(string childFullName)
        {
            string[] input = childFullName.Split(" ", System.StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (Child child in children)
            {
                if (child.FirstName == input[0] && child.LastName== input[1])
                {
                    children.Remove(child);
                    return true;
                }
            }
            return false;

        }

        public int ChildrenCount()
        {
            int count = children.Count;
            return count;
        }

        public Child GetChild(string childFullName)
        {

            string[] input = childFullName.Split(" ",System.StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var child in children)
            {
                if (child.FirstName == input[0] && child.LastName == input[1])
                {
                    return child;
                }
            }
            return null;
        }

        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();

            IEnumerable<Child> childrenSorted = children.OrderByDescending(s => s.Age)
                .ThenBy(s => s.LastName)
                .ThenBy(s => s.FirstName);
           

            sb.AppendLine($"Registered children in {Name}:");

            foreach (var child in childrenSorted)
            {
                //Child: Greta Thinberg, Age: 3, Contact info: Allen White - 541-754-3010
                sb.AppendLine(child.ToString().Trim());
            }
            return sb.ToString().Trim();
        }
    }
}
