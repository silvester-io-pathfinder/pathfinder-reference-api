using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlazingStreak : Template
    {
        public static readonly Guid ID = Guid.Parse("eae0539e-fb29-4c16-9505-8049e452213a");

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
            yield return new TextBlock { Id = Guid.Parse("7feba25c-7946-45ee-b013-9de9c1345d33"), Type = TextBlockType.Text, Text = "(action: Stride) twice, making (action: Strikes | Strike) against up to four different creatures within reach at any point during your movement. Flashing sparks (action: Strikes | Strike) made during Blazing Streak deal fire damage instead of slashing." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("93bad6bb-87cc-4489-95d1-7a0f7fc69e61"), Feats.Instances.StokedFlameStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8c93784-6a15-4f07-beda-3b67849cc9aa"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
