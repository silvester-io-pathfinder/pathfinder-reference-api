using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SingToTheSteel : Template
    {
        public static readonly Guid ID = Guid.Parse("8ae4ab86-3551-410b-81c8-713d8dafae72");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sing to the Steel",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3a5251de-9b43-4810-8a05-115c1130249d"), Type = TextBlockType.Text, Text = "You strike magical tones that can turn the tide of combat. You and your allies within 30 feet gain the effects of one of the following runes until the end of your next turn: (item: corrosive|Corrosive Runestone), (item: disrupting|Disrupting runestone), (item: flaming|Flaming Runestone), (item: frost|Frost Runestone), (item: ghost touch|Ghost Touch Runestone), (item: shock|Shock Runestone), or (item: thundering|Thundering Runestone). The effects apply to a single weapon the creature is holding or one of the creature&#39;s unarmed attacks. You choose the rune and the effect applies to all creatures. You can use an action, which has the (trait: concentrate) trait, to extend the duration of the rune for 1 additional round up to a maximum of 1 minute. If this would give a weapon or unarmed attack more property runes than its normal maximum, an existing property rune (as the creature chooses) is suppressed until the spell ends." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b2002e69-a77b-426d-a390-924594968e06"), Feats.Instances.NantambuChimeRingerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce86e9c5-49d7-487a-b2e3-6545cecf5bf6"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
