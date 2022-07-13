namespace HazteConTodos;

public class Pokemon
{
    public Guid Id { get; set; }
    public Dictionary<string, string> Name { get; set; }
    public List<string> Type { get; set; }
    public Dictionary<string, int> Base { get; set; }
}