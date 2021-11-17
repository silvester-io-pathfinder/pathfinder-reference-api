using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DriftersWake : Template
    {
        public static readonly Guid ID = Guid.Parse("2b9fe5b0-7a20-4035-b076-c0d3fcfe92fd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drifter's Wake",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5e522f1-9632-4a13-9627-c83b83aeb0e6"), Type = TextBlockType.Text, Text = "You drift across the battlefield, striking down foes as you go. You (action: Stride), and you can (action: Strike) up to three times at any points during your movement. Each attack must target a different enemy and must be made with a one-handed firearm, crossbow, melee weapon, or unarmed attack. Each attack counts toward your multiple attack penalty, but your multiple attack penalty doesn’t increase until you’ve made all your attacks. Your movement doesn’t trigger reactions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ce632d1-3d1f-42a9-9fcb-da2b6f38e8b2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
