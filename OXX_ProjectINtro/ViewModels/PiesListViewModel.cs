using OXX_ProjectINtro.Models;
using System.Collections.Generic;

namespace OXX_ProjectINtro.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
