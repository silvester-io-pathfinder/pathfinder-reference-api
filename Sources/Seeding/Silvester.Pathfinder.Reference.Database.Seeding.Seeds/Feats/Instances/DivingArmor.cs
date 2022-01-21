using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivingArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("82c56f18-5daf-4278-aed7-f94e9f4ba026");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diving Armor",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("925bf06a-6033-43e8-9f45-6d4d26db719c"), Type = TextBlockType.Text, Text = $"You've modified your armor with fins, rotors, and other devices to make it easy for you to move through the water, plus mechanical gills that can help you extract breathable air from water. While wearing your armor innovation, you can breathe underwater and gain a swim Speed equal to your land Speed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("9c6401a4-7f96-455f-b618-33fdc6f1a9b4"), Innovations.Instances.Armor.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbb84654-d93c-4938-b0af-25ada3003880"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
