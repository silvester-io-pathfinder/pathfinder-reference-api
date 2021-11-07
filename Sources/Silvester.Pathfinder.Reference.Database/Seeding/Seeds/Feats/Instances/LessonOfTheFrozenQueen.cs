using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LessonOfTheFrozenQueen : Template
    {
        public static readonly Guid ID = Guid.Parse("524f7f9b-96dc-4ea6-9085-e77a8a60b29d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of the Frozen Queen",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2b41626d-0920-4d4b-a4f3-314f4ea32442"), Type = TextBlockType.Text, Text = "~ Lesson Type: Major" };
            yield return new TextBlock { Id = Guid.Parse("45a30731-bd3d-4a6d-ba00-246e2b831a7b"), Type = TextBlockType.Text, Text = "You gain the (spell: glacial heart) hex, and your familiar learns (spell: wall of ice)." };
            yield return new TextBlock { Id = Guid.Parse("e6da192e-e045-4881-9023-c6fe810d3986"), Type = TextBlockType.Text, Text = "A witch with Baba Yaga as a patron can select the lesson of the frozen queen when a feat or other effect grants a major lesson. Other witches who find secret knowledge or magic from Baba Yaga hidden in Irrisen or elsewhere might be able to uncover this rare lesson as well." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b3c6037-034d-4747-8177-9d63e8d82134"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
