using Microsoft.AspNetCore.Mvc;

namespace NetCoreMvcMultiTemplates.ViewComponents
{
    public class FooterViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return await Task.FromResult<IViewComponentResult>(View("Footer1"));
        }
    }
}
