using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VersatilePerformance : Template
    {
        public static readonly Guid ID = Guid.Parse("e607f665-49e6-4310-aec3-5dcf9d95cdfc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Versatile Performance",
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
            yield return new TextBlock { Id = Guid.Parse("3b1cc549-885e-4100-9d6e-0bdb6fd7c753"), Type = TextBlockType.Text, Text = "You can rely on the grandeur of your performances rather than ordinary social skills. You can use Performance instead of Diplomacy to (action: Make an Impression) and instead of Intimidation to (action: Demoralize). You can also use an acting Performance instead of Deception to (action: Impersonate). You can use your proficiency rank in Performance to meet the requirements of skill feats that require a particular rank in Deception, Diplomacy, or Intimidation." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("95ab023a-a315-4e53-a716-c0cee48f669b"), Muses.Instances.Polymath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2d063085-fdb8-4cc1-bd75-26c57cdad974"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
