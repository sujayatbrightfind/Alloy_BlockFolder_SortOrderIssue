using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Alloy_BlockFolder_SortOrderIssue.Models;
using Alloy_BlockFolder_SortOrderIssue.Models.Pages;
using System.ComponentModel.DataAnnotations;

namespace Alloy_BlockFolder_SortOrderIssue
{
    [SiteContentType(GUID = "0877D78B-8673-4CF9-9F78-3E50C30C4479",
        GroupName = Alloy_BlockFolder_SortOrderIssue.Global.GroupNames.Specialized,
        DisplayName = "Find GDPR API Demo Page")]
    public class GDPRApiDemoPage : SitePageData, ISearchPage
    {
    }
}
