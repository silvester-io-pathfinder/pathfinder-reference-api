using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UltimateSkirmisher : Template
    {
        public static readonly Guid ID = Guid.Parse("4cff2454-8377-49c8-849f-28764e2f7180");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ultimate Skirmisher",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cff976f0-9ea3-415f-b161-267e68ef9401"), Type = TextBlockType.Text, Text = "You are so skilled at navigating the wild, your movement is completely unaffected by terrain. You ignore the effects of all difficult terrain, greater difficult terrain, and hazardous terrain, and you don't trigger traps and hazards that are triggered by moving into an area (such as trip wires and pressure plates), unless you want to." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("98474f45-5f3e-4e67-a35c-f675c2720303"), ClassFeatures.Rangers.WildStride.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e4b211b-b3e3-4c10-a797-b71930a2b314"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
