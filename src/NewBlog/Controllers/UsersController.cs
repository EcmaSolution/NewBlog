using Microsoft.AspNetCore.Mvc;
using NewBlog.Data;
using NewBlog.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewBlog.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsersController(NewBlogDbContext context) : ControllerBase
{
    private readonly NewBlogDbContext _context = context;

    // GET: api/<UsersController>
    [HttpGet]
    public ActionResult<List<User>> Get()
    {
        var users = _context.Users.ToList();

        return Ok(users);
    }

    // GET api/<UsersController>/5
    [HttpGet("{id}")]
    public ActionResult<User> Get(int id)
    {
        var user = _context.Users.Find(id);

        return Ok(user);
    }

    // POST api/<UsersController>
    [HttpPost]
    public void Post(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    // PUT api/<UsersController>/5
    [HttpPut("{id}")]
    public void Put(int id, User user)
    {
        var model = _context.Users.Find(id);

        model.Email = user.Email;
        _context.Users.Update(model);
        _context.SaveChanges();
    }

    // DELETE api/<UsersController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        var user = _context.Users.Find(id);
        _context.Users.Remove(user);
        _context.SaveChanges();
    }
}
