using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CoordinatedCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("8462adad-9e87-4454-987a-5e7be053d2eb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Coordinated Charge",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ca004f26-8c25-4c1f-a148-2beec230d03a"), Type = TextBlockType.Text, Text = "You heroically dash into the fray, inspiring your allies to follow. You (action: Stride) up to your Speed and make a melee (action: Strike). If your (action: Strike) hits and damages an enemy, each ally within 60 feet who saw you hit can use a reaction to (action: Stride), but they each must end their (action: Stride) closer to the creature you hit than where they started." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2ce5fc0d-9f07-4320-81e4-2c364618ee85"), Feats.Instances.MarshalDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26ea1902-a086-406f-a0c2-f00fc94e3139"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
