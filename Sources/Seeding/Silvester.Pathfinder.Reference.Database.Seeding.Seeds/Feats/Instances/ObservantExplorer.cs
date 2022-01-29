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
    public class ObservantExplorer : Template
    {
        public static readonly Guid ID = Guid.Parse("48881a66-a969-406b-b3c4-f816c5bb5eba");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Observant Explorer",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a00e279-909e-427d-a695-406491fc5d40"), Type = TextBlockType.Text, Text = $"Thanks to the time you've spent wandering through wild and untamed environments, you've gained an intuitive sense about creatures. You sometimes notice them before they attack, or spot them nearby even if they weren't planning on attacking. You can attempt a check to notice hidden creatures attempting to {ToMarkdownLink<Models.Entities.Activity>("Avoid Notice", Activities.Instances.AvoidNotice.ID)} nearby even if you aren't actively {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)} for them. You still need to meet any other requirements to notice a particular creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c7de772f-2e98-4778-9f88-8e0057d9d1c1"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("af6e81c4-4b04-45f7-b2d2-5d7b5da171cc"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c19c375-53b5-4476-ab64-1a38354d4758"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
