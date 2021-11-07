using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReliableLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("57fa2b1e-c800-49fa-ba51-67cce3005325");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reliable Luck",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ab0fb7db-6e8c-4b15-a536-6dcc822b5d52"), Type = TextBlockType.Text, Text = "You have gone well past nine lives to survive danger with surprising regularity. You can use (feat: Cat&#39;s Luck) once per hour, rather than once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2c333063-0ef7-4e7b-b49e-5897b26a19ba"), Feats.Instances.CatsLuck.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14819a83-0e52-4915-aa5d-2c7470ed07dd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
