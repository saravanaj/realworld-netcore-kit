using System;
using System.Collections.Generic;
using Sandbox.Server.DomainObjects.Models.Abstract;

namespace Sandbox.Server.DomainObjects.Models
{
  public class Person : Entity
  {
    public string Username { get; set; }
    
    public string Email { get; set; }

    public string Bio {get;set;}

    public string Image {get;set;}

    public List<Article> Favorites {get;set;}

    public List<Person> Following {get;set;}

    public string Hash {get;set;}

    public string Salt {get;set;}
  }
}