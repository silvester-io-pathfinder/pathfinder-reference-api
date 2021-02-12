using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DivineDecreeSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Evocation";
        public override string SavingThrowStat => "Fortitude";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("7ebf76e9-a8fb-49a1-956c-f97f784dcbb9"),
                Name = "Divine Decree",
                Description = "You utter a potent litany from your faith, a mandate that harms those who oppose your ideals. Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or your deity is true neutral. This spell gains the trait of the alignment you chose. You deal 7d10 damage to creatures in the area; each creature must attempt a Fortitude save. Creatures with an alignment that matches the one you chose are unaffected by the spell. Those that neither match nor oppose it treat the result of their saving throw as one degree better and don’t suffer effects other than damage.",
                Level = 7,
                Area = "40-foot emanation.",
                Range = 40,
                Duration = "Varies."
            };
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

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("af0a1742-904c-4467-a3a8-510bff8e19d7"), Text = "Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or your deity is true neutral. This spell gains the trait of the alignment you chose. The bonuses granted by the spell increase to +2 against attacks by—and effects created by—creatures with an alignment opposite to the spell (lawful if you chose chaotic, evil if you chose good). These bonuses increase to +4 against effects created by such creatures that attempt to impose the controlled condition on a target of your divine aura, as well as against attacks made by creatures summoned by anything opposite in alignment to your divine aura." };
            yield return new SpellDetailBlock { Id = Guid.Parse("99d2bb14-6f2f-43d1-b317-3d62407948b0"), Text = "When a creature of opposite alignment hits a target with a melee attack, the creature must succeed at a Will save or be blinded for 1 minute. It’s then temporarily immune for 1 minute." };
            yield return new SpellDetailBlock { Id = Guid.Parse("d03cdf8c-3ba5-4729-b1e1-f3ab158d80db"), Text = "The first time you Sustain the Spell each round, the divine aura’s radius grows 10 feet." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("18cca2c1-2c7b-4486-b085-734cebf5f52d"), Level = 1, Description = "The damage increases by 1d10, and the level of creatures that must attempt a second save on a critical failure increases by 2." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Evocation";
        }
    }
}
