using Microsoft.AspNetCore.Mvc;
using SocialMediaPractice.Application;
using SocialMediaPractice.Application.Models;

namespace SocialMediaPractice.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SocialPostController : ControllerBase
{
    [HttpPost]
    public string CreateSocialPost(string postString)
    {
        var post = new SocialMediaPost();
        post.AddText(postString);
        
        return post.SocialMediaPostText;
    }
}