using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Unity : Template
    {
        public static readonly Guid ID = Guid.Parse("891c75f8-0588-453f-a807-e0f1dde5a995");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Unity",
                Level = 1,
                Trigger = "You and 1 or more allies within range are targeted by a spell or ability that allows a saving throw.",
                Range = "30 feet.",
                Targets = "Each ally targeted by the triggering spell.",
                DomainId = Domains.Instances.Family.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1b81a409-7126-4d71-9341-c55d52603d16"), Type = TextBlockType.Text, Text = "You put up a united defense. Each ally can use your saving throw modifier instead of its own against the triggering spell. Each ally decides individually which modifier to use." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Fortune.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e818b941-e875-4e81-8f76-907c69c8d765"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 398
            };
        }
    }
}
