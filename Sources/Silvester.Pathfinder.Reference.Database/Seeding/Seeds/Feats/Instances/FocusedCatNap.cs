using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FocusedCatNap : Template
    {
        public static readonly Guid ID = Guid.Parse("27944abd-4daa-4949-b978-3bec33ecb5f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Focused Cat Nap",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5cba0234-861a-4545-8091-b3178ec09030"), Type = TextBlockType.Text, Text = "When you (feat: Cat Nap), you can also (activity: Refocus) as you dream of a relevant activity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9a2a6b54-834b-4978-8507-ccd2f2453a43"), Feats.Instances.CatNap.ID);
            builder.HaveFocusPool(Guid.Parse("cf5eef81-89bf-4fc1-82f3-e83374402a17"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b1cbddb-cc8c-4666-bea8-f967fb1ae253"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
