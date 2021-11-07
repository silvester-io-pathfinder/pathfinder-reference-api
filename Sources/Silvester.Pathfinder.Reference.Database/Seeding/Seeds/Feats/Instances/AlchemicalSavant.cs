using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlchemicalSavant : Template
    {
        public static readonly Guid ID = Guid.Parse("d72480a8-67bc-4b22-818c-278e147c3652");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Alchemical Savant",
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
            yield return new TextBlock { Id = Guid.Parse("5f410196-daf5-46c2-933b-dea6885c7513"), Type = TextBlockType.Text, Text = "You can identify alchemical items quickly. When using the Crafting skill to (action: Identify Alchemy) on an alchemical item you hold, you can do so as a single action, which has the (trait: concentrate) and (trait: manipulate) traits, instead of spending 10 minutes. If you have the formula for the item you are attempting to identify, you gain a +2 circumstance bonus to your check, and if you roll a critical failure, you get a failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e21838e6-d417-484c-917a-60b3851edc2f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ff81ecf-1ba6-49c1-9124-d0e9026e4f07"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
