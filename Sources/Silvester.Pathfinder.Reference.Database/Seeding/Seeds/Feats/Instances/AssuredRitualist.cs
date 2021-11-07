using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AssuredRitualist : Template
    {
        public static readonly Guid ID = Guid.Parse("b0f12316-aae0-4884-99a4-d0d220edd483");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Assured Ritualist",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5e561507-05d3-4f01-8bad-e316a55d23cf"), Type = TextBlockType.Text, Text = "You can cover for a secondary caster’s error. If you are the primary caster, after rolling all the secondary checks, choose one check on which the secondary caster rolled a failure or critical failure, and treat the result as one degree of success better." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("10b3eadd-6ba8-449c-83f7-ec032e70d019"), Feats.Instances.FlexibleRitualist.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13e0533c-15c7-475c-9c47-023fbffda673"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
