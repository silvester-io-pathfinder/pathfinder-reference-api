using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShareLore : Template
    {
        public static readonly Guid ID = Guid.Parse("2f4c706c-2235-4696-b42a-1448d6d9348d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Share Lore",
                Level = 1,
                Range = "Touch.",
                CastTime = "1 minute.",
                Targets = "Up to 3 creatures",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4088fb15-34ad-4a64-b7ae-d903c4f0f017"), Type = Utilities.Text.TextBlockType.Text, Text = "You share your knowledge with the touched creatures. Choose one Lore skill in which you are trained. The targets become trained in that Lore skill for the duration of the spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2b10bc0b-97fa-4cc0-b1c9-429f66a1857a"),
                Level = "3rd",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("ae28d05f-7b29-4538-8c4c-1fc92ca5b8c9"), Type = TextBlockType.Text, Text = "The duration of the spell is 1 hour and you can target up to five creatures." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("09b4dc33-8b3c-4736-8800-2868a2834248"),
                Level = "5th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("942affad-b995-45e5-bcf5-0016c85f05ac"), Type = TextBlockType.Text, Text = "The duration of the spell is 8 hours, you can target up to five creatures, and you can share up to two Lore skills in which you are trained." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("7b56e602-9d7b-4008-93f2-3ffbeaa509ab"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("cd566930-42e9-47eb-aaae-e19addb7edd6"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4a6d895-f716-4c8c-a181-d7a23c4a28a8"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 109
            };
        }
    }
}
