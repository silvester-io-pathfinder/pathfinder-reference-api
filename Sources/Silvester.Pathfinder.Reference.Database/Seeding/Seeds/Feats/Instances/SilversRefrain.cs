using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SilversRefrain : Template
    {
        public static readonly Guid ID = Guid.Parse("0fb4217a-bacc-49cb-92ee-15caa3fd30a2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Silver's Refrain",
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
            yield return new TextBlock { Id = Guid.Parse("3b122a79-1277-4c02-95dd-7ce14d96b1cc"), Type = TextBlockType.Text, Text = "~ Access: Have earnt Mialari Docur’s trust and have proven their worth by defeating the Scarlet Triad." };
            yield return new TextBlock { Id = Guid.Parse("a6c53f0d-2ae6-46b4-b9d1-2677a8387ef1"), Type = TextBlockType.Text, Text = "You learn the (spell: silver’s refrain) composition cantrip, which aids you when fighting devils." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a158eef3-4b58-4c94-801e-9e83f7cf78dd"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
