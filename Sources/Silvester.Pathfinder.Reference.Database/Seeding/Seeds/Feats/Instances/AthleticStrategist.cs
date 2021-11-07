using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AthleticStrategist : Template
    {
        public static readonly Guid ID = Guid.Parse("92fba1b4-9cc8-407a-a2b5-9a0ea611911f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Athletic Strategist",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d62313cf-e3ab-412d-badf-b796790a7b52"), Type = TextBlockType.Text, Text = "You know how to calculatedly manipulate joints and body weight. In addition to using (feat: Devise a Stratagem) to modify a (action: Strike), you can use it to modify a (action: Disarm), (action: Grapple), (action: Shove), or (action: Trip) attempt, substituting your (feat: Devise a Stratagem) roll for the Athletics check. You must apply the substitution to the first eligible attack you make, whether it&#39;s a (action: Strike) or one of the Athletics actions." };
            yield return new TextBlock { Id = Guid.Parse("2083c2b9-e912-482b-8d1d-0b5941076a5b"), Type = TextBlockType.Text, Text = "You can also use your Intelligence modifier instead of Strength for the Athletics check when you substitute your (feat: Devise a Stratagem) roll, unless you&#39;re using a weapon for the maneuver and the weapon doesn&#39;t fit the restrictions for using Intelligence with a stratagem." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("70f6a0cb-c5d0-4ff9-b096-b65e39c11a5a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8c1cfd0-e70d-48fb-a123-481e009b6f2c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
