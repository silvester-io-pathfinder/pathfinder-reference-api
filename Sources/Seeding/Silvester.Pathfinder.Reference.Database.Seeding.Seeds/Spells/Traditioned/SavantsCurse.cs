using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SavantsCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("cb0553e1-abbf-4e0e-90b5-f55e8e79e4b4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Savant's Curse",
                Level = 4,
                Range = "Touch.",
                Targets = "1 creature.",
                Duration = "Varies.",
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("341f8643-0e20-42eb-a7aa-97b65116c6af"), Type = TextBlockType.Text, Text = "You afflict the target with a curse that fills its mind with distracting and hyperspecialized minutiae, causing it to second-guess even simple facts. The target must attempt a Will saving throw." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("caf99d81-ed53-41e7-b01c-f763c8c69549"),
                CriticalSuccess = "The target is unaffected.",
                Success = "For 10 minutes, the target must roll twice and use the worse result whenever attempting an Arcana, Lore, Occultism, or Society check. If the target succeeds at a check to Recall Knowledge, it gains one piece of true knowledge and one piece of erroneous knowledge, but it has no way of knowing which is which (this has no effect if the target critically succeeds at a check to Recall Knowledge).",
                Failure = "As success, but the effect is permanent.",
                CriticalFailure = "As failure, and the target treats the outcomes of all checks to Recall Knowledge as one degree of success worse than the result the target rolled (a critical success becomes a success, a success becomes a failure, and a failure becomes a critical failure)."
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
            builder.Add(Guid.Parse("34e34b4a-2bbc-445d-b5c2-e2e4fb1c710a"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("6abb9699-cf40-4978-9924-9b9d1fa66057"), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse("6d1e8f32-de59-4297-a945-19fdb2a95f40"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("a7c6437a-d4ab-4124-a429-fdd21c693a39"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("475f239f-a178-4402-a080-579ea3dc57a5"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("308a33c4-3826-4aa9-bda2-243d6ee4cd6b"), Traits.Instances.Misfortune.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("950f0453-3392-4e01-afcd-207237cbd9b9"),
                SourceId = Sources.Instances.Pathfinder164.ID,
                Page = 73
            };
        }
    }
}
