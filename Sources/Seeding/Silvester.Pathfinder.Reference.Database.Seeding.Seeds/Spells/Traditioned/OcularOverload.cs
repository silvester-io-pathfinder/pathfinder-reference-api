using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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

        protected override IEnumerable<InlineAction> GetInlineActions()
        {
            yield return new InlineAction
            {
                Id = Guid.Parse("f75eeac7-92e6-422f-89f1-60898f0d1192"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Name = "Overload Vision",
                Trigger = "A creature within 60 feet would make an attack roll against you.",
                Traits = new[]
                {
                    new InlineActionTraitBinding { Id = Guid.Parse("998eba6c-f08e-43d7-8b83-7ccfe0c39e2a"), TraitId = Traits.Instances.Concentrate.ID },
                },
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("e95b724a-0cda-426a-beb4-82da3b7dcdf8"), Type = TextBlockType.Text, Text = "The triggering creature must attempt a Fortitude save." },
                },
                RollableEffect = new RollableEffect
                {
                    Id = Guid.Parse("97acf3be-b567-4490-b331-76ca59a604ba"),
                    CriticalSuccess = "The target is unaffected.",
                    Success = "The target is dazzled until the end of the current turn.",
                    Failure = "The target is blinded until the end of the current turn.",
                    CriticalFailure = "Failure The target is blinded until the end of the current turn and dazzled for 1 minute."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("cc7b3863-eeca-4844-a0fe-d33437c2ead1"), Traits.Instances.Contingency.ID);
            builder.Add(Guid.Parse("b2861c66-90ba-4830-be75-d9a936aada96"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("a992a0a2-cf03-46cd-82c0-c8efb13d3bc7"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("0688dea3-7817-4118-a093-865418f199ac"), Traits.Instances.Visual.ID);
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
