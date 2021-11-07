using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardensWellspring : Template
    {
        public static readonly Guid ID = Guid.Parse("0abbdcce-a8eb-46da-9d1b-6b9a6381ad02");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warden's Wellspring",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("924e7d2d-19d7-4884-893b-ff5d8c02fdf6"), Type = TextBlockType.Text, Text = "You command unparalleled focus when you commune with the world around you. If you have spent at least 3 Focus Points since the last time you (activity: Refocused | Refocus), you recover 3 Focus Points when you (activity: Refocus) instead of 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("472b3624-c517-4b0e-8a05-c941c223b4a2"), Feats.Instances.WardensFocus.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64f51725-b7bc-4898-b585-76ba95267a28"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
