using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TempestOfShades : Template
    {
        public static readonly Guid ID = Guid.Parse("331e0a4f-bc8e-48bd-a8b3-44dad0325e02");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tempest of Shades",
                Level = 7,
                Range = "100 feet.",
                Duration = "Until the end of your next turn.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8bab8bb9-5b2c-40f2-a2ba-8ee6425f6a4f"), Type = TextBlockType.Text, Text = "You channel the forces of undeath to briefly call forth an amalgam of the vengeful dead slain by your enemies and allies alike. This amalgam manifests as a large tornado of insubstantial, howling faces. It occupies the space of a Huge creature and has a Speed of 60 feet." };

        }

        protected override IEnumerable<InlineAction> GetInlineActions()
        {
            yield return new InlineAction
            {
                Id = Guid.Parse("d44384f4-ed7d-484d-bb83-94dd657b16b5"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Arrive",
                Traits = new[]
                {
                    new InlineActionTraitBinding { Id = Guid.Parse("4552e202-5a4c-4377-a0c3-a3eb7667468f"), TraitId = Traits.Instances.Negative.ID },
                },
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("c2cb58aa-9143-4691-ab93-121502573a4f"), Type = TextBlockType.Heading, Text = "Vortex of Death" },
                    new TextBlock { Id = Guid.Parse("23176c65-f876-4509-b8ce-e38f8be94465"), Type = TextBlockType.Text, Text = "Each enemy creature within a 60-foot emanation must attempt a Fortitude save with the following effects." },
                },
                RollableEffect = new RollableEffect
                {
                    Id = Guid.Parse("61d78097-5758-401c-bca7-d8a5ef453d0b"),
                    CriticalSuccess = "The creature is unaffected.",
                    Success = "The creature is drained 1.",
                    Failure = "The creature is drained 2.",
                    CriticalFailure = "The creature is drained 3."
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("91d16e51-a663-4055-a4e8-4a4ebc06674f"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Depart",
                Traits = new[]
                {
                    new InlineActionTraitBinding { Id = Guid.Parse("53435564-0fcc-4149-a3f3-72cf3d41aaee"), TraitId = Traits.Instances.Emotion.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("370fe350-a9a0-41fa-8799-033e5674b2db"), TraitId = Traits.Instances.Fear.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("b84a919a-4580-4aee-95bf-8cf033ff0c66"), TraitId = Traits.Instances.Mental.ID },
                },
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("610c5832-7c2e-426c-8583-ed494964e95c"), Type = TextBlockType.Heading, Text = "Howl of Eternity" },
                    new TextBlock { Id = Guid.Parse("8db63b06-e5fb-4829-9df6-aef1f0831020"), Type = TextBlockType.Text, Text = "The vengeful dead lets out an anguished scream. All your enemies within a 100-foot emanation must attempt Will saves with the following effects." },
                },
                RollableEffect = new RollableEffect
                {
                    Id = Guid.Parse("f336cf6e-f938-434f-aba8-585f45d9fc2c"),
                    CriticalSuccess = "The creature is unaffected.",
                    Success = "The creature is frightened 1.",
                    Failure = "The creature is frightened 3.",
                    CriticalFailure = "The creature is frightened 3. It's also fleeing for 1 round or until it's no longer frightened, whichever comes first."
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("b4f14414-7db9-4b7d-9b62-29c0b46aa018"), Traits.Instances.Incarnate.ID);
            builder.Add(Guid.Parse("6653d49a-5db3-4b11-a0dd-5e7a8dc0e6d1"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("698e3ab9-2d84-42eb-be49-9fd6fcdfb8a6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 135
            };
        }
    }
}
