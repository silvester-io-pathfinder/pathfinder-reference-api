using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ResoundingBlow : Template
    {
        public static readonly Guid ID = Guid.Parse("b6f6ba4a-14df-484b-845d-ef7ce85a8a29");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resounding Blow",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1dc1d3a8-d4b5-453e-b660-2665bb49bba2"), Type = TextBlockType.Text, Text = "You strike your enemy in the head with such force that their ears ring. Make a melee (action: Strike). If the (action: Strike) hits and deals damage, the target is deafened until the start of your next turn (or for 1 minute on a critical hit)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8b13df7-32d8-49d6-a03c-d1dd58c6d23e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
