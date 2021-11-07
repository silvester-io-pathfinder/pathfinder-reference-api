using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EngineBay : Template
    {
        public static readonly Guid ID = Guid.Parse("5b24b5ed-c06a-4605-bed8-3ce4aaac49c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Engine Bay",
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
            yield return new TextBlock { Id = Guid.Parse("812091a3-3cb0-47d4-9a07-7708c51ad5ca"), Type = TextBlockType.Text, Text = "You are practiced at working in vast garages of vehicles and can work on many machines at a time. When (action: Repairing | Repair) and spending the full 10 minutes, you can fix up to two objects. If you are a master in Crafting, you can fix up to four targets. If you’re legendary in Crafting, you can fix up to eight targets. This feat has no effect when using (feat: Quick Repair) or another ability to reduce the time spent (action: Repairing | Repair)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("75f571c9-e65b-45bf-a547-5c4599a28b3d"), Feats.Instances.VehicleMechanicDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("30ae9529-c865-4483-a469-a485e708c1aa"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03a569de-a7c9-4fe7-84c6-372e3f7c1373"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
