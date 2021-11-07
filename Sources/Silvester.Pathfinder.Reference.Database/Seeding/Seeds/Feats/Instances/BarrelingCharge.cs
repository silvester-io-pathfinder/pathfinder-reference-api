using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BarrelingCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("aa543e31-f586-466f-b68c-25e00d114073");

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
            yield return new TextBlock { Id = Guid.Parse("4ea9c193-9ba2-4696-9fa8-9e99a51547d9"), Type = TextBlockType.Text, Text = "You rush forward, moving enemies aside to reach your foe. You (action: Stride), attempting to move through your enemies’ spaces and make a melee (action: Strike). Roll an Athletics check and compare the result to the Fortitude DC of each creature whose space you attempt to move through during your (action: Stride), moving through its space on a success but ending your movement before entering its space on a failure. You can use Barreling Charge to (action: Burrow), (action: Climb), (action: Fly), or (action: Swim) instead of (action: Stride), as long as you have the corresponding movement type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("86e89176-f4d0-42bd-a754-8f79c578eb68"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e334eff9-791f-4e99-9de5-5b5886643604"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
