using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DivineAuraSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Abjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("b6f25115-9358-44eb-bfc2-37b01c3863f4"),
                Name = "Divine Aura",
                Description = "Divine power wards the targets, granting each a +1 status bonus to AC and saves while in the area.",
                Level = 1,
                Area = "10-foot emanation.",
                Targets = "Allies in the area.",
                Duration = "Sustained up to 1 minute."
            };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("fd081fec-24f3-4bde-a6c4-44c031947a4a"), Text = "Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or your deity is true neutral. This spell gains the trait of the alignment you chose. The bonuses granted by the spell increase to +2 against attacks by—and effects created by—creatures with an alignment opposite to the spell (lawful if you chose chaotic, evil if you chose good). These bonuses increase to +4 against effects created by such creatures that attempt to impose the controlled condition on a target of your divine aura, as well as against attacks made by creatures summoned by anything opposite in alignment to your divine aura." };
            yield return new SpellDetailBlock { Id = Guid.Parse("dc1ca729-0d82-4e6e-8464-01e612e2d9bd"), Text = "When a creature of opposite alignment hits a target with a melee attack, the creature must succeed at a Will save or be blinded for 1 minute. It’s then temporarily immune for 1 minute." };
            yield return new SpellDetailBlock { Id = Guid.Parse("766add6f-238c-4106-ae46-8595907ce970"), Text = "The first time you Sustain the Spell each round, the divine aura’s radius grows 10 feet." };
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
            yield return "Abjuration";
        }
    }
}
