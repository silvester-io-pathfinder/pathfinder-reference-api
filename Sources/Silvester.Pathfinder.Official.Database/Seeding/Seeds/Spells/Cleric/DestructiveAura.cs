using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DestructiveAura : Template
    {
        public static readonly Guid ID = Guid.Parse("4c09c609-8f31-4dd4-a809-35e8372d978d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Destructive Aura",
                Level = 4,
                Area = "15-foot emenation.",
                Duration = "1 minute.",
                DomainId = Domains.Instances.Destruction.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a87c1fec-149d-46ee-879f-c5df4c750b89"), Type = TextBlockType.Text, Text = "Swirling sands of divine devastation surround you, weakening the defenses of all they touch. Reduce the resistances of yourself and creatures in the area by 2." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("4523c367-497f-4eac-9f2a-6e71de3799e8"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c92b907e-438b-43a5-b828-b1d9afb35aff"), Type = TextBlockType.Text, Text = "Reduce the resistances by an additional 2." }
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
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f530eb19-0c51-4739-9a0b-2e3522f081b6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 391
            };
        }
    }
}
