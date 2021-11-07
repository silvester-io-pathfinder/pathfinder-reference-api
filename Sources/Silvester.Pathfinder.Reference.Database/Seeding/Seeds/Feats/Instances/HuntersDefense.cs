using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HuntersDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("4923116d-c8b1-472b-9952-f5ef66439eca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hunter's Defense",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature with the animal, beast, elemental, fey, fungus, or plant trait attacks you, and you can see the attacker.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("82ea14aa-ee12-4ae1-9ec0-8779b5f4cecc"), Type = TextBlockType.Text, Text = "Your canny understanding of natural and primal creatures helps you predict and dodge their attacks. The triggering attack roll targets your Nature DC instead of your AC. Though this allows you to avoid taking penalties to your AC, it doesn’t remove any conditions or other effects causing such penalties. For example, an enemy with sneak attack would still deal extra damage to you for being flat-footed, even though you wouldn’t take the –2 circumstance penalty against the attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e4a48ecd-76ed-4589-ada9-eada4ab08c53"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("daecdc43-b15d-42ba-b6f7-f3ca04e91edc"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
