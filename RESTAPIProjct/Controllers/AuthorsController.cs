using CourseLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;
using RESTAPIProjct.Helpers;
using RESTAPIProjct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPIProjct.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorsController : ControllerBase
    {
        private readonly ICourseLibraryRepository _courseLibraryRepository;

        public AuthorsController(ICourseLibraryRepository courseLibraryRepository)
        {
            _courseLibraryRepository = courseLibraryRepository ??
                throw new ArgumentNullException(nameof(courseLibraryRepository));
        }
        [HttpGet()]
        public ActionResult<IEnumerable<AuthorDto>> GetAuthors()
        {
            var authorsFromRepo = _courseLibraryRepository.GetAuthors();
            var authors = new List<AuthorDto>();
            foreach (var author in authorsFromRepo)
            {
                authors.Add(new AuthorDto()
                {
                    Id = author.Id, 
                    Name = $"{author.FirstName} {author.LastName}",
                    MainCategory = author.MainCategory, 
                    Age = author.DateOfBirth.GetCurrentAge()
                });
            }

            return Ok(authorsFromRepo);
        }
        //parameter changes so is put between curly braces
        //guid = route constraint to disambigouise between routes. Route will only match with input after authors can be matched to guid
        [HttpGet("{authorId}")]
        public IActionResult GetAuthor(Guid authorId)
        { 
            var authorFromRepo = _courseLibraryRepository.GetAuthor(authorId);

            if (authorFromRepo == null)
            {
                return NotFound();
            }
            return Ok(authorFromRepo);
        }
    }
}
