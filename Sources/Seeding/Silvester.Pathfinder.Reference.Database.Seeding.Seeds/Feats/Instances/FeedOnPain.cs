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
    public class FeedOnPain : Template
    {
        public static readonly Guid ID = Guid.Parse("c4ad9fd8-cab6-4fac-bf2b-a9d57d4db863");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Feed on Pain",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You deal mental damage.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9ade8d27-4ea7-469d-a2fd-a54abc91c930"), Type = TextBlockType.Text, Text = $"The psychic feedback of another creature's pain fills you with false life. You gain temporary Hit Points equal to half the mental damage you dealt from the triggering effect. If the triggering action dealt mental damage to multiple creatures, calculate these temporary Hit Points using the creature that took the most damage. You lose any remaining temporary Hit Points after 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6c3eef53-180a-4c18-b0cb-b32adb6b2810"), Feats.Instances.Adhyabhau.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Dhampir.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd418867-d2b2-44da-8362-052cdd72d736"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
