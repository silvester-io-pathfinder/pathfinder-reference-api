using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InnocentButterfly : Template
    {
        public static readonly Guid ID = Guid.Parse("9c0488a7-f78a-4cdf-874f-bfcea92cf6e6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Innocent Butterfly",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aee3aa3a-51e9-4656-ada0-0b10a7f60875"), Type = TextBlockType.Text, Text = "You know how to alter the perceptions of others. You can cast (spell: aura of the unremarkable) once per day as an innate arcane spell. The spell uses your class DC or spell DC, whichever is higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40382b5c-dcdc-4850-900c-af0febc0d7c5"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
