using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CraftPhilosophersStone : Template
    {
        public static readonly Guid ID = Guid.Parse("069a99bf-73c4-4f78-9436-d88b45dcd612");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Craft Philosopher's Stone",
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
            yield return new TextBlock { Id = Guid.Parse("a21cda68-df11-4598-89ae-837259f58c1c"), Type = TextBlockType.Text, Text = "Your research has paid off, culminating in the legendary philosopher’s stone. You learn the formula for the (item: philosopher&#39;s stone) and can add it to your formula book." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b47068ef-11cf-4c63-a0bb-b7bacd09e647"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
