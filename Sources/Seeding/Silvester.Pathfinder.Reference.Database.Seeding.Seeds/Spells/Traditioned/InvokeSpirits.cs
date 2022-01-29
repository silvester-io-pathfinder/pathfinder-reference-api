using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InvokeSpirits : Template
    {
        public static readonly Guid ID = Guid.Parse("f9a74400-ba0d-499a-9b46-39d22b307153");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Invoke Spirits",
                Level = 5,
                Range = "120 feet.",
                Area = "10-foot burst.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3a974c79-8a30-47e6-8ca6-0d3f4bd356fb"), Type = TextBlockType.Text, Text = "Ragged apparitions of the dead rise to stalk the living. They deal 2d4 mental damage and 2d4 negative damage to each living creature in the area, with a basic Will save. Additionally, creatures that critically fail the save are frightened 2 and are fleeing for 1 round." };
            yield return new TextBlock { Id = Guid.Parse("4693cc46-5806-4947-9a11-df287a1c9b49"), Type = TextBlockType.Text, Text = "On subsequent rounds, the first time you Sustain the Spell each round, you can move the area up to 30 feet within the range of the spell. Living creatures in the new area must attempt saves with the same effects as above, except that critically failing doesn't make them flee." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b9a330af-38c9-445c-a7b3-1b93042f0b69"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("1aebc10a-908e-4517-9f51-9d47e58dcbf0"), Type = TextBlockType.Text, Text = "The mental damage and negative damage each increase by 1d4." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("16ce7b97-5eaf-4527-9e70-5efa8587c023"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("1c49395a-e741-48a2-ac3d-bc9bf12c0386"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("8c119dd3-19ef-48fd-a0a2-8bc49aad545e"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("d7feba98-9cc8-43a9-9ebf-d6be3b9f3ac7"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2cd67b7-0846-4ac6-89cf-2ff1a8ecbab8"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 113
            };
        }
    }
}
