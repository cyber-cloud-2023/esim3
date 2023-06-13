using Microsoft.AspNetCore.Mvc;

namespace mywebapi.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{

    [HttpGet()]
    public List<Book> Get()
    {
        Book objectBook = new Book();

        return objectBook.GetAllBooks();
    }

    [HttpGet("{id}")]
    public Book GetOne(int id)
    {
        Book objectBook = new Book();
        return objectBook.GetOneBook(id);
    }
    [HttpPost()]
    public string Add()
    {
        return "Tämä lisää uuden kirjan";
    }
    [HttpPut("{id}")]
    public string Update(int id)
    {
        return "Tämä päivittää kirjan, jonka id = " + id;
    }
    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return "Tämä poistaa kirjan, jonka id = " + id;
    }
}
