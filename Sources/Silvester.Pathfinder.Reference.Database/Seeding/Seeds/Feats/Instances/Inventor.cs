using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Inventor : Template
    {
        public static readonly Guid ID = Guid.Parse("33865517-c3bc-45e2-af68-13a9c4f87bc3");

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
            yield return new TextBlock { Id = Guid.Parse("e1e2e156-2926-484f-9f56-81bb9a975e5b"), Type = TextBlockType.Text, Text = "You are a genius at (action: Crafting | Craft), easily able to determine how things are made and create new inventions. You can spend downtime to invent a common formula that you don’t know. This works just like the (action: Craft) activity: you spend half the Price of the formula up front, attempt a Crafting check, and on a success either finish the formula by paying the difference or work for longer to decrease the Price. The difference is that you spend the additional time in research, design, and development, rather than in creating an item. Once it’s complete, you add the new formula you invented to your formula book." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c0e239ec-f3a7-447b-a106-09d7acf63db7"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5631ff5a-e5cf-43d7-be00-39aa93596874"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
