using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpringFromTheShadows : Template
    {
        public static readonly Guid ID = Guid.Parse("71834638-b69e-4a69-9cbc-960491aaba13");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spring from the Shadows",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("36fdfaec-488d-49aa-8a79-a88d4d584cce"), Type = TextBlockType.Text, Text = "Leaping out from hiding, you assail your target when they least expect it. You (action: Stride) up to your Speed, but you must end your movement next to an enemy you’re hidden from or undetected by. You then (action: Strike) that enemy; you remain hidden from or undetected by that creature until after you (action: Strike). You can use Spring from the Shadows while (action: Burrowing | Burrow), (action: Climbing | Climb), (action: Flying | Fly), or (action: Swimming | Swim) instead of (action: Striding | Stride) if you have the corresponding movement type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fe859dc1-a82c-4240-a2af-0d69e854bf3e"), Feats.Instances.ShadowdancerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("096b9e2f-a209-4f9a-b044-7e73860f6a25"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
