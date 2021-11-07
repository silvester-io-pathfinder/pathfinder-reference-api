using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoundlessReprisals : Template
    {
        public static readonly Guid ID = Guid.Parse("dcd9d49e-906c-46d3-89b4-abdd8d8660f1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Boundless Reprisals",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d5015aa-e1e4-4341-9fbc-1d9deb128978"), Type = TextBlockType.Text, Text = "With a sixth sense for the flow of combat, you can quickly react to any situation as required. At the start of each enemy’s turn, you gain a reaction you can use only during that turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de432edb-f53f-4804-b8e9-4dfff3cfa5a1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
