using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DevastatingWeaponry : Template
    {
        public static readonly Guid ID = Guid.Parse("5460bb8e-37c2-457e-bc2c-23e7dd9d8213");

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
            yield return new TextBlock { Id = Guid.Parse("26d2d36c-6116-484b-9e6e-34fa3896a65b"), Type = TextBlockType.Text, Text = "You release a volley of projectiles from your weapon, or power it to fly in every direction across the battlefield and (action: Strike) multiple creatures. Make a (action: Strike) with your weapon innovation against each foe within 30 feet of you. Don’t increase your multiple attack penalty until after making all the attacks. If your innovation is a melee weapon and any of the attacks are outside your reach, you (action: Release) the weapon before the (action: Strikes | Strike), and it returns to your grasp after all of them. If your hands are full when the weapon returns, it falls to the ground in your space. As normal, if your weapon innovation requires one or more actions to reload between (action: Strikes | Strike), you can’t use it to make multiple attacks with Devastating Weaponry." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("bf5a69be-6d77-4da0-a0a1-e89579f73704"), Innovations.Instances.Weapon.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0f4d842-2d8e-4b34-b60a-69ad61809170"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
