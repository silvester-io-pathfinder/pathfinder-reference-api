using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualbornAir : Template
    {
        public static readonly Guid ID = Guid.Parse("55d1808e-f4e9-499f-a72f-3a964f887ac4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dualborn - Air",
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
            yield return new TextBlock { Id = Guid.Parse("761f91fe-9f6b-436a-b704-a3320b43cf4e"), Type = TextBlockType.Text, Text = "You gain resistance equal to half your level (minimum 1) to all damaging effects with the (trait: air) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c926bb76-225d-411e-935b-1be3b9eb65ee"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
