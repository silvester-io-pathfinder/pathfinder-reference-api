using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImplementsAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("3b8afe32-aeac-419d-bf8c-79f8fbc2950b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Implement's Assault",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e14f0a6-06c5-4040-b828-5eb4e86c884d"), Type = TextBlockType.Text, Text = "You use your implement to gather physical magic and channel it into your weapon, empowering it to shoot an impossible volley of missiles or soar across the battlefield and carve through your foes. Make a (action: Strike) with your weapon against each foe within 30 feet of you. Don’t increase your multiple attack penalty until after making all the attacks. If your weapon is a melee weapon and any of the attacks are outside your reach, you (action: Release) the weapon before the (action: Strikes|Strike), and it returns to your grasp after all of them. If your hands are full when the weapon returns, it falls to the ground in your space. As normal, if your weapon requires one or more actions to reload between (action: Strikes|Strike), you can’t use it to make multiple attacks with Implement’s Assault." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd2e2541-8be0-4d4d-9c00-9014290d3cc0"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
