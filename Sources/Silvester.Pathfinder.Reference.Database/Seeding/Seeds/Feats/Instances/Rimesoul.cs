using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Rimesoul : Template
    {
        public static readonly Guid ID = Guid.Parse("2d63c3db-eccf-431f-a778-78bf19daa1fb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rimesoul",
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
            yield return new TextBlock { Id = Guid.Parse("3be56ca0-9995-42ce-8de1-3574f1668f1b"), Type = TextBlockType.Text, Text = "The water inside you is cold and frozen, like sheets of ice and frigid glaciers. You gain resistance to cold equal to half your level (minimum 1), and you treat environmental cold effects as if they were one step less severe (incredible cold becomes extreme, extreme cold becomes severe, and so on)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85bf4e96-f69e-44c5-b7cd-1860c8caf614"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
