using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CadenceCall : Template
    {
        public static readonly Guid ID = Guid.Parse("e43fcf78-0b8a-4037-a6d0-ad5885474f8c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cadence Call",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2c169a55-4a4e-499a-a21a-44e3ab73a10a"), Type = TextBlockType.Text, Text = $"You call out a quick cadence, guiding your allies into a more efficient rhythm. Each willing ally within your marshal's aura is quickened until the end of their next turn, and they can use the extra action only to {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}. At the end of each ally's turn, if they used the extra action, they then become slowed 1 until the end of their following turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cbff883e-c675-4cbf-a9cb-8bf86bae1795"), Feats.Instances.MarshalDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Flourish.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ac261b9-5b16-437b-bb4b-b3f8be1ae3b0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
