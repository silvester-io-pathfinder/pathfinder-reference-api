using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualbornEarth : Template
    {
        public static readonly Guid ID = Guid.Parse("5df6c515-8544-4d40-aef4-3df971d40715");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dualborn - Earth",
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
            yield return new TextBlock { Id = Guid.Parse("70b734ef-bf6d-4483-a4ec-e507ff0281d9"), Type = TextBlockType.Text, Text = "You gain resistance equal to half your level (minimum 1) to all damaging effects with the (trait: earth) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c950273-c7d3-4e72-84bf-c339bd14bc9e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
