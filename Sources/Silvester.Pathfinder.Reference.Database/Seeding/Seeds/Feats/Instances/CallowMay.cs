using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallowMay : Template
    {
        public static readonly Guid ID = Guid.Parse("30c6ac21-9e04-4bd4-8b7c-4812504d214c");

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
            yield return new TextBlock { Id = Guid.Parse("60f26ad3-d4db-41c6-b964-375b8f62c3e2"), Type = TextBlockType.Text, Text = "You are among the most common of changelings – those born to green hags – and a vibrant green eye signifies that parentage. Your mother&#39;s manipulative nature and versatile voice gives you an edge when deceiving others. You gain the (feat: Charming Liar) skill feat. If you roll Deception for initiative, foes in that combat encounter that haven&#39;t acted yet are flat-footed against you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0ea20d1-14df-47e3-a0a3-507669742287"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
