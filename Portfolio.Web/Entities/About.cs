namespace Portfolio.Web.Entities;

public class About
{
    public int AboutId { get; set; }
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime BirthDate { get; set; }
    public string Github { get; set; }
    public string City { get; set; }
    public string Mail { get; set; }
    public bool IsAvailable { get; set; }
}
