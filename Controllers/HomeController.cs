using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using budget.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace budget.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string cc,int? act)
        {
            init_grid();

            cc = (!string.IsNullOrEmpty(cc))  ? cc : "000";
            act = (act.HasValue)  ? act.Value : 0;
         
            var dc = new BudgetMVCContext();

            var b1 = from Models.CostCenters d in dc.CostCenters orderby d.CostCenter select d;
            
            string[] years = (from Models.Dashboard d in dc.Dashboard where d.Name.Contains("YearCol") orderby d.Name select d.Value).ToArray();
            string[] Types = (from Models.Dashboard d in dc.Dashboard where d.Name.Contains("TypeCol") orderby d.Name select d.Value).ToArray();

            var c = from b in dc.CostCenters join a in dc.TemplateDetails on b.CostCenter equals a.CostCenter
                    where (!b.Discontinued) && a.Year == "2019"
                    orderby b.CostCenter
                    select new {CostCenter = b.CostCenter, CostCenterName = $@"{b.CostCenter} - {b.CostCenterName}" };
                   
            var alist = from bi in dc.Accounts orderby bi.Account
                        select new {Account = bi.Account, AccountName = $@"{bi.Account} - {bi.AccountDesc}"};

            ViewBag.CostCentersList = new SelectList(c.ToList(), "CostCenter", "CostCenterName",cc);
            ViewBag.AccountsList = new SelectList(alist.ToList(), "Account", "AccountName",act);
            
            IQueryable<Models.vArchiveDataGrid> dg = from Models.vArchiveDataGrid a in dc.vArchiveDataGrid 
                                          where a.CostCenter == cc && a.Account == act
                                          select a;

            ViewBag.years = years;
            ViewBag.Types = Types;

            int col = 1;
            foreach (string year in years) {
              foreach (Models.vArchiveDataGrid d in dg.Where(e => e.Year == year && e.RecordTypeName  == Types[col-1]).ToList())
              {
                Console.WriteLine($@"{col} {year}");
                ViewData[$@"col{col}row1"]  = d.January.ToString("c");
                ViewData[$@"col{col}row2"]  = d.Feburary.ToString("c");
                ViewData[$@"col{col}row3"]  = d.March.ToString("c");
                ViewData[$@"col{col}row4"]  = d.April.ToString("c");
                ViewData[$@"col{col}row5"]  = d.May.ToString("c");
                ViewData[$@"col{col}row6"]  = d.June.ToString("c");
                ViewData[$@"col{col}row7"]  = d.July.ToString("c");
                ViewData[$@"col{col}row8"]  = d.August.ToString("c");
                ViewData[$@"col{col}row9"]  = d.September.ToString("c"); 
                ViewData[$@"col{col}row10"] = d.October.ToString("c");
                ViewData[$@"col{col}row11"] = d.November.ToString("c"); 
                ViewData[$@"col{col}row12"] = d.December.ToString("c");
              }
              col+=1;
            }
           
            return View();
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        void init_grid(){
          ViewBag.col1row1 = "$0.00";        
          ViewBag.col2row1 = "$0.00";
          ViewBag.col3row1 = "$0.00";          
          ViewBag.col4row1 = "$0.00";
          ViewBag.col5row1 = "$0.00";
          ViewBag.col6row1 = "$0.00";
          ViewBag.col1row2 = "$0.00";
          ViewBag.col2row2 = "$0.00";
          ViewBag.col3row2 = "$0.00";
          ViewBag.col4row2 = "$0.00";
          ViewBag.col5row2 = "$0.00";
          ViewBag.col6row2 = "$0.00";
          ViewBag.col1row3 = "$0.00";
          ViewBag.col2row3 = "$0.00";
          ViewBag.col3row3 = "$0.00";
          ViewBag.col4row3 = "$0.00";
          ViewBag.col5row3 = "$0.00";
          ViewBag.col6row3 = "$0.00";
          ViewBag.col1row4 = "$0.00";
          ViewBag.col2row4 = "$0.00";
          ViewBag.col3row4 = "$0.00";
          ViewBag.col4row4 = "$0.00";
          ViewBag.col5row4 = "$0.00";
          ViewBag.col6row4 = "$0.00";
          ViewBag.col1row5 = "$0.00";
          ViewBag.col2row5 = "$0.00";
          ViewBag.col3row5 = "$0.00";
          ViewBag.col4row5 = "$0.00";
          ViewBag.col5row5 = "$0.00";
          ViewBag.col6row5 = "$0.00";
          ViewBag.col1row6 = "$0.00";
          ViewBag.col2row6 = "$0.00";
          ViewBag.col3row6 = "$0.00";
          ViewBag.col4row6 = "$0.00";
          ViewBag.col5row6 = "$0.00";
          ViewBag.col6row6 = "$0.00";
          ViewBag.col1row7 = "$0.00";
          ViewBag.col2row7 = "$0.00";
          ViewBag.col3row7 = "$0.00";
          ViewBag.col4row7 = "$0.00";
          ViewBag.col5row7 = "$0.00";
          ViewBag.col6row7 = "$0.00";
          ViewBag.col1row8 = "$0.00";
          ViewBag.col2row8 = "$0.00";
          ViewBag.col3row8 = "$0.00";
          ViewBag.col4row8 = "$0.00";
          ViewBag.col5row8 = "$0.00";
          ViewBag.col6row8 = "$0.00";
          ViewBag.col1row9 = "$0.00";
          ViewBag.col2row9 = "$0.00";
          ViewBag.col3row9 = "$0.00";
          ViewBag.col4row9 = "$0.00";
          ViewBag.col5row9 = "$0.00";
          ViewBag.col6row9 = "$0.00";
          ViewBag.col1row10 = "$0.00";
          ViewBag.col2row10 = "$0.00";
          ViewBag.col3row10 = "$0.00";
          ViewBag.col4row10 = "$0.00";
          ViewBag.col5row10 = "$0.00";
          ViewBag.col6row10 = "$0.00";
          ViewBag.col1row11 = "$0.00";
          ViewBag.col2row11 = "$0.00";
          ViewBag.col3row11 = "$0.00";
          ViewBag.col4row11 = "$0.00";
          ViewBag.col5row11 = "$0.00";
          ViewBag.col6row11 = "$0.00";
          ViewBag.col1row12 = "$0.00";
          ViewBag.col2row12 = "$0.00";
          ViewBag.col3row12 = "$0.00";
          ViewBag.col4row12 = "$0.00";
          ViewBag.col5row12 = "$0.00";
          ViewBag.col6row12 = "$0.00";
          
        }
    }
}
