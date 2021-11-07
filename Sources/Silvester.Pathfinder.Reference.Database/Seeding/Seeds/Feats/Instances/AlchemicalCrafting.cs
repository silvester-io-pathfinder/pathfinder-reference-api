using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlchemicalCrafting : Template
    {
        public static readonly Guid ID = Guid.Parse("bfbcdd2f-a176-4f2c-8e72-f4e8f9f6abc0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Alchemical Crafting",
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
            yield return new TextBlock { Id = Guid.Parse("0b81af53-d062-4198-9314-9a200d5b2b31"), Type = TextBlockType.Text, Text = "You can use the (action: Craft) activity to create alchemical items. When you select this feat, you immediately add the formulas for four common 1st-level alchemical items to your (item: formula book)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e4fa6386-c684-46bd-b3ae-3efe0b037602"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f16e09c1-8fe1-400b-8625-4afb135bcef3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
