using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team_27_FinalProject.Models
{

    public class ReportViewModel
    {
        //Drop-down: Properties 
        [Display(Name = "Select Your Property:")]
        public Int32 SelectedPropertyID { get; set; }

        //Textbox: Revenue (exact, min, max, both)
        [Display(Name = "Search by Exact Revenue:")]
        public Decimal? SelectedRevenue { get; set; }
        [Display(Name = "Minimum Revenue")]
        public Decimal? SelectedMinRevenue { get; set; }
        [Display(Name = "Maximum Revenue")]
        public Decimal? SelectedMaxRevenue { get; set; }

        //Textbox: Cleaning (exact, min, max, both)
        [Display(Name = "Search by Exact Cleaning Fee:")]
        public Decimal? SelectedCleaning { get; set; }
        [Display(Name = "Minimum Cleaning")]
        public Decimal? SelectedMinCleaning { get; set; }
        [Display(Name = "Maximum Cleaning")]
        public Decimal? SelectedMaxCleaning { get; set; }

        //Textbox: Earning (exact, min, max, both)
        [Display(Name = "Search by Exact Earning:")]
        public Decimal? SelectedEarning { get; set; }
        [Display(Name = "Minimum Earning")]
        public Decimal? SelectedMinEarning { get; set; }
        [Display(Name = "Maximum Earning")]
        public Decimal? SelectedMaxEarning { get; set; }

        //Date picker: Start Date
        [Display(Name = "Select Start Date:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedStartDate { get; set; }

        //Date picker: End Date (*) 
        [Display(Name = "Select End Date:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedEndDate { get; set; }
    }
    
}
