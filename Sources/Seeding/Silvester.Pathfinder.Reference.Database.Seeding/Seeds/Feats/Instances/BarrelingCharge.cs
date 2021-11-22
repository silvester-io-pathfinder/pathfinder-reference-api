using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BarrelingCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("0535489b-b353-4977-8997-fca6395e562a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Barreling Charge",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("278071ff-fc40-4285-b187-4402beb89d81"), Type = TextBlockType.Text, Text = "You rush forward, moving enemies aside to reach your foe. You (action: Stride), attempting to move through your enemies' spaces and make a melee (action: Strike). Roll an Athletics check and compare the result to the Fortitude DC of each creature whose space you attempt to move through during your (action: Stride), moving through its space on a success but ending your movement before entering its space on a failure. You can use Barreling Charge to (action: Burrow), (action: Climb), (action: Fly), or (action: Swim) instead of (action: Stride), as long as you have the corresponding movement type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f1b25d92-1651-47e9-bd47-d85514ed4495"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("10962c36-458b-4de1-8ede-4c6e7f25b4e3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
