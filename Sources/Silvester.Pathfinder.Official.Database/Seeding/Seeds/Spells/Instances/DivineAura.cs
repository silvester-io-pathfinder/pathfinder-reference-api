using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DivineAura : Template
    {
        public static readonly Guid ID = Guid.Parse("b6f25115-9358-44eb-bfc2-37b01c3863f4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Divine Aura",
                Level = 1,
                Area = "10-foot emanation.",
                Targets = "Allies in the area.",
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("97f6d208-ccae-4703-8e06-4f807304db67"), Type = Utilities.Text.TextBlockType.Text, Text = "Divine power wards the targets, granting each a +1 status bonus to AC and saves while in the area." };
            yield return new TextBlock { Id = Guid.Parse("fd081fec-24f3-4bde-a6c4-44c031947a4a"), Type = Utilities.Text.TextBlockType.Text, Text = "Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or your deity is true neutral. This spell gains the trait of the alignment you chose. The bonuses granted by the spell increase to +2 against attacks by—and effects created by—creatures with an alignment opposite to the spell (lawful if you chose chaotic, evil if you chose good). These bonuses increase to +4 against effects created by such creatures that attempt to impose the controlled condition on a target of your divine aura, as well as against attacks made by creatures summoned by anything opposite in alignment to your divine aura." };
            yield return new TextBlock { Id = Guid.Parse("dc1ca729-0d82-4e6e-8464-01e612e2d9bd"), Type = Utilities.Text.TextBlockType.Text, Text = "When a creature of opposite alignment hits a target with a melee attack, the creature must succeed at a Will save or be blinded for 1 minute. It’s then temporarily immune for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("766add6f-238c-4106-ae46-8595907ce970"), Type = Utilities.Text.TextBlockType.Text, Text = "The first time you Sustain the Spell each round, the divine aura’s radius grows 10 feet." };
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
            yield return Traits.Instances.Abjuration.ID;
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
