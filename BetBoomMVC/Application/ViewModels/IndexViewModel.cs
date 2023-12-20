using BetBoomMVC.Domain.Entities;
namespace BetBoomMVC.Application.ViewModels
{
    public class IndexViewModel
    {
       public IEnumerable<SportType> SportTypes { get; set; }
    }
}
