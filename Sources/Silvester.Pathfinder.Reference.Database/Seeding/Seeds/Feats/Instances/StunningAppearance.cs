using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StunningAppearance : Template
    {
        public static readonly Guid ID = Guid.Parse("4b7e5394-d33d-44d1-a1d2-89957dbaafa7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stunning Appearance",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("92dde9e0-9218-4ff1-84b3-5e9dd0d37d0f"), Type = TextBlockType.Text, Text = "Your sudden appearance leaves your foe unable to respond. When you use (feat: Startling Appearance), if your foe’s level is equal to or lower than yours, they are also stunned 1 on a hit, or stunned 2 on a critical hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("637aa8fe-83d4-4ad5-abe4-f879abb87563"), Feats.Instances.StartlingAppearance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbe6b392-7562-4052-b53c-686a8eb0aec4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
