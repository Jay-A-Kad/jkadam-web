using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace jkadam_web.Pages;

public class IndexModel : PageModel
{
    public List<ProjectsModel> Projects { get; set; } = new();
    public void OnGet()
    {
        Projects = new List<ProjectsModel>
        {
            new ProjectsModel{
                Title = "Embodied Conversational Agents for speech",
                Description = "A project that explores the use of embodied conversational agents (ECAs) for speech-based interactions. The project involves designing and implementing ECAs that can engage in natural language conversations with users, providing a more interactive and engaging experience.",
                codeAvail ="closed source",
                VideoUrl = "https://www.youtube.com/embed/9n8Xo2s1l3I",
                ToolsTags = new() {"C#", "Unity","Reallusion CC4", "OpenAi", "Virtual Reality"},
                DemoURL = "https://www.youtube.com/embed/9n8Xo2s1l3I"
            },
             new ProjectsModel{
                Title = "Embodied Conversational Agents for speech",
                Description = "A project that explores the use of embodied conversational agents (ECAs) for speech-based interactions. The project involves designing and implementing ECAs that can engage in natural language conversations with users, providing a more interactive and engaging experience.",
                codeAvail ="closed source",
                VideoUrl = "https://www.youtube.com/embed/9n8Xo2s1l3I",
                ToolsTags = new() {"C#", "Unity","Reallusion CC4", "OpenAi", "Virtual Reality"},
                GitURL = "https://www.youtube.com/embed/9n8Xo2s1l3I",
                DemoURL = "https://www.youtube.com/embed/9n8Xo2s1l3I"
            },

             new ProjectsModel
             {
                 Title = "Embodied Conversational Agents for speech",
                 Description = "A project that explores the use of embodied conversational agents (ECAs) for speech-based interactions. The project involves designing and implementing ECAs that can engage in natural language conversations with users, providing a more interactive and engaging experience.",
                 codeAvail = "closed source",
                 VideoUrl = "https://www.youtube.com/embed/9n8Xo2s1l3I",
                 ToolsTags = new() { "C#", "Unity", "Reallusion CC4", "OpenAi", "Virtual Reality" },
                 GitURL = "https://www.youtube.com/embed/9n8Xo2s1l3I",
                 DemoURL = "https://www.youtube.com/embed/9n8Xo2s1l3I"
             }
        };
    }

}
