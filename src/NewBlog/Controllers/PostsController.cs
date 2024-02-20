using Microsoft.AspNetCore.Mvc;
using NewBlog.Data;
using NewBlog.Entities;


namespace NewBlog.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PostsController(NewBlogDbContext context) : ControllerBase
{
    private readonly NewBlogDbContext _context = context;

    // GET: api/<PostsController>
    [HttpGet]
    public ActionResult<List<Post>> Get()
    {
        var posts = _context.Posts.ToList();

        return Ok(posts);
    }

    // GET api/<PostsController>/5
    [HttpGet("{id}")]
    public ActionResult<Post> Get(int id)
    {
        var post = _context.Posts.Find(id);

        return Ok(post);
    }

    // POST api/<PostsController>
    [HttpPost]
    public void Post(Post post)
    {
        _context.Posts.Add(post);
        _context.SaveChanges();
    }

    // PUT api/<PostsController>/5
    [HttpPut("{id}")]
    public void Put(int id, Post post)
    {
        var model = _context.Posts.Find(id);

        model.Title = post.Title;
        model.Description = post.Description;
        model.AuthorId = post.AuthorId;

        _context.Posts.Update(post);
        _context.SaveChanges();
    }

    // DELETE api/<PostsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        var post = _context.Posts.Find(id);

        _context.Posts.Remove(post);
        _context.SaveChanges();
    }
}
