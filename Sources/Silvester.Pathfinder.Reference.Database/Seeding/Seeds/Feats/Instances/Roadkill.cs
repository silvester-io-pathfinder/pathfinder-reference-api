using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Roadkill : Template
    {
        public static readonly Guid ID = Guid.Parse("5b47d4cf-a4ee-420b-825b-c5d80c6f91cf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Roadkill",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("853b1bfb-b0a0-4183-8213-5dd938109404"), Type = TextBlockType.Text, Text = "In your hands, any vehicle is a weapon. When you use Run Over, you can use your class DC in place of the vehicle’s collision DC. Your vehicle can Run Over any number of creatures up to one Size smaller than the vehicle or ram any one target creature or object in your path up to the size of your vehicle." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1c532128-9a3f-4040-816b-ad2115d96eaa"), Feats.Instances.TrickDriverDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81e358e0-ceac-4f27-82f3-7e4e3127f3f3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
