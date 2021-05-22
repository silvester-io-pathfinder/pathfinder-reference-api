using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class VeilOfConfidence : Template
    {
        public static readonly Guid ID = Guid.Parse("5aa20247-696a-40c0-89ff-6b9de4da1a5b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Veil of Confidence",
                Level = 1,
                Duration = "1 minute.",
                DomainId = Domains.Instances.Confidence.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d1df2451-4a4b-4ef7-abf8-fdadd8e8aa30"), Type = TextBlockType.Text, Text = "You surround yourself in a veil of confidence. You reduce your current frightened condition by 1, and whenever you would become frightened during the duration, reduce the amount by 1." };
            yield return new TextBlock { Id = Guid.Parse("19f41470-69c9-4f57-bdad-4b49ea367da2"), Type = TextBlockType.Text, Text = "If you critically fail a save against fear, veil of confidence ends immediately, and you increase any frightened condition you gain from the critical failure by 1 instead of decreasing it." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("505371fb-09d0-480a-a553-fa986bef1378"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 398
            };
        }
    }
}
