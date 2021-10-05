using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Stoneskin : Template
    {
        public static readonly Guid ID = Guid.Parse("fdba9c6f-2d28-4d82-b275-713e6b118cd0");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Stoneskin",
                Level = 4,
                Range = "Touch.",
                Duration = "20 minutes.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("73a841fd-02f4-40d5-a0ee-7dbd631288a7"), Type = TextBlockType.Text, Text = "The target’s skin hardens like stone. It gains resistance 5 to physical damage, except adamantine. Each time the target is hit by a bludgeoning, piercing, or slashing attack, stoneskin’s duration decreases by 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("62c8b84e-5801-4508-a499-06c7597c3bf5"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("3df15422-e262-4b14-a21b-9d7847e363f5"), Type = TextBlockType.Text, Text = "The resistance increases to 10." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("4203b36d-aa87-4c7c-bce2-2c67e2b6c6cc"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("44f18d51-7941-4075-9a49-e2d54cb1e181"), Type = TextBlockType.Text, Text = "The resistance increases to 15." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("9ed6f54b-902e-481f-8651-ee36454bad7f"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("448e06e5-ad77-4cd7-8458-945cfe37abc1"), Type = TextBlockType.Text, Text = "The resistance increases to 20." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Earth.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a20733fb-2b92-4f19-b2de-38f7aed6de9a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 374
            };
        }
    }
}
