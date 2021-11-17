using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SnareHopping : Template
    {
        public static readonly Guid ID = Guid.Parse("d18284dc-9d89-44a0-9910-57fb647d50b0");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Snare Hopping",
                Level = 1,
                Range = "10 feet.",
                Targets = "One snare you built.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Ranger.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("98a390ff-738d-47a8-9075-9215dca4ed30"), Type = TextBlockType.Text, Text = "You may not have placed your snare in the right place, but you can magically move it there. You teleport the target snare to another unoccupied location in range." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d5cb143b-b529-44f4-bd77-3ed5d681c76c"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0b822f94-01fc-44ce-9beb-01941330b34f"), Type = TextBlockType.Text, Text = "The range of the spell increases by 10 feet." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Ranger.ID;
            yield return Traits.Instances.Teleportation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9cf59ab-d6d5-43d4-8e32-48beeedd8b99"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 235
            };
        }
    }
}
