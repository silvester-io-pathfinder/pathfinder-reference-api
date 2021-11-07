using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Irrepressible : Template
    {
        public static readonly Guid ID = Guid.Parse("656557f1-4ab7-47b8-a1f2-b73af424880d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Irrepressible",
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
            yield return new TextBlock { Id = Guid.Parse("7ae8b5ef-06b3-4a8e-9528-7637920ef54b"), Type = TextBlockType.Text, Text = "Your contrary nature means you bounce back with prejudice. When you roll a success on a save against an (trait: emotion) or (trait: fear) effect, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1512b349-7665-4dde-a60f-03b5407eacb0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
