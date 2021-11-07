using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CraftersInstinct : Template
    {
        public static readonly Guid ID = Guid.Parse("31beab36-0685-41c3-931f-065a80456b33");

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
            yield return new TextBlock { Id = Guid.Parse("1347adfa-ea92-4c21-9128-f97ec794cc9c"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("bf80890d-cb23-41ee-bb3b-05191ecd1273"), Type = TextBlockType.Text, Text = "You sense a minor flaw in the weapon as you fire it, and quickly adjust your aim on the fly to avoid the flaw. If the triggering (action: Strike) was a (trait: misfire), you get a normal failure instead. If the triggering (action: Strike) was a failure, it becomes a glancing blow that deals minimum damage for the (action: Strike) (adding any bonuses as normal but getting a result of 1 for all damage dice that would be rolled on a success). The glancing blow does not apply other effects that would normally happen only on a hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("cb799479-a4d7-4123-9eb2-88de66075239"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89f3a0b0-07a7-4b4a-b08e-d35b25f26a4a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
