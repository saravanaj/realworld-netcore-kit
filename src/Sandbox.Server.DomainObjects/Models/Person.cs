using System.Collections.Generic;
using Sandbox.Server.DomainObjects.Models.Abstract;

namespace Sandbox.Server.DomainObjects.Models
{
  public class Person : Entity
  {
    public string username { get; set; }
    
    public string email { get; set; }

    public string bio {get;set;}

    public string image {get;set;}

    public List<Article> favorites {get;set;}

    public List<Person> following {get;set;}

    public string hash {get;set;}

    public string salt {get;set;}
  }
}