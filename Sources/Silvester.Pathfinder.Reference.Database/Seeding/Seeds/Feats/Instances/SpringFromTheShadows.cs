using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpringFromTheShadows : Template
    {
        public static readonly Guid ID = Guid.Parse("bc3da29e-d52d-4f50-a150-d97fcd58db44");

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
            yield return new TextBlock { Id = Guid.Parse("a9a4f62b-3bc8-45dc-8196-38dbacb6e5dc"), Type = TextBlockType.Text, Text = "Leaping out from hiding, you assail your target when they least expect it. You (action: Stride) up to your Speed, but you must end your movement next to an enemy you’re hidden from or undetected by. You then (action: Strike) that enemy; you remain hidden from or undetected by that creature until after you (action: Strike). You can use Spring from the Shadows while (action: Burrowing | Burrow), (action: Climbing | Climb), (action: Flying | Fly), or (action: Swimming | Swim) instead of (action: Striding | Stride) if you have the corresponding movement type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("41fd9082-df67-4ab9-972e-3aae762364fb"), Feats.Instances.ShadowdancerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d5dcc72-d7e1-4d5f-a0be-27b44d7abdbf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
