using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OngoingSelfishness : Template
    {
        public static readonly Guid ID = Guid.Parse("1327fd14-bf00-4ef4-87b8-550141257a64");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ongoing Selfishness",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b66917e5-1873-44ef-8886-1519619548ab"), Type = TextBlockType.Text, Text = "Your powerful personality and incredible ego demand that you protect yourself above all else. After you use (feat: Selfish Shield), you gain resistance to all further damage from the triggering enemy until the end of the turn on which you used the reaction. This resistance is equal to half your (feat: Selfish Shield) resistance." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("60d7b15d-d243-4322-918e-74ff7d8115a5"), Causes.Instances.Desecrator.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5195e967-d8e4-4168-b88d-4286922fe8ad"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
