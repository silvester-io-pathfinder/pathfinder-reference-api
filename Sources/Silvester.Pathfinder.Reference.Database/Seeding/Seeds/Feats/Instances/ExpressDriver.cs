using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpressDriver : Template
    {
        public static readonly Guid ID = Guid.Parse("65762412-390d-4c89-a4c9-52b8d1568407");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Express Driver",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("efbf5fb6-852b-430e-80e9-9bc39f51028f"), Type = TextBlockType.Text, Text = "You can optimize your vehicle’s performance, coaxing extra speed and choosing paths to avoid slowdowns. When calculating your travel speed for the day while piloting a vehicle, you can attempt a Driving Lore check to increase your vehicle’s travel speed. The DC is determined by the GM but is typically based on the vehicle’s piloting DC or a difficulty based on the environment, whichever is harder. On a success, increase your vehicle’s travel speed by half. This has no effect on your vehicle’s movement in encounters." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4b9e960a-c2d3-4bea-90f0-3dc67cdb78bc"), Feats.Instances.TrickDriverDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7cae7209-fdd1-4e4a-b228-37ff1638ac7a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
