using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DivineArmageddon : Template
    {
        public static readonly Guid ID = Guid.Parse("5146d341-4fa0-4b1d-a2f1-f397138dc052");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Divine Armageddon",
                Level = 8,
                Range = "120 feet.",
                Area = "60-foot burst.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b1875381-2c10-44af-b000-0e69f2de75ea"), Type = TextBlockType.Text, Text = "You call forth a divine cataclysm from your deity, destroying living and undead creatures in the area alike. Creatures in the area take 10d6 negative damage and 10d6 alignment damage (good, evil, lawful, or chaotic), chosen from among the alignments your deity has. If your deity is true neutral, increase the negative damage by 4d6 instead of dealing alignment damage. A creature harmed by positive damage, such as one with negative healing, takes positive damage instead of negative damage from this spell." };
            yield return new TextBlock { Id = Guid.Parse("44a2f780-465c-4e7c-985e-05c2f14be2dd"), Type = TextBlockType.Text, Text = "You can't cast this spell if you don't have a deity. This spell gains the trait corresponding to the alignment damage dealt." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("718fdb1c-47fc-49e3-85f2-075d79460f16"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("43ac65d8-5bdf-4917-bc81-c971811ec016"), Type = TextBlockType.Text, Text = "The damage increases by 1d6 negative damage, 1d6 alignment damage, and 1d6 additional negative and positive damage for a true neutral deity." }
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
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("b1ab0ffa-0020-4c8a-bb0f-71126668a7c6"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("e087cff2-dd25-43fb-b8d7-b5195456328c"), Traits.Instances.Negative.ID);
            builder.Add(Guid.Parse("17d68b49-16c4-480b-a1b8-a3b035d3bd31"), Traits.Instances.Positive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("711795b9-d2a1-4044-a0c9-bff827e888df"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 100
            };
        }
    }
}
