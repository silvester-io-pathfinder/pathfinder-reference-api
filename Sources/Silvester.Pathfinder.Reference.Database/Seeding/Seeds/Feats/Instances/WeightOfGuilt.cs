using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WeightOfGuilt : Template
    {
        public static readonly Guid ID = Guid.Parse("fae1b82a-d30f-4d64-b4ba-e2089ee0be22");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Weight of Guilt",
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
            yield return new TextBlock { Id = Guid.Parse("996cef5c-e283-49eb-b809-c7fe4ae379f3"), Type = TextBlockType.Text, Text = "Guilt clouds the minds of those who ignore your (feat: Glimpse of Redemption). Instead of making the triggering creature enfeebled 2, you can make it stupefied 2 for the same duration." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("93efd0e0-0935-4637-85b3-865ff6f3db7f"), Causes.Instances.Redeemer.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33b4a8e2-7eb6-4b00-890b-60b2207f4f62"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
