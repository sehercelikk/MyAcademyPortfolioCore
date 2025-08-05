namespace Portfolio.Web.Entities;

public class Project
{
    public int ProjectId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string GithUbUrl { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
