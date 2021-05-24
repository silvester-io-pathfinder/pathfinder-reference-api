using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class StrokeTheHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("51551c5f-f153-4c9a-9367-b51f79eb223b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Stroke the Heart",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("15cb4163-2e1a-40f6-9418-13cb5a79797a"), Type = TextBlockType.Text, Text = "Intense fervor fills the target creature, empowering their blows. The target gains a +2 status bonus to damage rolls. Once this spell ends, the target becomes temporarily immune for 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("5a334597-520f-46f6-920e-1348f05f96de"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e60abb48-cf88-432c-b9af-4ddab73ef83b"), Type = TextBlockType.Text, Text = "The status bonus to damage increases by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("128d66a8-5295-4102-b74f-3cabdd2a2e31"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 239
            };
        }
    }
}
