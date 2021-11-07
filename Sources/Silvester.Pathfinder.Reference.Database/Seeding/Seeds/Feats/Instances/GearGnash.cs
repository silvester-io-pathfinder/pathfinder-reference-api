using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GearGnash : Template
    {
        public static readonly Guid ID = Guid.Parse("24dffc7d-0b3f-4406-9e0f-c6bb720f42c4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gear Gnash",
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
            yield return new TextBlock { Id = Guid.Parse("a1fa1075-2091-42f7-b510-56982aa5107d"), Type = TextBlockType.Text, Text = "Snares you create have complicated inner workings that are quite difficult to disable. Creatures attempting to (action: Disable your snares | Disable a Device) that use gears must succeed at an additional Thievery check in order to disable the snare. On a failed check, while the snare doesn’t fully trigger, the grinding mechanisms deal bludgeoning damage to the creature equal to half your level. The snare still triggers on a critical failure, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1b3359ee-6699-439d-8daf-5ca4f1d8cef6"), Feats.Instances.TrapsmithDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("4e6c046a-ac12-4b37-b21e-297babfa9ae1"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0fa1bee2-e43a-4837-8696-6bcbef833594"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
