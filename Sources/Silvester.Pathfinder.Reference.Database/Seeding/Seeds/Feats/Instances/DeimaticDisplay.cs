using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeimaticDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("02dead39-5857-4a3e-b2c7-05bfbaceb9e8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deimatic Display",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("93b17aff-9e25-4043-893c-020784b91647"), Type = TextBlockType.Text, Text = "Imitating animal threat displays, you make yourself appear larger and more imposing. Roll one Intimidation check to (action: Demoralize) and compare the result to the Will DC of each animal, fungus, and plant creature in a 15-foot cone. When you do, (action: Demoralize) gains the (trait: visual) trait, and creatures are affected if they can see you. You don’t take a penalty if the creature doesn’t understand your language." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("642df3ff-3b68-4bf0-9cd5-62173e331ddd"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d13537b1-6766-48dd-b402-136722245dfc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
