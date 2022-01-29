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
    public class SplendidCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("f273efa1-a5e8-4654-b48a-1cd45d4c695d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Splendid Companion",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b18ecf35-dc5c-403e-9216-6c0053dae84b"), Type = TextBlockType.Text, Text = $"Your animal companion continues to develop. It becomes a nimble or savage animal companion (your choice), gaining abilities determined by its type. Increase its proficiency rank in Performance to master instead of Athletics or Acrobatics." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b5e083d7-d05b-4f6f-b655-6bfc87515e76"), Feats.Instances.MatureTrainedCompanion.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("eb2371b0-764b-4121-8bef-1087b5fb8660"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27132b63-164e-4999-817b-77824f506dda"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
