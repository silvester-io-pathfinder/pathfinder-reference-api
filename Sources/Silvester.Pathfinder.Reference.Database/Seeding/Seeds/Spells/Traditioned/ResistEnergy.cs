using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ResistEnergy : Template
    {
        public static readonly Guid ID = Guid.Parse("79ff21e7-4e97-4aa8-bc7f-101572960965");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Resist Energy",
                Level = 2,
                Range = "Touch.",
                Duration = "10 minutes.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("56f77a74-82df-4a85-a4ac-79eb0b99ff16"), Type = TextBlockType.Text, Text = "A shield of elemental energy protects a creature against one type of energy damage. Choose acid, cold, electricity, fire, or sonic damage. The target and its gear gain resistance 5 against the damage type you chose." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c9e8447d-25f4-401e-ac92-c193c919190f"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7cc4b47c-84c6-4de1-8b18-44d1eacff7c7"), Type = TextBlockType.Text, Text = "The resistance increases to 10, and you can target up to two creatures." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("91970cba-d0af-42ba-a58d-80ca857315c1"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d4fe948b-de1a-404b-b1fe-f2cca8fc30e3"), Type = TextBlockType.Text, Text = "The resistance increases to 15, and you can target up to five creatures." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a5f911a-8edc-42c6-91b4-d8af9f348036"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 364
            };
        }
    }
}
