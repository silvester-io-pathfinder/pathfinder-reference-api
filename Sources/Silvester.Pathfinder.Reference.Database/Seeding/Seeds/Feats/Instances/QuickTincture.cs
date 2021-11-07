using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickTincture : Template
    {
        public static readonly Guid ID = Guid.Parse("a1e82a3a-611c-4e45-997a-a2790a9a1b1f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Tincture",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a6bf0049-063a-4dba-b365-ce6343913b3f"), Type = TextBlockType.Text, Text = "You quickly brew up a short-lived tincture. You create a single alchemical elixir or tool of your level or lower without having to spend the normal monetary cost in alchemical reagents or needing to attempt a Crafting check. This item has the (trait: infused) trait, but it remains potent only until the end of the current turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("788b71a3-3a6c-4045-8584-7d5ac614b251"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
