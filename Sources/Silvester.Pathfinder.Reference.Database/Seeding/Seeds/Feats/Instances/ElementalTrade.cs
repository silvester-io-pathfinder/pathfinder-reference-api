using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalTrade : Template
    {
        public static readonly Guid ID = Guid.Parse("43d0dc3b-2bd7-4ca0-95a4-d72ebfedb216");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Trade",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8c4fa2e7-6081-467f-bad9-56844278f27c"), Type = TextBlockType.Text, Text = "You have a strong connection with stone and metal. You gain the trained proficiency rank in Crafting. If you would automatically become trained in Crafting (from your background or class, for example), you instead become trained in a skill of your choice. You gain the (feat: Specialty Crafting) skill feat for both Stonemasonry and Blacksmithing." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e1d476f-895c-452c-b876-2b730889435f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
