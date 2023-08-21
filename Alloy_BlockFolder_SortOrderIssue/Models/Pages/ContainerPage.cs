using Alloy_BlockFolder_SortOrderIssue.Business.Rendering;

namespace Alloy_BlockFolder_SortOrderIssue.Models.Pages
{
    /// <summary>
    /// Used to logically group pages in the page tree
    /// </summary>
    [SiteContentType(
        GUID = "D178950C-D20E-4A46-90BD-5338B2424745",
        GroupName = Global.GroupNames.Specialized)]
    [SiteImageUrl]
    public class ContainerPage : SitePageData, IContainerPage
    {

    }
}
