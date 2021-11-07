using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FountainOfSecrets : Template
    {
        public static readonly Guid ID = Guid.Parse("1ded659e-0225-41d5-9720-89bd032cdd84");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fountain of Secrets",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d51f987-0f10-4ca1-ad04-0efa402060d3"), Type = TextBlockType.Text, Text = "You constantly remember details about the world. You attempt a check to (action: Recall Knowledge). If you succeed, you gain additional information or context. If you critically succeed, at the GM’s discretion you might gain even more additional information or context than normal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2199a3d5-9573-41d1-b176-a93aa76bf88f"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
