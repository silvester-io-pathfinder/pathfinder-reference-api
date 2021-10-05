using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RestoreSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("3245f53c-d857-4bf3-964e-0ef6dbfafb79");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Restore Senses",
                Level = 2,
                Range = "Touch.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6875ad1f-90f6-4ce4-9cd8-e222beb0b256"), Type = TextBlockType.Text, Text = "You attempt to counteract a single effect imposing the blinded or deafened conditions on the target, restoring its vision or hearing. This can counteract both temporary magic and permanent consequences of magic, but it doesn’t cure someone who does not have the sense due to some natural state or effect, such as from birth or from a non-magical wound or toxin." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("bd1c7d5c-a4ca-4f24-b7d0-890c119932fc"), 
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4d3ba751-f0e5-4a0f-903e-94f5f2eb61b7"), Type = TextBlockType.Text, Text = "The spell’s range increases to 30 feet, and you can target up to 10 creatures. You can choose the effect to counteract separately for each selected creature." }
                }
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
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b358d034-b3ea-4f41-951e-24016a580eac"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 364
            };
        }
    }
}
