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
    public class VantageShot : Template
    {
        public static readonly Guid ID = Guid.Parse("fc9c90d0-af34-46ac-ac31-ed68910a5c74");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vantage Shot",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9482729f-a116-47e9-92fc-4fc6d8e32516"), Type = TextBlockType.Text, Text = $"You and your spotter take advantage of each other's attacks to momentarily hide and throw your foes off-balance against your follow-up attack. When you successfully make a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a foe, your spotter can use a reaction to attempt a Stealth check against the foe's Perception DC. On a success, the foe is flat-footed against the spotter's next attack before the end of your spotter's next turn. Similarly, when your spotter successfully makes a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a foe, you can use a reaction to attempt a Stealth check against the foe's Perception DC. On a success, the foe is flat-footed against your next attack against them before the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("18087237-4a37-403e-8b61-e9f29ffbd27a"), Feats.Instances.SnipingDuoDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("234336e3-3f3c-4ace-84c7-10a8b9213aec"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
