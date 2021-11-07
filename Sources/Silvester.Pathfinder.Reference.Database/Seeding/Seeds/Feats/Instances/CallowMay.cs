using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallowMay : Template
    {
        public static readonly Guid ID = Guid.Parse("0dfff0de-608a-42b6-b5d1-18627fd39277");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Callow May",
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
            yield return new TextBlock { Id = Guid.Parse("ba8f18df-ae58-4e9f-80a8-142e8c613331"), Type = TextBlockType.Text, Text = "You are among the most common of changelings – those born to green hags – and a vibrant green eye signifies that parentage. Your mother&#39;s manipulative nature and versatile voice gives you an edge when deceiving others. You gain the (feat: Charming Liar) skill feat. If you roll Deception for initiative, foes in that combat encounter that haven&#39;t acted yet are flat-footed against you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b766449e-513d-4830-8dc3-f9f1e2bb69b5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
