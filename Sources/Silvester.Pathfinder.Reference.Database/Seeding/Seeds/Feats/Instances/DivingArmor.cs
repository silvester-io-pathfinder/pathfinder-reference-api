using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivingArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("7e05f51e-672d-4875-87cf-5525f853dccc");

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
            yield return new TextBlock { Id = Guid.Parse("42f47bd3-c38c-4f1c-9da2-704f98ce267a"), Type = TextBlockType.Text, Text = "You’ve modified your armor with fins, rotors, and other devices to make it easy for you to move through the water, plus mechanical gills that can help you extract breathable air from water. While wearing your armor innovation, you can breathe underwater and gain a swim Speed equal to your land Speed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("08b81065-3603-4934-8c05-2a0406999abf"), Innovations.Instances.Armor.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b7da1c6-325f-4813-9eaa-2b5d718f4119"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
