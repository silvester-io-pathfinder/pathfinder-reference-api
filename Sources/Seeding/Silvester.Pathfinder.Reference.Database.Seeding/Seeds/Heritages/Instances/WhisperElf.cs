using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class WhisperElf : Template
    {
        public static readonly Guid ID = Guid.Parse("3cd57ab7-c57a-4287-82ce-e1473f75af48");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Whisper Elf"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4cad8a21-2b90-430f-9ee2-bc76190ac727"), Type = TextBlockType.Text, Text = "You're adapted to life in the forest or the deep jungle, and you know how to climb trees and use foliage to your advantage. When Climbing trees, vines, and other foliage, you move at half your Speed on a success and at full Speed on a critical success (and you move at full Speed on a success if you have Quick Climb). This doesn't affect you if you're using a climb Speed. You can always use the Take Cover action when you are within forest terrain to gain cover, even if you're not next to an obstacle you can Take Cover behind." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("567b9d26-a39b-4e17-822e-1a534332e434"), "When Climbing trees, vines, and other foliage, you move at half your Speed on a success and at full Speed on a critical success (and you move at full Speed on a success if you have Quick Climb).");
            builder.Manual(Guid.Parse("f8acb997-cfce-453f-ba9b-84eb6de31bce"), "You can always use the Take Cover action when you are within forest terrain to gain cover, even if you're not next to an obstacle you can Take Cover behind.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c962cc1-c059-4346-ad1f-7ecf7743eac7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 40
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Elf.ID;
        }
    }
}
