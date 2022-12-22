using Microsoft.AspNetCore.Mvc;
using Net5TestApp.Common.Objects;

namespace Net5TestApp.WebUI.Extensions
{
    public static class ControllerExtensions
    {
        public static IActionResult ResponseRedirectAction(this Controller controller, IResponse response, string actionName)
        {
            if (response.ResponseType == ResponseType.NotFound)
                return controller.NotFound();
            return controller.RedirectToAction(actionName);
        }

        public static IActionResult ResponseRedirectAction<T>(this Controller controller, IResponse<T> response, string actionName, string controllerName = "")
        {
            if (response.ResponseType == ResponseType.NotFound)
                return controller.NotFound();
            if (response.ResponseType == ResponseType.ValidationError)
            {
                foreach (var error in response.CustomValidationErrors)
                {
                    controller.ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return controller.View(response.Data);
            }
            if (string.IsNullOrWhiteSpace(controllerName))
            {
                return controller.RedirectToAction(actionName);
            }
            else
            {
                return controller.RedirectToAction(actionName, controllerName);
            }
        }

        public static IActionResult ResponseView<T>(this Controller controller, IResponse<T> response)
        {
            if (response.ResponseType == ResponseType.NotFound)
                return controller.NotFound();
            return controller.View(response.Data);
        }
    }
}