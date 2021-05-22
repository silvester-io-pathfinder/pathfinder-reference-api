using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ProtectorsSacrifice : Template
    {
        public static readonly Guid ID = Guid.Parse("3378bac9-961e-47fe-ba8b-5a169ad7f879");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Protector's Sacrifice",
                Level = 1,
                Trigger = "An ally within 30 feet takes damage.",
                Range = "30 feet.",
                DomainId = Domains.Instances.Protection.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2befd5cf-8db5-4c7d-b3bb-b7bfa9e9b018"), Type = TextBlockType.Text, Text = "You protect your ally by suffering in their stead. Reduce the damage the triggering ally would take by 3. You redirect this damage to yourself, but your immunities, weaknesses, resistances and so on do not apply." };
            yield return new TextBlock { Id = Guid.Parse("bab2821a-408e-45df-8a18-373362a08c28"), Type = TextBlockType.Text, Text = "You aren’t subject to any conditions or other effects of whatever damaged your ally (such as poison from a venomous bite). Your ally is still subject to those effects even if you redirect all of the triggering damage to yourself." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("9ac14f3d-39f4-41f8-a974-fc5eadbd08b0"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("554fffd2-f97b-4215-9c15-65ff68926dcf"), Type = TextBlockType.Text, Text = "The damage you redirect increases by 3." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Cleric.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37d1c60e-9c01-46c9-8b55-d9fe3e911b58"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 395
            };
        }
    }
}
