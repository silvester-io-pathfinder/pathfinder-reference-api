using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OverwhelmingEnergy : Template
    {
        public static readonly Guid ID = Guid.Parse("34ab0183-ba3c-4457-b47f-2656b34944b4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overwhelming Energy",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4a28528e-2f30-4239-a1be-b21f0872ef3a"), Type = TextBlockType.Text, Text = "With a complex gesture, you call upon the primal power of your spell to overcome enemies’ resistances. If the next action you use is to (activity: Cast a Spell), the spell ignores an amount of the target’s resistance to acid, cold, electricity, fire, or sonic damage equal to your level. This applies to all damage the spell deals, including persistent damage and damage caused by an ongoing effect of the spell, such as the wall created by (Spell: wall of fire). A creature’s immunities are unaffected." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("918220bf-7fe4-4479-91d3-402496b00727"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
