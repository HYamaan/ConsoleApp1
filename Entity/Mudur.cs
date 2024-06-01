using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Entity;

public class Mudur:CommonProp
{
    [Key]
    public int? MudurId { get; set; }

}