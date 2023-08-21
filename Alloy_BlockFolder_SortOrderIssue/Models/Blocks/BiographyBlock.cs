using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.ComponentModel.DataAnnotations;

namespace Alloy_BlockFolder_SortOrderIssue.Models.Blocks
{
	[ContentType(DisplayName = "BiographyBlock", 
		GUID = "dab77022-8492-4a09-a3eb-bf9466b59a44", Description = "")]
	public class BiographyBlock : BlockData
	{
        [Searchable]
        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Heading { get; set; }

        [Searchable]
        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content, Order = 20)]
        public virtual string FirstName { get; set; }

        [Searchable]
        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content, Order = 30)]
        public virtual string LastName { get; set; }

        [Searchable]
        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content, Order = 40)]
        public virtual string Credentials { get; set; }

        [Searchable]
        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content, Order = 50)]
        public virtual string JobTitle { get; set; }


        [Searchable]
        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content, Order = 60)]
        public virtual string Email { get; set; }


        [Display(GroupName = SystemTabNames.Content, Order = 70)]
        public virtual string BioLink { get; set; }

        [UIHint(UIHint.Textarea)]
        [Display(GroupName = SystemTabNames.Content, Order = 80)]
        public virtual string Bio { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 90)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
    }
}