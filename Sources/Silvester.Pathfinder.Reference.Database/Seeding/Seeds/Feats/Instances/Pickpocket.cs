using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Pickpocket : Template
    {
        public static readonly Guid ID = Guid.Parse("4823d08c-fb12-487d-9d3a-77b99509700e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pickpocket",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c463954-e48f-41ac-a4e8-a84a5e4d913d"), Type = TextBlockType.Text, Text = "You can (Action: Steal) or (Action: Palm an Object) that’s closely guarded, such as in a pocket, without taking the -5 penalty. You can’t steal objects that would be extremely noticeable or time consuming to remove (like worn shoes or armor or actively wielded objects). If you’re a master in Thievery, you can attempt to (Action: Steal) from a creature in combat or otherwise on guard. When doing so, (Action: Stealing | Steal) requires 2 manipulate actions instead of 1, and you take a -5 penalty." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("cd45d5a5-e8fb-499e-9c51-f6c1548479af"), Proficiencies.Instances.Trained.ID, Skills.Instances.Thievery.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb213432-be0b-40d5-8320-e54aaf867784"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
