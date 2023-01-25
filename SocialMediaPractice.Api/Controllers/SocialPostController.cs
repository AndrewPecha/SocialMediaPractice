using Microsoft.AspNetCore.Mvc;
using SocialMediaPractice.Application;

namespace SocialMediaPractice.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SocialPostController : ControllerBase
{
    [HttpPost]
    public string CreateSocialPost(string postString)
    {
        var handler = new GreetingHandler();
        return handler.CreateGreeting(postString);
    }
}