using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharedLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("1979e7ed-7bb2-456d-ae06-5344da8ba542");

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
            yield return new TextBlock { Id = Guid.Parse("c32b4542-9a7e-4858-99c4-e1f84c1d1e50"), Type = TextBlockType.Text, Text = "You are evidence that it’s lucky to travel with a halfling. You can use (feat: Halfling Luck) when an ally within 30 feet fails a skill check or a saving throw to allow the ally to reroll the triggering check instead of you rerolling your own failed check. As usual, your ally must use the new result, even if it’s worse than their first roll. If you have (feat: Guiding Luck), you can’t use (feat: Guiding Luck)’s effect that applies to attack rolls and Perception checks to use Shared Luck to benefit an ally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fa9cb356-ffea-4c2a-93e8-97e84c073a02"), Feats.Instances.HalflingLuck.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6a736f3-510b-4bd8-b019-023ac8ce17c9"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
