using Microsoft.EntityFrameworkCore;
using ODataTest.Core;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {

		modelBuilder.Entity<Blog>().HasData(
			new Blog {BlogId = 1, Url = "http://blogs.msdn.com/adonet"},
			new Blog {BlogId = 2, Url = "https://blog.hubspot.com/marketing/beginner-blogger-mistakes"},
			new Blog {BlogId = 3, Url = "https://makeawebsitehub.com/examples-of-blogs/"},
			new Blog {BlogId = 4, Url = "https://www.blogger.com/"},
			new Blog {BlogId = 5, Url = "https://www.forbes.com/sites/robertadams/2017/03/02/top-income-earning-blogs/"},
			new Blog {BlogId = 6, Url = "https://www.lifehack.org/articles/communication/top-10-most-inspirational-bloggers-the-world.html"}
		);

		modelBuilder.Entity<Post>().HasData(
			new Post {PostId = 1, BlogId = 1, Title = "Hello World", Content = "Tip: This application intentionally keeps things simple for clarity. Connection strings should not be stored in the code for production applications. You may also want to split each C# class into its own file."},
			new Post {PostId = 2, BlogId = 1, Title = "Delete the blog", Content = "This installs dotnet ef and the design package which is required to run the command on a project. The migrations command scaffolds a migration to create the initial set of tables for the model. The database update command creates the database and applies the new migration to it."},
			new Post {PostId = 3, BlogId = 2, Title = "EF Core in a web app", Content = "In this tutorial, you create a .NET Core console app that performs data access against a SQLite database using Entity Framework Core. You can follow the tutorial by using Visual Studio on Windows, or by using the .NET Core CLI on Windows, macOS, or Linux."},
			new Post {PostId = 4, BlogId = 2, Title = "Database update", Content = ""},
			new Post {PostId = 5, BlogId = 3, Title = "Database update - Part 2", Content = ""},
			new Post {PostId = 6, BlogId = 4, Title = "Create a new project", Content = ""},
			new Post {PostId = 7, BlogId = 4, Title = "Hello World", Content = ""},
			new Post {PostId = 8, BlogId = 4, Title = "Prerequisites", Content = ""},
			new Post {PostId = 9, BlogId = 5, Title = "Install Entity Framework Core", Content = ""},
			new Post {PostId = 10, BlogId = 5, Title = "Create the model", Content = ""},
			new Post {PostId = 11, BlogId = 6, Title = "Hello World", Content = ""},
			new Post {PostId = 12, BlogId = 6, Title = "Create the database", Content = ""},
			new Post {PostId = 13, BlogId = 6, Title = "Create, read, update & delete", Content = ""}
		);
	}
}