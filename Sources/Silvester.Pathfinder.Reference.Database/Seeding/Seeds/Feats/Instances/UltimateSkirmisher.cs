using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UltimateSkirmisher : Template
    {
        public static readonly Guid ID = Guid.Parse("6af10f35-345d-45fe-9449-9b3029284bc2");

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
            yield return new TextBlock { Id = Guid.Parse("a08f51a6-0548-4540-883c-74a902496749"), Type = TextBlockType.Text, Text = "You are so skilled at navigating the wild, your movement is completely unaffected by terrain. You ignore the effects of all difficult terrain, greater difficult terrain, and hazardous terrain, and you don’t trigger traps and hazards that are triggered by moving into an area (such as trip wires and pressure plates), unless you want to." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("8d4cd4c5-9571-46ce-b2c1-0e30554f3184"), ClassFeatures.Rangers.WildStride.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29e97d9a-9743-4435-8a5d-24f491156404"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
