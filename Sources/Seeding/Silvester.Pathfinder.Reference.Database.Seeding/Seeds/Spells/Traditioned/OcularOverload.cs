using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class OcularOverload : Template
    {
        public static readonly Guid ID = Guid.Parse("9bfcf7c9-1ae2-4190-be14-d2648dabfad8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ocular Overload",
                Level = 4,
                Duration = "24 hours.",
                CastTime = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("df949a69-832a-424e-88f4-aa754b107e3b"), Type = TextBlockType.Text, Text = "Just as a creature is about to attack you, you assault them with jarring illusions, completely surrounding their eyes with blinding flashes of motion and color. When the spell is complete, you gain the Overload Vision reaction; once you use the reaction, the spell ends." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("f75eeac7-92e6-422f-89f1-60898f0d1192"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Name = "Overload Vision",
                Trigger = "A creature within 60 feet would make an attack roll against you.",
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("e95b724a-0cda-426a-beb4-82da3b7dcdf8"), Type = TextBlockType.Text, Text = "The triggering creature must attempt a Fortitude save." },
                    new TextBlock { Id = Guid.Parse("071073bf-2a50-43e8-8993-8690d9472f91"), Type = TextBlockType.Enumeration, Text = "Critical Success: The target is unaffected." },
                    new TextBlock { Id = Guid.Parse("2b4d400d-d805-4dbf-a74c-e533c804dcdf"), Type = TextBlockType.Enumeration, Text = "Success: The target is dazzled until the end of the current turn." },
                    new TextBlock { Id = Guid.Parse("45992a02-3b6f-4094-b612-0b884d77551d"), Type = TextBlockType.Enumeration, Text = "Failure: The target is blinded until the end of the current turn." },
                    new TextBlock { Id = Guid.Parse("81c5df03-1ed7-4d4c-8c7d-d786044f3586"), Type = TextBlockType.Enumeration, Text = "Critical: Failure The target is blinded until the end of the current turn and dazzled for 1 minute." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Contingency.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6276c540-2ad3-4be8-9bf1-86d8fea963ff"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 118
            };
        }
    }
}
