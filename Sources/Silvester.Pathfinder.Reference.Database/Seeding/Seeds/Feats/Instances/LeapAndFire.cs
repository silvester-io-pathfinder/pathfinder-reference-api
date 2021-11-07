using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeapAndFire : Template
    {
        public static readonly Guid ID = Guid.Parse("8e8d119a-1242-4ff3-9d97-dcf877ade12b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Leap and Fire",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b919861a-314e-4247-8884-fa1b255d4c93"), Type = TextBlockType.Text, Text = "You’re quick enough to line up a shot even while diving to the ground. When you use your (feat: Hit the Dirt!) reaction, at any point during your (action: Leap) you can also make a ranged (action: Strike) with a loaded firearm or crossbow, targeting the creature whose attack triggered the reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("31dbbb62-2199-4fe0-915d-482942d83a4b"), Feats.Instances.HitTheDirt.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ccacea77-72cb-4960-b0f3-f987e501319a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
