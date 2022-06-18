using APITecsup.Models.Request;
using APITecsup.Models.Response;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace APITecsup.Controllers
{
    public class PeopleController : ApiController
    {
        // GET: People


        public List<PersonResponse> Get()
        {

            var service = new PersonService();            
            var people = service.Get();

            //Convert Domaint to Response
            var response = people.Select(x => new PersonResponse {
                FullName= string.Concat( x.FirstName, " ", x.LastName )
            }).ToList();

            return response;            
        }
        [HttpPost]
        public bool Insert(PersonRequest request)
        {
            var response = true;
            try
            {
                var service = new PersonService();
                service.Insert(new Domain.Person
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName
                });
            }
            catch (Exception )
            {
                //log ex
                response = false;
            }
            return response;
        }





        //public List<PersonResponse> Get()
        //{
        //    var response= new List<PersonResponse>();
        //    response.Add(new PersonResponse { ID = 1, FirstName = "Hugo", LastName = "Torrico" });
        //    response.Add(new PersonResponse { ID = 2, FirstName = "Juan", LastName = "Torrico" });
        //    response.Add(new PersonResponse { ID = 3, FirstName = "Janeth", LastName = "Torrico" });
        //    return response;
        //}

        //public PersonResponse GetPersonById(int id)
        //{
        //    var list = new List<PersonResponse>();
        //    list.Add(new PersonResponse { ID = 1, FirstName = "Hugo", LastName = "Torrico" });
        //    list.Add(new PersonResponse { ID = 2, FirstName = "Juan", LastName = "Torrico" });
        //    list.Add(new PersonResponse { ID = 3, FirstName = "Janeth", LastName = "Torrico" });
        //    var response = list.Where(x => x.ID == id).FirstOrDefault();
        //    return response;
        //}

        //public List<PersonResponse> GetPeople()
        //{                    
        //    var response = new List<PersonResponse>();
        //    response.Add(new PersonResponse { ID = 1, FirstName = "Hugo", LastName = "Torrico" });            
        //    response.Add(new PersonResponse { ID = 3, FirstName = "Janeth", LastName = "Torrico" });
        //    return response;
        //}
        //[HttpPost]
        //public PersonResponse PostInsert(PersonRequest request)
        //{
        //    var list = new List<PersonResponse>();
        //    list.Add(new PersonResponse { ID = 1, FirstName = "Hugo", LastName = "Torrico" });
        //    list.Add(new PersonResponse { ID = 2, FirstName = "Juan", LastName = "Torrico" });
        //    list.Add(new PersonResponse { ID = 3, FirstName = "Janeth", LastName = "Torrico" });
        //    list.Add(new PersonResponse
        //    {
        //        ID = 4,
        //        FirstName = request.FirstName,
        //        LastName = request.LastName,

        //        FullName = string.Concat(request.FirstName, " ", request.LastName)
        //    });



        //    //Business logic of insert
        //    return list.Where(x=>x.ID==4).FirstOrDefault();
        //}

        //[HttpPut]
        //public PersonResponse Update(PersonRequest request)
        //{
        //    var list = new List<PersonResponse>();
        //    list.Add(new PersonResponse { ID = 1, FirstName = "Hugo", LastName = "Torrico" });
        //    list.Add(new PersonResponse { ID = 2, FirstName = "Juan", LastName = "Torrico" });
        //    list.Add(new PersonResponse { ID = 3, FirstName = "Janeth", LastName = "Torrico" });
        //    list.Add(new PersonResponse
        //    {
        //        ID = 4,
        //        FirstName = request.FirstName,
        //        LastName = request.LastName,

        //        FullName = string.Concat(request.FirstName, " ", request.LastName)
        //    });



        //    //Business logic of insert
        //    return list.Where(x => x.ID == 4).FirstOrDefault();
        //}



        //[HttpGet]
        //public bool  Login(string username, string password)
        //{
        //    return username == "htorrico" && password == "123456";
        //}






    }
}