using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ODataTest.Core;
using ODataTest.Persistence;

namespace ODataTest.Controllers
{
    [ApiController]
	[Route("api/")]
    public class BlogController : ControllerBase
    {
		private readonly ODataContext dbContext;
		private readonly IMapper mapper;

		public BlogController(ODataContext dbContext, IMapper mapper)
		{
			this.dbContext = dbContext;
			this.mapper = mapper;
		}

		// [AllowAnonymous]
		[EnableQuery()]
		[HttpGet("unauthenticated")]
		public async Task<IActionResult> GetAllResultsUnauthenticated()
		{
			List<Blog> blogs = await dbContext.Blogs
				.AsNoTracking()
				.Include(b => b.Posts)
				.ToListAsync();

			List<BlogResource> blogsResource = mapper.Map<List<Blog>, List<BlogResource>>(blogs);

			return Ok(blogsResource);
		}

		// [Authorize]
		[EnableQuery()]
		[HttpGet("authenticated")]
		public async Task<IActionResult> GetAllResultsAuthenticated()
		{
			List<Blog> blogs = await dbContext.Blogs
				.AsNoTracking()
				.Include(b => b.Posts)
				.ToListAsync();

			List<BlogResource> blogsResource = mapper.Map<List<Blog>, List<BlogResource>>(blogs);

			return Ok(blogsResource);
		}

    }
}
