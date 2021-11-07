using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExtendElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("53346c7f-5811-4d46-8170-5347523ecfe3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Extend Elixir",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e881c032-7686-4929-8ae5-bc744f18c5cc"), Type = TextBlockType.Text, Text = "Integrating your own personal energy into the elixirs you create causes them to affect you for longer. When you consume one of your alchemical items that has the (trait: elixir) and (trait: infused) traits and a duration of 1 minute or longer, that elixir’s duration is doubled." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac919d8b-a734-41e9-9479-548d187b9325"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
