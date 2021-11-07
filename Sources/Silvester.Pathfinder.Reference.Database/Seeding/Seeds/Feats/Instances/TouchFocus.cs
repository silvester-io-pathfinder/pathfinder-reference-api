using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TouchFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("38a89406-e0f7-4457-9295-0d69118087f6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Touch Focus",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("58a3daf3-a44a-45ae-8ec9-3bd7a907e7bb"), Type = TextBlockType.Text, Text = "You can redirect a spell&#39;s power through you to deliver it within striking distance. If your next action is to (action: Cast a Spell) with 1 or more targets and a range farther than touch, you can change the range to touch. If the altered spell requires a spell attack roll, you gain a +2 circumstance bonus to the attack. This only allows you to touch a single target with the spell, even if the spell originally affected more than 1 target. After you (action: Cast the Spell | Cast a Spell), you can (action: Disarm), (action: Shove), (action: Trip), or (action: Strike) the target with an unarmed attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("62dfdac6-2c60-493c-87a1-72f19dad628a"), Feats.Instances.SixthPillarDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9785c43d-2805-4568-96dd-6ce781e908d4"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
