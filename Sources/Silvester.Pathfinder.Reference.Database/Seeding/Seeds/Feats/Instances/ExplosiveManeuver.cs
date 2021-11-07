using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExplosiveManeuver : Template
    {
        public static readonly Guid ID = Guid.Parse("3c7ca778-1b1e-4f0d-a885-5f6970e79568");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Explosive Maneuver",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("323be6a5-a2e8-4c1a-9ec4-052359175c8b"), Type = TextBlockType.Text, Text = "Thanks to a hidden experimental feature you built into your weapon, your weapon explosively deploys levers, tangling hooks, or similar mechanisms to provide significant assistance when you perform a combat maneuver. When you use Explosive Maneuver, choose (action: Grapple), (action: Shove), or (action: Trip). Your weapon innovation must have a weapon trait that matches the action you chose (for instance, to choose (action: Grapple), your weapon must have the (trait: grapple) trait). You take the chosen action against the same foe as your previous successful (action: Strike), using the same multiple attack penalty as your previous successful (action: Strike). You still increase your multiple attack penalty after the (action: Grapple), (action: Shove), or (action: Trip), as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("31d550ef-4481-4d0c-9b5e-366dbc615579"), Innovations.Instances.Weapon.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d27ca855-a7d0-4464-abe6-19f7d6e698fd"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
