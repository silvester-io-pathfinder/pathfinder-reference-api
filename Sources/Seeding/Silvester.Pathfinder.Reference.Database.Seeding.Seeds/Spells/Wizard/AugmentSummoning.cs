using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AugmentSummoning : Template
    {
        public static readonly Guid ID = Guid.Parse("c985c9f7-e3ab-4c52-95ed-7bf788633852");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Augment Summoning",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature you summoned.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c6f929a-4740-4a62-9c54-bf0f9dbcca4b"), Type = TextBlockType.Text, Text = "You augment the abilities of a summoned creature. The target gains a +1 status bonus to all checks (this also applies to the creature's DCs, including its AC) for the duration of its summoning, up to 1 minute." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("9f8bfef9-f8d9-46e0-bb48-f9a1bfc8927d"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("55763124-cd5e-4baf-bc27-0efcb98694d8"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("8065c05a-30bc-416d-ada5-25c82f07e493"), Traits.Instances.Wizard.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d723066a-cdd2-4a08-b98c-666f9f993d27"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 406
            };
        }
    }
}
