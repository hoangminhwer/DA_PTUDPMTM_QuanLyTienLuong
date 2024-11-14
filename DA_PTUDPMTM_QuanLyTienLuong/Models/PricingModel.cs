using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DA_PTUDPMTM_QuanLyTienLuong.Models
{
    public class PricingModel
    {
        public PlanModel BasicPlan { get; set; }
        public PlanModel AdvancedPlan { get; set; }
        public PlanModel EnterprisePlan { get; set; }
    }
}