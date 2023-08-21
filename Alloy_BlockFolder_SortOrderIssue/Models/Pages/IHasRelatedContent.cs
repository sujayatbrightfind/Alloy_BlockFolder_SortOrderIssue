using EPiServer.Core;

namespace Alloy_BlockFolder_SortOrderIssue.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
