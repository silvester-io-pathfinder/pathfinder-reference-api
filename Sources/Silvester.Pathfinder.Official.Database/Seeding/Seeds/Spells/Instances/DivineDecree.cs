using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DivineDecree : Template
    {
        public static readonly Guid ID = Guid.Parse("7ebf76e9-a8fb-49a1-956c-f97f784dcbb9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Divine Decree",
                Level = 7,
                Area = "40-foot emanation.",
                Range = "40 feet.",
                Duration = "Varies.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a12047e1-53c7-401d-9ce8-360d8f29ca8b"), Type = Utilities.Text.TextBlockType.Text, Text = "You utter a potent litany from your faith, a mandate that harms those who oppose your ideals. Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or your deity is true neutral. This spell gains the trait of the alignment you chose. You deal 7d10 damage to creatures in the area; each creature must attempt a Fortitude save. Creatures with an alignment that matches the one you chose are unaffected by the spell. Those that neither match nor oppose it treat the result of their saving throw as one degree better and don’t suffer effects other than damage." };
            yield return new TextBlock { Id = Guid.Parse("af0a1742-904c-4467-a3a8-510bff8e19d7"), Type = Utilities.Text.TextBlockType.Text, Text = "Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or your deity is true neutral. This spell gains the trait of the alignment you chose. The bonuses granted by the spell increase to +2 against attacks by—and effects created by—creatures with an alignment opposite to the spell (lawful if you chose chaotic, evil if you chose good). These bonuses increase to +4 against effects created by such creatures that attempt to impose the controlled condition on a target of your divine aura, as well as against attacks made by creatures summoned by anything opposite in alignment to your divine aura." };
            yield return new TextBlock { Id = Guid.Parse("99d2bb14-6f2f-43d1-b317-3d62407948b0"), Type = Utilities.Text.TextBlockType.Text, Text = "When a creature of opposite alignment hits a target with a melee attack, the creature must succeed at a Will save or be blinded for 1 minute. It’s then temporarily immune for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("d03cdf8c-3ba5-4729-b1e1-f3ab158d80db"), Type = Utilities.Text.TextBlockType.Text, Text = "The first time you Sustain the Spell each round, the divine aura’s radius grows 10 feet." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("1d9d9b1c-7036-46dd-9067-f132780d776c"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and is enfeebled 2 for 1 minute.",
                CriticalFailure = "The creature takes double damage and is enfeebled 2 for 1 minute. On your home plane, a creature that critically fails is banished with the effect of a failed banishment save. A 10th-level creature or lower must attempt a Will save. On a failure, it’s paralyzed for 1 minute; on a critical failure, it dies."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("18cca2c1-2c7b-4486-b085-734cebf5f52d"),
                Level = "+1", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4cd9a795-3ecc-42e2-81e7-157af0a80bd6"), Type = Utilities.Text.TextBlockType.Text, Text = "The damage increases by 1d10, and the level of creatures that must attempt a second save on a critical failure increases by 2." }
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 331
            };
        }
    }
}
