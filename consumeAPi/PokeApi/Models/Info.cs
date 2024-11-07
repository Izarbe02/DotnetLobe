namespace Models;

public class Info{
 
 public int count {get; set;}
 public string next {get; set;}
 public string previous {get; set;} = null;

 public List <Pokemon> results {get; set;}

}