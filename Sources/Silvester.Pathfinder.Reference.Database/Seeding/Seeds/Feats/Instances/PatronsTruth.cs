using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PatronsTruth : Template
    {
        public static readonly Guid ID = Guid.Parse("7d8df3df-1697-4f1f-8f23-1f094ff54ec1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Patron's Truth",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a01d8911-1650-4c2b-99db-fb382904f8f3"), Type = TextBlockType.Text, Text = "You have mastered the greatest secrets of your patron’s magic and learned a fundamental truth about your patron, even if their identity still remains a mystery. You gain an additional 10th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("7b02a7f5-8847-4ffa-80c2-3ba621f69408"), ClassFeatures.Witches.PatronsGift.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cfa2bcb0-f289-4f2d-9aca-66dcad74db1b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
