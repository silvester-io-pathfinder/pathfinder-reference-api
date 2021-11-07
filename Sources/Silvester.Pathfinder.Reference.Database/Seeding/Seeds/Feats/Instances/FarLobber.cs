using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FarLobber : Template
    {
        public static readonly Guid ID = Guid.Parse("eb863186-b31f-4329-911e-b87ae8bf18f4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Far Lobber",
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
            yield return new TextBlock { Id = Guid.Parse("f6e43553-7bc5-4ec7-838b-496de7286cbd"), Type = TextBlockType.Text, Text = "You’ve learned how to throw a longer distance. When you throw an alchemical bomb, it has a range increment of 30 feet instead of the usual 20 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("540ce739-ce07-4d92-bf5f-267c7435bceb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
