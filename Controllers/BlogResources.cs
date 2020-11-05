using System.Collections.Generic;


namespace ODataTest.Controllers
{
    public class BlogResource
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<PostResource> Posts { get; set; }
    }

    public class PostResource
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }

}