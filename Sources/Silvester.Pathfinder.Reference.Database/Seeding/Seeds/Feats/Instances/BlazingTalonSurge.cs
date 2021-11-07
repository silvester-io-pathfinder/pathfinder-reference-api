using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlazingTalonSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("b1cc1827-4ade-46de-88d8-5a0961cb9f32");

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
            yield return new TextBlock { Id = Guid.Parse("380e3105-f265-4b29-9cdb-bd254152bf4b"), Type = TextBlockType.Text, Text = "You rush forward and latch onto your enemy with talons of hungering fire. (action: Stride) once. If you end your movement within reach of at least one enemy, you can make a fire talon (action: Strike) against that enemy that deals an additional 1d4 persistent fire damage. If it hits and deals damage, you can attempt an Athletics check to (action: Grapple) the creature you hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("56367128-2fa6-485d-9851-87bc74e130c1"), Feats.Instances.RainOfEmbersStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea205139-820d-4167-912c-bec76c8156a4"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
