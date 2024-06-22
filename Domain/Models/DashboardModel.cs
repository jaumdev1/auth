using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class DashboardModel
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public DashboardStats Stats { get; set; }
    }

}
