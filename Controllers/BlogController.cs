﻿using System.Collections.Generic;
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
	// [Route("api/")]
    public class BlogController : ODataController
    {
		private readonly ODataContext dbContext;
		private readonly IMapper mapper;

		public BlogController(ODataContext dbContext, IMapper mapper)
		{
			this.dbContext = dbContext;
			this.mapper = mapper;
		}

		// Blogs specific endpoint
		// [AllowAnonymous]
		[EnableQuery()]
		// [HttpGet("unauthenticated")]
		[HttpGet("Blogs")]
		public IActionResult GetAllResultsUnauthenticated()
		{
			var blogs = dbContext.Blogs
				.AsNoTracking()
				.Include(b => b.Posts);

			// List<BlogResource> blogsResource = mapper.Map<List<Blog>, List<BlogResource>>(blogs);

			return Ok(blogs);
		}

		// [Authorize]
		// [EnableQuery()]
		// [HttpGet("authenticated")]
		// public async Task<IActionResult> GetAllResultsAuthenticated()
		// {
		// 	List<Blog> blogs = await dbContext.Blogs
		// 		.AsNoTracking()
		// 		.Include(b => b.Posts)
		// 		.ToListAsync();

		// 	List<BlogResource> blogsResource = mapper.Map<List<Blog>, List<BlogResource>>(blogs);

		// 	return Ok(blogsResource);
		// }

    }
}
