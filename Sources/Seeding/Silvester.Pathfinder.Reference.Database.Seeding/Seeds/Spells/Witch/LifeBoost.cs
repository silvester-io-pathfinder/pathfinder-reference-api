using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LifeBoost : Template
    {
        public static readonly Guid ID = Guid.Parse("77282857-0f07-4d74-b842-8039ed9d8f4c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Life Boost",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                Duration = "4 rounds.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f36dd9cb-ba2d-4e09-bab2-04b07d96ccef"), Type = TextBlockType.Text, Text = "You temporarily bolster the target's vitality. The target gains fast healing equal to double the spell's level." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ad9b714-b8f1-4b1f-89cd-1f1440aad631"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 238
            };
        }
    }
}
