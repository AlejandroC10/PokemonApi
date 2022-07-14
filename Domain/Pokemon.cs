namespace Domain;

public class Pokemon
{
  public int Id { get; set; }

  public Dictionary<string, string> Name { get; set; }

  public List<string> Type { get; set; }

  public Dictionary<string, int> Stats { get; set; }

  public Pokemon(int id, Dictionary<string,string> name, List<string> type, Dictionary<string,int> stats)
  {
    Id = id;
    Name = name;
    Type = type;
    Stats = stats;
  }
}

/*
  {
    "id": 1,
    
    "name": {
      "english": "Bulbasaur",
      "japanese": "フシギダネ",
      "chinese": "妙蛙种子",
      "french": "Bulbizarre"
    },
    
    "type": [
      "Grass",
      "Poison"
    ],
    
    "base": {
      "HP": 45,
      "Attack": 49,
      "Defense": 49,
      "Sp. Attack": 65,
      "Sp. Defense": 65,
      "Speed": 45
    }
*/