using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Sorcerer.Instances
{
    public class ElementalBlast : Template
    {
        public static readonly Guid ID = Guid.Parse("a390f67c-f2f5-47f4-98dd-40f0c53b481c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Elemental Blast",
                Level = 5,
                Range = "30 feet (burst only).",
                Area = "10-foot radius burst, 30-foot cone, or 60-foot line.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bb056b7c-7bab-4b7a-9e2d-836a0305385e"), Type = TextBlockType.Text, Text = "You gather elemental energy and blast your foes in one of the various listed shapes of your choosing, dealing 8d6 bludgeoning damage (or fire damage if your element is fire). This spell has your element’s trait." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f4728f78-2ac2-45ed-b635-5ae0d67f595e"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("63e8f160-2236-42b5-b098-6fdcc32b02c2"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3506be50-4336-44c4-84bb-913720aa1978"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 404
            };
        }
    }
}
