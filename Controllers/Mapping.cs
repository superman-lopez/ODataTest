using AutoMapper;
using ODataTest.Core;

namespace ODataTest.Controllers
{
	public class ODataTestMappingProfile : Profile
	{
		public ODataTestMappingProfile()
		{
			CreateMap<Blog, BlogResource>();
			CreateMap<Post, PostResource>();
		}
	}
}