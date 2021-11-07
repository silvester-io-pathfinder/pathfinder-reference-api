using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnareSpecialist : Template
    {
        public static readonly Guid ID = Guid.Parse("d0fc4ae1-b582-48d2-934a-610259c2b23c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snare Specialist",
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
            yield return new TextBlock { Id = Guid.Parse("4ec75c0b-e30c-4348-8378-e19a265fdaa1"), Type = TextBlockType.Text, Text = "You specialize in creating quick traps to obstruct your enemies on the battlefield. If your proficiency rank in Crafting is expert, you gain the formulas for three common or uncommon snares. If your rank is master, you gain 6. If your rank is legendary, you gain 9." };
            yield return new TextBlock { Id = Guid.Parse("97a1ba2a-921d-4039-a922-0e554df76d09"), Type = TextBlockType.Text, Text = "Each day during your daily preparations, you can prepare four snares from your (item: formula book) for quick deployment; if they normally take 1 minute to (action: Craft), you can (action: Craft) them with 3 (action: Interact) actions. The number of snares increases to six if you have master proficiency in Crafting and eight if you have legendary proficiency in Crafting. Snares prepared in this way don’t cost you any resources to (action: Craft)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("3bf5a4d9-7328-449a-8dfb-1efdd6fbd83b"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("91b99300-a38c-4014-b819-c45820f925af"), Feats.Instances.SnareCrafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58ebab6f-f3cd-4dbd-9a24-cb64452e2903"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
