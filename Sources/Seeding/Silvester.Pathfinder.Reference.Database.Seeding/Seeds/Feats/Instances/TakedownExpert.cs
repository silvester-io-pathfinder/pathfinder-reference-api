using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TakedownExpert : Template
    {
        public static readonly Guid ID = Guid.Parse("d9f50e32-118f-4b63-9d87-361cd74a50f1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Takedown  Expert",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8525f67b-9127-43ad-8ed8-bd232bc17a58"), Type = TextBlockType.Text, Text = "You&#39;ve mastered combat practices that let you get up close and bring down perpetrators alive. You can use your Intelligence modifier on attack rolls when you (feat: Devise a Stratagem) if you&#39;re using a weapon of the club group in one hand (like a (item: club), (item: staff), or (item: sap)), in addition to the usual weapons, and those (action: Strikes | Strike) qualify for your strategic strike. Additionally, you can make any of your (action: Strikes | Strike) (trait: nonlethal) without taking the normal -2 penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad05d21a-9f51-4075-a8d5-6cc4eb2b81ce"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
