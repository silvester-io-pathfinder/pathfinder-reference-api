using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FrigidFlurry : Template
    {
        public static readonly Guid ID = Guid.Parse("c0eb3fc3-075e-4938-b446-7e6f3ee2bd8f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Frigid Flurry",
                Level = 7,
                Area = "Line up to 120 feet.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a9f605be-f650-46f0-867d-52c58113163c"), Type = TextBlockType.Text, Text = "You place a palm to your lips and exhale a cold breath, whipping up a gust of wind that freezes the air�s ambient moisture into a flurry of jagged shards. The flurry deals 9d6 cold damage and 9d6 slashing damage to all foes, with a basic Reflex save, but the gust flows harmlessly around your allies. The wind then picks you up and carries you to the other end of the area; though your movement within the gust can still trigger reactions, the storm of ice crystals prevents you from being affected by any effects, except for those that would counteract the spell�s magic or that the GM decides would affect snow." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("128efdcb-813d-4750-b5b2-b88b0c80d40e"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("3bf589d9-969d-43ac-8cdc-209d7b8249c7"), Type = TextBlockType.Text, Text = "The cold and slashing damage each increase by 1d6." }
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
            builder.Add(Guid.Parse("8c35b96d-fca2-4da1-80d3-91e372967c4d"), Traits.Instances.Cold.ID);
            builder.Add(Guid.Parse("a2090253-20d2-45e3-99ba-b9190c916ca5"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("5fa09117-b5f5-431e-9ff0-5d6a4202664d"), Traits.Instances.Water.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b01e25c3-4598-49e3-8569-56aab0eba5bf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 108
            };
        }
    }
}
