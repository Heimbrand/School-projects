namespace BdFirstDemo.Entities;

public partial class Country
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Population { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
