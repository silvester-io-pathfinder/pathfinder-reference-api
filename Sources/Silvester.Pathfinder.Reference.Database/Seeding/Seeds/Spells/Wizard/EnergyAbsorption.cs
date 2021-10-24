using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EnergyAbsorption : Template
    {
        public static readonly Guid ID = Guid.Parse("c7149a09-fabf-4ceb-a035-df6dab1f5c92");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Energy Absorption",
                Level = 4,
                Trigger = "An effect would deal acid, cold, electricity, or fire damage to you.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7814c7cb-d635-4d14-87aa-c6a958c29337"), Type = TextBlockType.Text, Text = "You gain resistance 15 to acid, cold, electricity, or fire damage from the triggering effect (one type of your choice). The resistance applies only to the triggering effect’s initial damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ec282049-9dc0-459a-80b1-eb9551b643d5"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6157bc10-bcae-4ecb-96c4-2536cb34a564"), Type = TextBlockType.Text, Text = "The resistance increases by 5." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b51d812f-1073-4adb-834c-07946b87204a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
