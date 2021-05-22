using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class RetributivePain : Template
    {
        public static readonly Guid ID = Guid.Parse("26c6bd1b-0b78-4b6a-9fbf-ea95af5776fe");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Retributive Pain",
                Level = 4,
                Trigger = "A creature in range damages you.",
                Range = "30 feet.",
                Targets = "The triggering creatue.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DomainId = Domains.Instances.Pain.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("444b3e59-ca86-4ebc-a2b0-8f9493fc3173"), Type = TextBlockType.Text, Text = "You vengefully reflect your pain upon your tormentor. The target takes mental damage equal to half the amount it dealt to you when it triggered the spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Nonlethal.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa4395c9-f4de-4d1e-897a-db519ca6a38e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 396
            };
        }
    }
}
