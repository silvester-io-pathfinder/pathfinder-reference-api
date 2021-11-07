using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EfficientControls : Template
    {
        public static readonly Guid ID = Guid.Parse("f767c4a5-71f0-42f3-8024-5b535e500479");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Efficient Controls",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6ed468b0-e148-4bd3-a631-65e32463cbaa"), Type = TextBlockType.Text, Text = "By reducing redundant systems and streamlining essential functions, you have made it easier for the vehicle to operate with fewer crew. Reduce the number of crew required to operate your signature vehicle by 25%. For example, you would reduce a sailing ship from needing 1 pilot and 8 crew to 1 pilot and 6 crew. This adjustment only affects the number of crew needed to operate the vehicle; it doesn’t reduce the vehicle’s need for a pilot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("03fb6caa-21c0-413b-8dfb-34599a641ea9"), Feats.Instances.VehicleMechanicDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("2a133915-1c4d-4ac7-95a9-cd131019ae13"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03bef5fe-eb24-4cc6-8f6d-b536e4e84349"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
