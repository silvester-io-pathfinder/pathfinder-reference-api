using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FeyGlamour : Template
    {
        public static readonly Guid ID = Guid.Parse("50084c79-74b7-4ffd-905b-2c080940fafd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Fey Glamour",
                Level = 5,
                Range = "30 feet.",
                Area = "30-foot burst or target up to 10 creatures.",
                Duration = "10 minutes.",
                Targets = "Up to 10 creatures or has a 30-foot burst.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eb3e1387-aa64-433c-9f52-59ee3bcdfa90"), Type = TextBlockType.Text, Text = "You call upon fey glamours to cloak an area or the targets in illusion. This has the effect of either illusory scene on the area or veil on the creatures, as if heightened to a level 1 level lower than fey glamour, using fey glamour’s range and duration." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6fe91af5-1964-4464-8418-ab8c17ebba90"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 404
            };
        }
    }
}
