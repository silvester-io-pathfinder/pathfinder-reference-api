using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImplementsAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("0a65bdf7-b800-4ff2-b71c-635e010acd8a");

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
            yield return new TextBlock { Id = Guid.Parse("2f59dd15-f673-47e8-9f8c-b49ac804ba95"), Type = TextBlockType.Text, Text = "You use your implement to gather physical magic and channel it into your weapon, empowering it to shoot an impossible volley of missiles or soar across the battlefield and carve through your foes. Make a (action: Strike) with your weapon against each foe within 30 feet of you. Don't increase your multiple attack penalty until after making all the attacks. If your weapon is a melee weapon and any of the attacks are outside your reach, you (action: Release) the weapon before the (action: Strikes|Strike), and it returns to your grasp after all of them. If your hands are full when the weapon returns, it falls to the ground in your space. As normal, if your weapon requires one or more actions to reload between (action: Strikes|Strike), you can't use it to make multiple attacks with Implement's Assault." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ccde13bd-1c27-475c-9c61-a56f012794d7"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
