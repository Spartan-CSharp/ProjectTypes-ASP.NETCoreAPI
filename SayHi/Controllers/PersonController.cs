using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SayHi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonController : ControllerBase
	{
		// GET: api/Person
		[HttpGet]
		public string Get(string firstName, string lastName)
		{
			return $"Hi {firstName} {lastName}!";
		}
	}
}
