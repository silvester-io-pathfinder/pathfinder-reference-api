using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AshCloud : Template
    {
        public static readonly Guid ID = Guid.Parse("0ee08864-f3d1-4902-be89-97fd9595dc58");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ash Cloud",
                Level = 2,
                Range = "120 feet.",
                Duration = "1 minute.",
                Area = "20-foot burst.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ce94a3ba-24ff-4b76-ae62-29f45ed90a68"), Type = TextBlockType.Text, Text = "You summon a tumultuous cloud of ash and smoke. The cloud is difficult terrain for flying creatures, and creatures in the cloud can�t detect anything using their sense of smell. Creatures that start their turn within the cloud take 2d4 fire damage as their lungs fill with the hot, acrid smoke, with a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("bcbf11a4-6c66-422e-9692-7639527d9176"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("1b6a2e42-5444-403f-b588-a611c23931a7"), Type = TextBlockType.Text, Text = "The damage increases by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("83a9fd6c-ad59-4d4e-aea9-c204d41c4228"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage.",
                Failure = "The target takes full damage and is dazzled for 1 round.",
                CriticalFailure = "The target takes double damage and is blinded for 1 round."
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("989ce419-0e89-43be-a78c-59a981c7a3f6"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("5731605e-55a2-407b-a5df-f7f06afa5524"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("e49d3d89-33f7-4bc1-bb2f-eef573bbe910"), Traits.Instances.Fire.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56a813a8-32a6-4853-898c-2eba881f3cb3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 90
            };
        }
    }
}
