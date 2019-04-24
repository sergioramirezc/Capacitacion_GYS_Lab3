using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.App.Views
{

    public class MasterDetailViewMenuItem
    {
        public MasterDetailViewMenuItem()
        {

        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}