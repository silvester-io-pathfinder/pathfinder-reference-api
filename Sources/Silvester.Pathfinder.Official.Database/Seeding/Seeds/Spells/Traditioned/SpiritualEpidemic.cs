using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiritualEpidemic : Template
    {
        public static readonly Guid ID = Guid.Parse("b501a600-3a18-4ce7-8cf7-12ae21ab2c78");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spiritual Epidemic",
                Level = 8,
                Range = "120 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a3cd5495-7d48-49c2-8f10-1247469886d5"), Type = TextBlockType.Text, Text = "You curse the target, sapping its spirit and leaving a contagious trap in its essence. The target must attempt a Will save. Any creature that casts a divine or occult spell on the target while it’s affected is targeted by spiritual epidemic and must also attempt a Will save. The curse continues to spread in this way." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("f338e1c6-03c7-4e99-abbc-47a3a0bcd872"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is enfeebled 2 and stupefied 2 for 1 round.",
                Failure = "The target is enfeebled 2 and stupefied 2 for 1 minute and enfeebled 1 and stupefied 1 permanently.",
                CriticalFailure = "The target is enfeebled 3 and stupefied 3 for 1 minute and enfeebled 2 and stupefied 2 permanently."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Curse.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c98ef54-846a-488c-844b-ca4f6688461e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 372
            };
        }
    }
}
