using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TakedownExpert : Template
    {
        public static readonly Guid ID = Guid.Parse("843b224f-31db-4032-9678-222072399ad4");

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
            yield return new TextBlock { Id = Guid.Parse("211431c8-84da-4355-9c04-8425fcbbade7"), Type = TextBlockType.Text, Text = "You&#39;ve mastered combat practices that let you get up close and bring down perpetrators alive. You can use your Intelligence modifier on attack rolls when you (feat: Devise a Stratagem) if you&#39;re using a weapon of the club group in one hand (like a (item: club), (item: staff), or (item: sap)), in addition to the usual weapons, and those (action: Strikes | Strike) qualify for your strategic strike. Additionally, you can make any of your (action: Strikes | Strike) (trait: nonlethal) without taking the normal -2 penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b8a5791-1c5d-4379-924d-8225c3e45d85"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
