using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DanceUnderfoot : Template
    {
        public static readonly Guid ID = Guid.Parse("6a54f0d4-9cc3-4a6c-9922-0cd76e9e3963");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dance Underfoot",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("96056ff0-2d7f-46cf-89e9-3d9363cc210d"), Type = TextBlockType.Text, Text = "You dart under the legs of your enemies in combat. You can end a successful (action: Tumble Through) action in a Large or larger enemy’s space. Also, when using the (feat: Step Lively) feat, you can (action: Step) into the triggering enemy’s space. The enemy must have limbs or otherwise leave you enough room for this maneuver, as determined by the GM. For instance, you could share space with a giant or dragon, but not an ooze." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("98c80677-92d1-482c-ac7c-2f3c30bc165e"), Feats.Instances.StepLively.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8253d371-de50-450c-8c51-cf1272cbaa4f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
