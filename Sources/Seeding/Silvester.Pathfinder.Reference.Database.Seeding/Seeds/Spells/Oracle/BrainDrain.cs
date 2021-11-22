using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BrainDrain : Template
    {
        public static readonly Guid ID = Guid.Parse("f53d6411-c7c8-49c0-a707-c241d0fd287d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Brain Drain",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b9e5b198-1a39-4aa4-ae73-b2e639510c18"), Type = TextBlockType.Text, Text = "You probe the target's mind to glean knowledge. This deals 1d8 mental damage with a basic Will save. If the target fails the save, you sort through the stolen memories to attempt a single check to Recall Knowledge. Choose a skill that has the Recall Knowledge action, and use the target's skill modifier for the check." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("36ecff97-1fb4-4569-add7-a28ec58b49bd"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("77fe9061-f850-4dd2-aef0-79866d08cae8"), Type = TextBlockType.Text, Text = "The mental damage increases by 1d8." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3b7d1d4-39ca-4c2b-8465-c086a37468b9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 230
            };
        }
    }
}
