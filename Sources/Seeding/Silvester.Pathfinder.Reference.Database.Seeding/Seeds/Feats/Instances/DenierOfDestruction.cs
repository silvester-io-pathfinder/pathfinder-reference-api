using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DenierOfDestruction : Template
    {
        public static readonly Guid ID = Guid.Parse("f0f74966-91fd-4894-9bdb-38837ef86e68");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Denier of Destruction",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Any ally within 30 feet that you can heal with your heal spell would take damage from an attack or effect from a source you can observe.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6868ff88-f0c6-4bf4-9c55-edc6a5878352"), Type = TextBlockType.Text, Text = "You can manipulate the same energies that the aeon orbs use to sustain life. You cast (spell: heal) on the triggering target. Instead of its normal effects, the (spell: heal) spell reduces the triggering damage by an amount equal to the Hit Points a 1-action (spell: heal) spell of that level would have recovered. As usual, if this reduces the damage to 0, it might also remove additional effects of the triggering attack, such as (trait: injury) poisons." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("92edd6c5-6690-4833-a8c2-23a3c3e90bd3"), DivineFonts.Instances.Heal.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("36285801-b36d-4aa1-ac94-ea5d5cb97b54"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
