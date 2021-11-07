using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SoaringFlight : Template
    {
        public static readonly Guid ID = Guid.Parse("40d3b6c0-eb8f-4a72-935d-b03a6ad20399");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soaring Flight",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9e09d1de-7ba5-442f-9caa-457a140bed41"), Type = TextBlockType.Text, Text = "To be a tengu is to be unburdened by the concerns of the world below. You grow a pair of magical wings or expand your existing ones. For 5 minutes, you gain a fly Speed equal to your land Speed or 20 feet, whichever is greater." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("34c20de2-48e2-4632-8d51-ef38f378962b"), Heritages.Instances.SkybornTengu.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b6ac2d4a-9e34-4b7d-8355-88529bf27e20"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
