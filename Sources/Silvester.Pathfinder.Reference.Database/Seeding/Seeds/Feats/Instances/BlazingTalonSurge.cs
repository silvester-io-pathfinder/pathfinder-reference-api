using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlazingTalonSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("07bc8c35-17eb-4180-9e69-f9e143deae10");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blazing Talon Surge",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34a7ea24-b515-4ac8-8ab5-a42cdcb45022"), Type = TextBlockType.Text, Text = "You rush forward and latch onto your enemy with talons of hungering fire. (action: Stride) once. If you end your movement within reach of at least one enemy, you can make a fire talon (action: Strike) against that enemy that deals an additional 1d4 persistent fire damage. If it hits and deals damage, you can attempt an Athletics check to (action: Grapple) the creature you hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0b86b901-f4ad-4392-9a54-aadb87de3e49"), Feats.Instances.RainOfEmbersStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48234c15-abfc-4a31-b4af-7142c05154b1"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
