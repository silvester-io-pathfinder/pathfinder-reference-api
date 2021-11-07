using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BashingCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("b473356b-751a-47e0-abe3-26eaf8a3ab9b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bashing Charge",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("883b9194-c53b-40dc-a29d-fb4ed3cda5ac"), Type = TextBlockType.Text, Text = "You smash, bust, and charge through solid obstacles without hesitation. (action: Stride) twice. Once during your movement, if your movement passes through or ends adjacent to a door, window, fence, wall, or similar obstacle, you can attempt an Athletics check to (action: Force Open) the obstacle with a +1 circumstance bonus to the roll; on a failure, your movement ends at that obstacle." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("02520d9f-718a-45f3-8101-d8c2e9ca4f13"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2d7fdd7-47c3-4abd-acd0-9a90cd703bfc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
