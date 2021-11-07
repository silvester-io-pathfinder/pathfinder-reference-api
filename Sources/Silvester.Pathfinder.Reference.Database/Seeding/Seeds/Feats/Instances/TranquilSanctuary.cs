using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TranquilSanctuary : Template
    {
        public static readonly Guid ID = Guid.Parse("3b79c577-73c5-49e3-9981-6c7b0648c47b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tranquil Sanctuary",
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
            yield return new TextBlock { Id = Guid.Parse("510cb00b-f1be-481c-904b-159c6ead391d"), Type = TextBlockType.Text, Text = "Whenever possible, you follow the serene path and encourage others to do the same. You can cast (spell: sanctuary) once per day as a 1st-level divine innate spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6d109cb7-3869-46f1-baa3-0570e77a7878"), Feats.Instances.Idyllkin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f29f8db-0baf-4de4-be74-0a22af813bcc"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
