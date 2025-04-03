using Microsoft.AspNetCore.Mvc;

namespace NetCoreMvcMultiTemplates.ViewComponents
{
    public class NavbarViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return await Task.FromResult<IViewComponentResult>(View("Navbar3"));
        }
    }
}
