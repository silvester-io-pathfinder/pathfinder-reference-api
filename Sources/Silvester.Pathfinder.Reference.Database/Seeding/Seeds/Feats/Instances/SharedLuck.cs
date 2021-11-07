using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharedLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("a04691dc-9cd9-449f-8991-8a900ff578f3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shared Luck",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("701c8d2e-8fed-4814-8299-6e7a4fead687"), Type = TextBlockType.Text, Text = "You are evidence that it’s lucky to travel with a halfling. You can use (feat: Halfling Luck) when an ally within 30 feet fails a skill check or a saving throw to allow the ally to reroll the triggering check instead of you rerolling your own failed check. As usual, your ally must use the new result, even if it’s worse than their first roll. If you have (feat: Guiding Luck), you can’t use (feat: Guiding Luck)’s effect that applies to attack rolls and Perception checks to use Shared Luck to benefit an ally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4718706f-cf32-42a4-b012-730a5e9268fd"), Feats.Instances.HalflingLuck.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b18a068-a7c7-4856-a9eb-58d387b290b1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
