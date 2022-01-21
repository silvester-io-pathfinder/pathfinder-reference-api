using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DrawIre : Template
    {
        public static readonly Guid ID = Guid.Parse("e5d54406-c04b-4709-8a85-be1ba795e198");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Draw Ire",
                Level = 1,
                Range = "120 feet.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d7dee38-76fe-41fe-b415-792c7da0fa8e"), Type = TextBlockType.Text, Text = "You cause mental distress to a creature, goading it to strike back at you. You deal 1d10 mental damage to the creature and cause it to take a �1 status penalty to attack rolls against creatures other than you. The creature must attempt a Will saving throw." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ff9153d2-4062-4bb9-b457-5b3d915d5233"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("160843eb-1178-4e27-a4bd-a4c19701514a"), Type = TextBlockType.Text, Text = "The damage increases by 1d10." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("39c5098a-f802-4244-b7ad-00d76f3c22f3"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage and the penalty. The spell ends at the end of the target�s next turn.",
                Failure = "The target takes full damage and the penalty.",
                CriticalFailure = "The target takes double damage, and the status penalty is �2."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("dae92d62-9134-40e3-8bcb-a26577227f40"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("3fa5250f-0fd4-4c9e-a27a-ed796e97897f"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("fbac2237-2a5d-477b-8bbc-9ef9f22ea3f6"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b21e3281-85e0-4335-ad8c-58abb39cd13d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 101
            };
        }
    }
}
