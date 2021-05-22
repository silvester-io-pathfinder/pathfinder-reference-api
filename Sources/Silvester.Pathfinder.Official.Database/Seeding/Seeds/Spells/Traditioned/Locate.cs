using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Locate : Template
    {
        public static readonly Guid ID = Guid.Parse("9ef85c45-46e6-4ca1-b396-1826bac8d772");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Locate",
                Level = 3,
                CastTime = "10 minutes.",
                Range = "500 feet.",
                IsDismissable = true,
                Duration = "Sustained.",
                Targets = "1 specific object or type of object.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bf813ba0-278c-43d7-900c-3538924fd4d3"), Type = TextBlockType.Text, Text = "You learn the direction to the target (if you picked a specific object, such as “my mother’s sword”) or the nearest target (if you picked a type of object, such as “swords”). If the target is a specific object, you must have observed it directly with your own senses. If it’s a type of object, you still need to have an accurate mental image of the type of object. If there’s lead or running water between you and the target, this spell can’t locate the object. This means you might find a type of object farther away if the nearest one is behind lead or running water." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("bef7be23-2986-4895-a4fa-3e436f8aa975"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("988ae8e2-eb67-43fa-86a1-d15c651bf8e3"), Type = TextBlockType.Text, Text = "You can target a specific creature or ancestry instead of an object, but you must have met or seen up close the creature or ancestry you want to target." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Detection.ID;
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87058035-3ce8-468a-a21e-a2c56780e879"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 348
            };
        }
    }
}
