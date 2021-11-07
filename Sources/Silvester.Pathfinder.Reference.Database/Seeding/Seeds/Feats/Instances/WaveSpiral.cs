using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WaveSpiral : Template
    {
        public static readonly Guid ID = Guid.Parse("f5a0216d-1fd6-47df-8e2d-10a4de9ee539");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wave Spiral",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e4482e6d-e49f-48e1-95f3-0518b3ac4eba"), Type = TextBlockType.Text, Text = "You dip and spin, unleashing a wide whirlpool of water. Make an Athletics check to (action: Trip) each creature standing on the ground in a 10-foot emanation. These attacks all count toward your multiple attack penalty, but the penalty doesn’t increase until after you make all the attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6c2b5371-fac9-40a7-a25d-5e24950c1fe4"), Feats.Instances.ReflectiveRippleStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("679882e2-86e4-4baa-84a8-8e297eeb6753"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
