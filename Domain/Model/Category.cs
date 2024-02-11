namespace Domain.Model;

public class Category
{
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }
    public Category(int categoryid,string categoryname)
    {
        CategoryId=categoryid;
        CategoryName=categoryname;
    }

}
