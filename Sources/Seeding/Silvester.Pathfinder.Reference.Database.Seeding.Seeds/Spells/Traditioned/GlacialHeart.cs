using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GlacialHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("0fc245ac-b449-4a96-93b3-0eeab6125679");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Glacial Heart",
                Level = 5,
                Range = "30 feet.",
                Targets = "1 creature.",
                Duration = "1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6648b06c-dfb4-492c-9f9a-c95ef113b05d"), Type = TextBlockType.Text, Text = "Ice and bone-deep cold assail the target, freezing it from the inside out. The frosty assault deals 10d6 cold damage, subject to the target's Fortitude save. After the effects are resolved, the target is temporarily immune for 1 day." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("81dcd6a5-50de-4ffa-a62c-e3311934f535"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("eb0a0ac9-b0e3-4d58-99b5-9b7b4217cfda"), Type = TextBlockType.Text, Text = "Increase the cold damage by 2d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("2601268b-c66c-485a-b3bc-4f5908dd3d9d"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The target takes half damage and is slowed 1 for 1 round. The spell ends.",
                Failure = "The target takes full damage, is slowed 1, and must attempt a Fortitude save at the end of each of its turns; this ongoing save has the incapacitation trait. On a failed save, the slowed condition increases by 1 (or 2 on a critical failure), to a maximum of slowed 4. On a success, the slowed condition decreases by 1. If at any point the slowed condition is reduced to 0, the spell ends. Once a creature's actions are reduced to 0 by this slowed condition, the creature is completely encased in ice. It continues making saves against glacial heart, possibly allowing it to reduce its slowed condition enough that it can act. This ice has Hardness 4 and 8 Hit Points, and its DC to Force Open is your spell DC. Breaking the ice frees the creature and ends the spell. If someone other than the target breaks the ice from outside, the target is stunned 1 and takes any damage dealt by the breaking effect in excess of the ice's Hit Points.",
                CriticalFailure = "As failure, but the target takes double damage and is initially slowed 2."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield break;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ff626c4d-2565-4952-a7ea-e4fc40007f63"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("0b219312-db61-4509-b96c-da800b0eed31"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("a96e4b4c-79c0-4001-9cc3-63fc37fbec32"), Traits.Instances.Hex.ID);
            builder.Add(Guid.Parse("ed45ba53-972f-4b22-a137-3da43c56cc04"), Traits.Instances.Witch.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc8c57fd-ac4a-4d9b-a946-1672c020faca"),
                SourceId = Sources.Instances.Legends.ID,
                Page = 32
            };
        }
    }
}
