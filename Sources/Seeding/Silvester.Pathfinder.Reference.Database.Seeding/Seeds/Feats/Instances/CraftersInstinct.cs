using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CraftersInstinct : Template
    {
        public static readonly Guid ID = Guid.Parse("8d3c5a20-e7f9-48a9-aca6-e35e217051b6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crafter's Instinct",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You misfire with a firearm or you roll a failure on a Strike with a ranged weapon.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("56700ac9-325c-4f32-b666-1fc0ee94c6fb"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("7ad1fef2-c632-4596-9a96-727497a33e3d"), Type = TextBlockType.Text, Text = "You sense a minor flaw in the weapon as you fire it, and quickly adjust your aim on the fly to avoid the flaw. If the triggering (action: Strike) was a misfire, you get a normal failure instead. If the triggering (action: Strike) was a failure, it becomes a glancing blow that deals minimum damage for the (action: Strike) (adding any bonuses as normal but getting a result of 1 for all damage dice that would be rolled on a success). The glancing blow does not apply other effects that would normally happen only on a hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0100ecd1-d9c4-404d-a2c8-2db0b367d0dc"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d01a347e-8b40-4370-8c0a-1f40b5ee66f4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
