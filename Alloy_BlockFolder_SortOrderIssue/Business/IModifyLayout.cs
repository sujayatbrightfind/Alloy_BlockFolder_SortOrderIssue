using Alloy_BlockFolder_SortOrderIssue.Models.ViewModels;

namespace Alloy_BlockFolder_SortOrderIssue.Business
{
    /// <summary>
    /// Defines a method which may be invoked by PageContextActionFilter allowing controllers
    /// to modify common layout properties of the view model.
    /// </summary>
    interface IModifyLayout
    {
        void ModifyLayout(LayoutModel layoutModel);
    }
}
