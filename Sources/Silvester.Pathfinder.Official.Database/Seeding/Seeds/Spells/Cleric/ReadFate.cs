using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ReadFate : Template
    {
        public static readonly Guid ID = Guid.Parse("33cedd4d-f022-42b8-ad1d-7b09e254bc0b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Read Fate",
                Level = 1,
                Range = "10 feet.",
                CastTime = "1 minute.",
                Targets = "1 creature other than you.",
                DomainId = Domains.Instances.Fate.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e2c25e0c-9793-4fdd-a055-120cbf048ce1"), Type = TextBlockType.Text, Text = "You attempt to learn more about the target’s fate in the short term, usually within the next day for most prosaic creatures, or the next hour or less for someone likely to have multiple rapid experiences, such as someone actively adventuring." };
            yield return new TextBlock { Id = Guid.Parse("279570b1-5324-4be5-9442-d7bd5dc3ff58"), Type = TextBlockType.Text, Text = "You learn a single enigmatic word connected to the creature’s fate in that time frame. Fate is notoriously inscrutable, and the word isn’t necessarily meant to be taken at face value, so the meaning is often clear only in hindsight. The GM rolls a secret DC 6 flat check. If the creature’s fate is too uncertain, or on a failed flat check, the spell yields the word “inconclusive.” Either way, the creature is then temporarily immune for 24 hours." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Prediction.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("243ffa71-a4b1-4e0b-a53d-13755de9570c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 395
            };
        }
    }
}
