namespace SocialMediaPractice.Application.Models;

public class SocialMediaPost
{
    public string SocialMediaPostText { get; private set; }
    public string CoolString { get; set; }

    public void AddText(string postString)
    {
        SocialMediaPostText = "your post contains: " + postString;
    }
}