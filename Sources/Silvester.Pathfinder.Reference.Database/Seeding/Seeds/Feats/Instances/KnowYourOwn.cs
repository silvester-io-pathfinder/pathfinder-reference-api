using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KnowYourOwn : Template
    {
        public static readonly Guid ID = Guid.Parse("6f989e0d-e768-41af-aa9e-db2ce1f4738d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Know Your Own",
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
            yield return new TextBlock { Id = Guid.Parse("8aa24aec-9f02-4775-87f0-7099621bf5e2"), Type = TextBlockType.Text, Text = "You’ve spent countless hours studying the history of elves on your world and beyond and are a studied expert in your people’s ways. If you critically fail a check to (action: Recall Knowledge) about elves, elven society, or elven history, you get a failure instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1cd0edf3-ef7c-4aa6-b04c-ed50d673ee31"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
