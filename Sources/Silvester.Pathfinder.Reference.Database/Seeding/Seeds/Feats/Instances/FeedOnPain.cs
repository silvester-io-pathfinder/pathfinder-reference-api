using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FeedOnPain : Template
    {
        public static readonly Guid ID = Guid.Parse("902ac682-e455-4540-a0c6-95a7c67922b5");

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
            yield return new TextBlock { Id = Guid.Parse("d9a602ff-4854-463f-9b17-43cfa601efb0"), Type = TextBlockType.Text, Text = "The psychic feedback of another creature’s pain fills you with false life. You gain temporary Hit Points equal to half the mental damage you dealt from the triggering effect. If the triggering action dealt mental damage to multiple creatures, calculate these temporary Hit Points using the creature that took the most damage. You lose any remaining temporary Hit Points after 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8475d2d9-7ce1-42d6-b56c-b19091934c7d"), Feats.Instances.Adhyabhau.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("092f0853-9bd7-4f90-b159-5f13567248d3"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
