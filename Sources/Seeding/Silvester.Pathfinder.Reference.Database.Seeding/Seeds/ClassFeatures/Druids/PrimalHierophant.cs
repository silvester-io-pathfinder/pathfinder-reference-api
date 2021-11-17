using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Druids
{
    public class PrimalHierophant : Template
    {
        public static readonly Guid ID = Guid.Parse("2322f9b3-6fdf-49e3-a82c-200977fb847d");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Primal Hierophant", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bbdb047a-5f73-4549-aa19-cd6e8a7a89be"), Type = TextBlockType.Text, Text = "You command the most potent forces of primal magic and can cast a spell of truly incredible power. You gain a single 10th-level spell slot and can prepare a spell in that slot using primal spellcasting. You can't use this spell slot for abilities that let you cast spells without expending spell slots or that give you more spell slots. You don't gain more 10th-level spells as you level up, though you can take the Hierophant's Power feat to gain a second slot." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellSlot(Guid.Parse("5362d941-2231-43b6-b6fe-464c05b3529a"), amount: 1, spellSlotLevel: 10, isSpendingPreventable: false);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc3af020-64c1-401a-979b-490bc39ce2ea"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 133
            };
        }
    }
}
