using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LifeSiphon : Template
    {
        public static readonly Guid ID = Guid.Parse("52cde738-bac5-48e6-a245-3f51ff948fa4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Life Siphon",
                Level = 4,
                Trigger = "You expend one of your wizard spell slots to cast a wizard spell of the necromancy school.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("74d506fe-cae9-4d97-9f45-886a3206cd00"), Type = TextBlockType.Text, Text = "You use some of the spell’s magic to heal yourself, regaining 1d8 Hit Points per level of the spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f0fa532-07b8-4b42-92e6-56ae0a6e4739"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
