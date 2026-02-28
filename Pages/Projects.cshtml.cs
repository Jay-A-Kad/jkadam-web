
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace jkadam_web.Pages;

public class ProjectsModel : PageModel
{
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string codeAvail { get; set; } = "";

    //project video 
    public string? VideoUrl { get; set; } = null;
    public List<string> ToolsTags { get; set; } = new();

    //project card buttons
    public string? GitURL { get; set; } = null;
    public string? DemoURL { get; set; } = null;
}
