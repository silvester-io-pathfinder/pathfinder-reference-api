using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AssuredRitualist : Template
    {
        public static readonly Guid ID = Guid.Parse("7ab60666-b7f7-4d82-bc89-4c393ce3b66d");

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
            yield return new TextBlock { Id = Guid.Parse("92af8be4-c367-4e04-90e0-44f9698dbc4f"), Type = TextBlockType.Text, Text = "You can cover for a secondary caster's error. If you are the primary caster, after rolling all the secondary checks, choose one check on which the secondary caster rolled a failure or critical failure, and treat the result as one degree of success better." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0b69476f-b1c2-4fa9-b97f-58d215349319"), Feats.Instances.FlexibleRitualist.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa4695dc-39f4-4ffa-9e92-e89b9b7dd100"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
