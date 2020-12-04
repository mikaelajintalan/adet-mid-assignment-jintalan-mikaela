using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace adet_mid_assignment_jintalan_mikaela.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string TaskName { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Date Started")]
        [DataType(DataType.Date)]
        public DateTime DateStarted { get; set; }

        [Display(Name = "Date Finished")]
        [DataType(DataType.Date)]
        public DateTime DateFinished { get; set; }

        public int TotalNoOfHours { get; set; }


    }
}