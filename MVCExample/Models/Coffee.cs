namespace MVCExample.Models;

public class Coffee
{
	public string Title { get; set; }
	public string Description { get; set; }
	public string[] Ingredients { get; set; }
	public string Image { get; set; }
	public decimal Price { get; set; }
	public int Id { get; set; }
	public int TotalSales { get; set; }
}
