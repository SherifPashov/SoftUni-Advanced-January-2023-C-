using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> family;
        public Family()
        {
            this.family = new List<Person>();
        }
        public List<Person> People
        {
            get;
            set;
        }
        public void AddMember(Person person)
        {
            this.family.Add(person);
        }

        public Person GetOldestMember()
        {
            //return this.family.MaxBy(p => p.Age);
            string name = default;
            int age = 0;

            for (int i = 0; i < family.Count; i++)
            {
                if (family[i].Age>age)
                {
                    name = family[i].Name;
                    age = family[i].Age;

                }
            }
            return new Person(name, age);
        }



    }
}
