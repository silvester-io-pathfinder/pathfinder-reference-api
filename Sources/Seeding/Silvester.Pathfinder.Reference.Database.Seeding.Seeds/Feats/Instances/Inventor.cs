using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Inventor : Template
    {
        public static readonly Guid ID = Guid.Parse("84064a48-a8f9-4f92-89c3-042bf406b62a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inventor",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("19ec2c32-10d1-4a23-b988-3376765b4f24"), Type = TextBlockType.Text, Text = "You are a genius at (action: Crafting | Craft), easily able to determine how things are made and create new inventions. You can spend downtime to invent a common formula that you don't know. This works just like the (action: Craft) activity: you spend half the Price of the formula up front, attempt a Crafting check, and on a success either finish the formula by paying the difference or work for longer to decrease the Price. The difference is that you spend the additional time in research, design, and development, rather than in creating an item. Once it's complete, you add the new formula you invented to your formula book." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("97aa21e1-bea1-4395-aaab-275c91b2abb2"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2bcedae0-6a71-49e8-842e-169e17b8e3b2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
