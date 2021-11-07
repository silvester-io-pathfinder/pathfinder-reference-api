using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OtherworldlyAcumenArcane : Template
    {
        public static readonly Guid ID = Guid.Parse("18bc45fd-0283-4e26-a190-31f843c93be0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Otherworldly Acumen - Arcane",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("267b90b3-2eb8-45e3-8faf-b12547faf1f6"), Type = TextBlockType.Text, Text = "Choose one common 2nd-level spell from the arcane tradition." };
            yield return new TextBlock { Id = Guid.Parse("343d8e74-c61d-4699-bc71-6a35bb038df0"), Type = TextBlockType.Text, Text = "You can cast that spell as an innate spell once per day. Your magic is adaptable. By spending 1 day of downtime, you can change the spell you chose to a different common 2nd-level spell from the same tradition." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6203242-be7f-4e3f-b525-7eda39ed7c5f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
