using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationAdvancedRangefinder : Template
    {
        public static readonly Guid ID = Guid.Parse("1d9dfcc8-d1e4-442f-b213-0d79cdf4fc11");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Advanced Rangefinder",
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
            yield return new TextBlock { Id = Guid.Parse("d677f800-64af-4ebc-a676-04182c9f9d0a"), Type = TextBlockType.Enumeration, Text = "*Ranged Only**" };
            yield return new TextBlock { Id = Guid.Parse("d017079a-6b2d-4010-b27b-b0e7a8388ace"), Type = TextBlockType.Text, Text = "A carefully tuned scope or targeting device makes your weapon especially good at hitting weak points. Your innovation gains the (trait: backstabber) trait and increases its range increment by 10 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81b56080-5af9-4477-8330-da7ce827b032"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
