using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FleetingShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("69201030-f10b-462a-98af-ca9f1fe3c53d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fleeting Shadow",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cd7cd43d-de9a-4c65-85b4-b5a215f92b5e"), Type = TextBlockType.Text, Text = "You’re able to quickly disappear and then move about stealthily. You (action: Hide), then (action: Sneak) twice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6dff23f5-8198-481e-8601-607e720345a8"), Feats.Instances.ScoutDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0351e55e-7f7f-4014-bf39-cae6ae3f27af"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
