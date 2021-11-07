using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DenierOfDestruction : Template
    {
        public static readonly Guid ID = Guid.Parse("6dbd25aa-78f3-4022-b746-1f4ba37c2f9a");

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
            yield return new TextBlock { Id = Guid.Parse("e3879c19-b54b-4297-bed6-743cdf51b926"), Type = TextBlockType.Text, Text = "You can manipulate the same energies that the aeon orbs use to sustain life. You cast (spell: heal) on the triggering target. Instead of its normal effects, the (spell: heal) spell reduces the triggering damage by an amount equal to the Hit Points a 1-action (spell: heal) spell of that level would have recovered. As usual, if this reduces the damage to 0, it might also remove additional effects of the triggering attack, such as (trait: injury) poisons." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("506378c6-6f42-459a-bbf6-557a768c19cb"), DivineFonts.Instances.Heal.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2402e46-7a1e-4a82-9d90-274a304fae85"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
