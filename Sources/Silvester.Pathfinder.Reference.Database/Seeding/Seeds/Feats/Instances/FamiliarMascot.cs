using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FamiliarMascot : Template
    {
        public static readonly Guid ID = Guid.Parse("8b2790b9-2783-4cb6-98ab-cca04a8353e7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Familiar Mascot",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32cd74ae-0344-4d08-8925-634ad79f1a3a"), Type = TextBlockType.Text, Text = "Your familiar is the heart and soul of your adventuring team. When selecting master abilities, you can choose an ally to benefit from any specific master ability. Each master ability can benefit only a single character, and you can select a specific master ability only once unless the ability says otherwise." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c2095222-869d-4491-8efa-e755deb16eb2"), Feats.Instances.FamiliarMasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7fe7eb7-4ea4-45b2-b81e-276568c9c229"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
