using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HarmingHands : Template
    {
        public static readonly Guid ID = Guid.Parse("38b28f9f-5456-4951-94ae-17eba4f7d950");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Harming Hands",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3077eb50-f730-41f8-ba3f-f1749b917043"), Type = TextBlockType.Text, Text = "The mordant power of your negative energy grows. When you cast (spell: harm), you roll d10s instead of d8s." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("2c8e9edf-c272-45f8-bf74-79af74263c10"), DivineFonts.Instances.Harm.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c1a52c8-601f-4e2d-a42c-695f4c951275"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
