using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PhantasmalKiller : Template
    {
        public static readonly Guid ID = Guid.Parse("e0288efb-73eb-4baf-97fa-fe63518290a5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Phantasmal Killer",
                Level = 4,
                Range = "120 feet.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("20651acb-48f1-4b99-8c49-1409a71892fb"), Type = TextBlockType.Text, Text = "You create a phantasmal image of the most fearsome creature imaginable to the target. Only the spell’s target can see the killer, though you can see the vague shape of the illusion as it races forth to attack. The effect of the killer is based on the outcome of the target’s Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("56f3b9c8-60ec-4525-aae2-6d3a6de2485b"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("aec25120-e0a7-43f0-9983-ec4441098476"), Type = TextBlockType.Text, Text = "The damage increases by 2d6 on a failure and by 3d6 on a critical failure." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("ec39a4cc-fde3-43d1-aa3c-dfb9033d793a"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes 4d6 mental damage and is frightened 1.",
                Failure = "The target takes 8d6 mental damage and is frightened 2.",
                CriticalFailure = "The target is so afraid it might die. It must attempt a Fortitude save; if the target fails, it dies. On a successful Fortitude save, the target takes 12d6 mental damage, is fleeing until the end of its next turn, and is frightened 4. This effect has the incapacitation trait."
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4c18702-da7d-4da8-9597-5b4d9991f1cd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 357
            };
        }
    }
}
