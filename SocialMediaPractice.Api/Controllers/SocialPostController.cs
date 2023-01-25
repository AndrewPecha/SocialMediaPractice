using Microsoft.AspNetCore.Mvc;

namespace SocialMediaPractice.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SocialPostController : ControllerBase
{
    [HttpPost]
    public string CreateSocialPost(string postString)
    {
        return postString;
    }
}