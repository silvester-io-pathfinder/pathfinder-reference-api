using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeapAndFire : Template
    {
        public static readonly Guid ID = Guid.Parse("8accd553-6767-4c59-86be-f14bdb890385");

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
            yield return new TextBlock { Id = Guid.Parse("420ebee3-21c8-477a-9d1f-ea44b7f0b53e"), Type = TextBlockType.Text, Text = "You’re quick enough to line up a shot even while diving to the ground. When you use your (feat: Hit the Dirt!) reaction, at any point during your (action: Leap) you can also make a ranged (action: Strike) with a loaded firearm or crossbow, targeting the creature whose attack triggered the reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b25f05a4-b7ed-4e51-af9e-112cdd3d50cc"), Feats.Instances.HitTheDirt.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1880c0ba-3a07-4310-b7a7-4c7cb5c77d51"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
