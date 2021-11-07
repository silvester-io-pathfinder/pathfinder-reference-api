using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TouchFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("924db2ab-1030-4cc3-8a54-7da592d8314b");

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
            yield return new TextBlock { Id = Guid.Parse("36708056-87b3-46ab-ac3d-e5a84b23c654"), Type = TextBlockType.Text, Text = "You can redirect a spell&#39;s power through you to deliver it within striking distance. If your next action is to (action: Cast a Spell) with 1 or more targets and a range farther than touch, you can change the range to touch. If the altered spell requires a spell attack roll, you gain a +2 circumstance bonus to the attack. This only allows you to touch a single target with the spell, even if the spell originally affected more than 1 target. After you (action: Cast the Spell | Cast a Spell), you can (action: Disarm), (action: Shove), (action: Trip), or (action: Strike) the target with an unarmed attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7faedc0b-781f-4eb6-873b-295e22bd5cc7"), Feats.Instances.SixthPillarDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1681195-3fd4-4892-b05d-786413c656e0"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
