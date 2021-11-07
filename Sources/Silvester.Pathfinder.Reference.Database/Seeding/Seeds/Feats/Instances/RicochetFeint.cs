using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RicochetFeint : Template
    {
        public static readonly Guid ID = Guid.Parse("b4b49f8c-ef28-4bb4-87b4-adb8bbd4b8f3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ricochet Feint",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("81fd9755-289a-442a-b84f-0d78b0f71055"), Type = TextBlockType.Text, Text = "While in (feat: Ricochet Stance), you can bounce a thrown weapon off a foe to distract them. You can attempt a (action: Feint) against a creature within the first range increment of a thrown weapon you are wielding, rather than only creatures within your melee reach." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6858bbb0-9ef0-4692-876b-235240289966"), Feats.Instances.RicochetStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("832a122a-8da9-4c30-8568-c25de5cecfc8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
