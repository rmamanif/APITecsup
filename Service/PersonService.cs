using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PersonService
    {

        public List<Person> Get()
        {            
            using (var context = new ExampleContext())
            {
                return context.People.Where(x=>x.IsEnable==true).ToList();
            }       
        }
        public Person GetById(int id)
        {
            using (var context = new ExampleContext())
            {
                return context.People.Find(id);
            }
        }


        public void Insert(Person person)
        {
            using (var context = new ExampleContext())
            {

                person.IsEnable = true;
                person.CreatedON = DateTime.Today;
                context.People.Add(person);
                context.SaveChanges();
            }
        }
    }
}
