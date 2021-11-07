using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DevastatingWeaponry : Template
    {
        public static readonly Guid ID = Guid.Parse("3f36c9bb-3e79-471e-83a4-1cf6bea3414f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Devastating Weaponry",
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
            yield return new TextBlock { Id = Guid.Parse("3f0e31da-3c12-49a3-9ef8-58781c8c85c7"), Type = TextBlockType.Text, Text = "You release a volley of projectiles from your weapon, or power it to fly in every direction across the battlefield and (action: Strike) multiple creatures. Make a (action: Strike) with your weapon innovation against each foe within 30 feet of you. Don’t increase your multiple attack penalty until after making all the attacks. If your innovation is a melee weapon and any of the attacks are outside your reach, you (action: Release) the weapon before the (action: Strikes | Strike), and it returns to your grasp after all of them. If your hands are full when the weapon returns, it falls to the ground in your space. As normal, if your weapon innovation requires one or more actions to reload between (action: Strikes | Strike), you can’t use it to make multiple attacks with Devastating Weaponry." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("783263a6-75e3-4d17-8721-2612d651d8cb"), Innovations.Instances.Weapon.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92698bfc-b5e4-428b-8b2a-b5d76c591e5e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
