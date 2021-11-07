using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ParagonConstructCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("56442680-64e2-4477-839d-8dc9e20d3a03");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Paragon Construct Companion",
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
            yield return new TextBlock { Id = Guid.Parse("7506ae35-0177-4ad6-95c9-1b9920855fda"), Type = TextBlockType.Text, Text = "Your construct companion has reached the pinnacle of form and function. Your construct companion becomes a paragon construct companion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b35892ed-97e0-481a-8b40-3f1d2c5b7ce9"), Feats.Instances.IncredibleCompanion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb8c34e2-376b-4091-996c-9997ef3475ff"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
