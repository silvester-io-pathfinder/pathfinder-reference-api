using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ScatterScree : Template
    {
        public static readonly Guid ID = Guid.Parse("8cc962a5-5dec-4f5f-bff2-8583aa0a7b4e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Scatter Scree",
                Level = 1,
                Range = "30 feet.",
                Duration = "1 minute.",
                Area = "Two contiguous 5-foot cubes.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f92711e-90aa-4f30-926f-033785c95730"), Type = TextBlockType.Text, Text = "You evoke a jumble of rocks in the area. The scattering rocks deal bludgeoning damage equal to 1d4 plus your spellcasting ability modifier to creatures in the area, with a basic Reflex save. The ground in the area becomes difficult terrain for the duration. A creature can Interact to clear a square of this scree." };
            yield return new TextBlock { Id = Guid.Parse("14662e06-c86a-4154-93f4-ff42dd8255e4"), Type = TextBlockType.Text, Text = "If you cast this spell again, any previous scatter scree you have cast ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a34f8953-5ab0-4eec-97ae-a2a3494067c2"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("d7bb7aff-be7f-4148-8ed0-b9b69790a281"), Type = TextBlockType.Text, Text = "The damage increases by 1d4." }
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("67863d8d-0b43-4628-8ec7-fd7e88954991"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("0ecc637f-5e3f-40e4-a482-ae1fd967b472"), Traits.Instances.Earth.ID);
            builder.Add(Guid.Parse("68504064-4b46-4fda-a919-dca82e19598c"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ad8a61a-4813-4546-a16f-4b3b567be04c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 127
            };
        }
    }
}
