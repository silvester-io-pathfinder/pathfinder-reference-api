using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnareSpecialist : Template
    {
        public static readonly Guid ID = Guid.Parse("9e02d791-0dfe-4d39-9762-6e9bc010096c");

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
            yield return new TextBlock { Id = Guid.Parse("33be8147-34ff-496f-bd0e-b3c2b9904301"), Type = TextBlockType.Text, Text = "You specialize in creating quick traps to obstruct your enemies on the battlefield. If your proficiency rank in Crafting is expert, you gain the formulas for three common or uncommon snares. If your rank is master, you gain 6. If your rank is legendary, you gain 9." };
            yield return new TextBlock { Id = Guid.Parse("c2a1ed9e-9819-405a-a104-9d26b336dc25"), Type = TextBlockType.Text, Text = "Each day during your daily preparations, you can prepare four snares from your (item: formula book) for quick deployment; if they normally take 1 minute to (action: Craft), you can (action: Craft) them with 3 (action: Interact) actions. The number of snares increases to six if you have master proficiency in Crafting and eight if you have legendary proficiency in Crafting. Snares prepared in this way don’t cost you any resources to (action: Craft)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("58fe10a0-4ec3-4e86-a6be-6793f534d744"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("7eda890c-55a9-4064-99f0-0dcb34ba2c1b"), Feats.Instances.SnareCrafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ef84124-8ead-4068-927f-a2e4d3178ecc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
