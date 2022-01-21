using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HauntingHymn : Template
    {
        public static readonly Guid ID = Guid.Parse("7a963a2d-6170-4ff3-a4a3-91220546fd26");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Haunting Hymn",
                Level = 1,
                Area = "15-foot cone.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("49e2d19c-a94a-4aa2-9781-d5924dbae06a"), Type = TextBlockType.Text, Text = "You echo a jarring hymn that only creatures in the area can hear. The hymn deals sonic damage equal to your spellcasting ability modifier, with a basic Fortitude save. If a target critically fails the save, it�s also deafened for 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("61c06bc2-8167-4164-a29e-8982628b09ae"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("902fd0e7-a22d-4958-a43d-1e08eb509a07"), Type = TextBlockType.Text, Text = "The damage increases by 1d6." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("d13c684b-ef47-44b0-91f2-f665d980f16f"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("91c6f583-baec-44e0-9970-54b538deabae"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("c50b4d4a-0585-48a4-99a8-5fff925b416d"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("c1a5522f-7bf8-420a-bc4e-3781e138be03"), Traits.Instances.Sonic.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("481e41db-41fd-4377-b2c0-3a65dc746bda"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 109
            };
        }
    }
}
