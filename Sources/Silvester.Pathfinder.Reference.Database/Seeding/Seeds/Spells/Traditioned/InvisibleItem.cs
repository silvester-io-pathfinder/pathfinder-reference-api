using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InvisibleItem : Template
    {
        public static readonly Guid ID = Guid.Parse("8b3068e3-a4a3-4a39-ac17-b516d872836f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Invisible Item",
                Level = 1,
                Range = "Touch.",
                Duration = "1 hour.",
                Targets = "1 object.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("afd13f69-1a3d-4491-9a1d-8571e69866a2"), Type = TextBlockType.Text, Text = "You make the object invisible. This makes it undetected to all creatures, though the creatures can attempt to find the target, making it hidden to them instead if they succeed. If the item is used as part of a hostile action, the spell ends after that hostile action is completed. Making a weapon invisible typically doesn’t give any advantage to the attack, except that an invisible thrown weapon or piece of ammunition can be used for an attack without necessarily giving information about the attacker’s hiding place unless the weapon returns to the attacker." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3dacc552-00e7-472a-9144-6cc2b1f81feb"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("fa008a26-5738-4cac-b304-0ef3b31d44ee"), Type = TextBlockType.Text, Text = "The duration is until the next time you make your daily preparations." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("6e189a49-06b0-480b-9de6-e5006f32041e"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("be71ceb1-f07d-4526-ba55-d7133fe46c8f"), Type = TextBlockType.Text, Text = "The duration is unlimited." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39185340-b860-40ef-8f38-016da154f559"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 221
            };
        }
    }
}
