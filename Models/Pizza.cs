/* Representação de uma pizza no estoque;
 Utilizado pra passar dados da PI Web e "persistir"
 opções de pizza no rmazenamento de dados
*/

namespace ContosoPizza.Models;

public class Pizza
{
    public int Id {get; set;}
    public string? Name {get; set;}
    public bool IsGlutenFree { get; set;}
}