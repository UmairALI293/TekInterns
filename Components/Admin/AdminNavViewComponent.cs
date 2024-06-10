using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TekInternsRecord.Components.Admin
{
    public class AdminNavViewComponent : ViewComponent
    {
        public string Label { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }

        public string Area { get; set; }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<AdminNavViewComponent> navItems = new List<AdminNavViewComponent>
            {
                new AdminNavViewComponent { Label = "Admin", Action = "Index", Controller = "Home",  Area= "Admin"},
                new AdminNavViewComponent { Label = "User", Action = "Index", Controller = "Home", Area = "User"},
            };

            return View(navItems);
        }
    }
}
