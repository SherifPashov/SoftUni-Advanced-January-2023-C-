using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public string name;
        public int Capacity;

        private List<Child> children;

        public Kindergarten(string name, int capacity)
        {
            this.name = name;
            Capacity = capacity;
            children = new();
        }

        public bool AddChild(Child child)
        {
            if (children.Count==Capacity)
            {
                return false;
            }
            children.Add(child);
            return true;
        }

        public bool RemoveChild(string childFullName)
        {
           
            foreach (Child child in children) 
            {
                if (child.Fullname== childFullName)
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

        public string GetChild(string childFullName)
        {
            foreach (var child in children)
            {
                if (child.Fullname == childFullName)
                {
                    return $"Child: {child.FirstName} {child.LastName}, Age: {child.Age}, Contact info: {child.ParentName}- {child.ContactNumber}";
                }
            }
            return null;
        }

        public string RegistryReport()
        {
            StringBuilder sb= new StringBuilder();

            IEnumerable<Child> childrenSorted = children.OrderByDescending(s => s.Age)
                .ThenBy(s => s.LastName)
                .ThenBy(s => s.FirstName);
            System.Console.WriteLine("Registered children in Space S:");

            foreach (var child in childrenSorted)
            {
                //Child: Greta Thinberg, Age: 3, Contact info: Allen White - 541-754-3010
                sb.AppendLine($"Child: {child.FirstName} {child.LastName}, Age: {child.Age}, Contact info: {child.ParentName} - {child.ContactNumber}");
            }
            return sb.ToString().TrimEnd();
        }

    }
}
