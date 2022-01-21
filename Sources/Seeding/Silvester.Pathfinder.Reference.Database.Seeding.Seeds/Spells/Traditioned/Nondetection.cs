using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Nondetection : Template
    {
        public static readonly Guid ID = Guid.Parse("76d552d4-9c62-4875-b920-095c64beb01d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Nondetection",
                Level = 3,
                CastTime = "10 minutes.",
                Range = "Touch.",
                Duration = "8 hours.",
                Targets = "1 creature or object.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a9ee48e9-0f64-4f37-8a57-260052036b32"), Type = TextBlockType.Text, Text = "You erect protective wards that make the target difficult to detect via magic. Nondetection attempts to counteract all detection, revelation, and scrying divinations made against the target or the target's gear throughout the duration, counting cantrips as 1st-level spells for this purpose. Successfully counteracting a divination that targets an area or multiple targets negates the effects only for nondetection's target." };
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
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("420a33be-bb9c-4952-a12d-cfa29dcdacb6"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("b11a8cd5-9791-4d03-aa55-fff7be846bb1"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fe11e19-9690-447a-95eb-1759b6e1fe61"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 355
            };
        }
    }
}
