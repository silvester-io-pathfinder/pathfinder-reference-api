using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlazingStreak : Template
    {
        public static readonly Guid ID = Guid.Parse("3c2b7821-e08e-4811-a5e9-9f9964b04510");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blazing Streak",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c0dc6046-e74d-4c62-aa99-7f12913b311a"), Type = TextBlockType.Text, Text = "(action: Stride) twice, making (action: Strikes | Strike) against up to four different creatures within reach at any point during your movement. Flashing sparks (action: Strikes | Strike) made during Blazing Streak deal fire damage instead of slashing." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("814b7f00-8db9-4587-a1d8-793febf61c98"), Feats.Instances.StokedFlameStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89f9be4b-4c4c-4407-9f2e-6bfc07ff6aa3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
