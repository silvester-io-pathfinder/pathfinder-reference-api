using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("f101215e-e4b9-4614-8b9c-9ac8192c580e"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("3464e8d5-5398-432c-b225-47cb3deaace6"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("0ebbf1f5-b246-4595-9ce3-d04ce0d812a7"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("6465eb9e-f012-4a6b-aeed-f2945d73542c"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("228e8395-3617-490e-97cc-bf4f7e50365e"), Traits.Instances.Nonlethal.ID);
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
