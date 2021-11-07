using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnderwaterMarauder : Template
    {
        public static readonly Guid ID = Guid.Parse("1acdcf02-0c98-4250-97a1-a680b579484c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Underwater Marauder",
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
            yield return new TextBlock { Id = Guid.Parse("c229ed01-e6d2-4c8e-9754-e2fc58f36042"), Type = TextBlockType.Text, Text = "You’ve learned to fight underwater. You are not flat-footed while in water, and you don’t take the usual penalties for using a bludgeoning or slashing melee weapon in water." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5e57706c-efa6-4895-b750-2199db2e58c8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("663bc296-242d-4973-9a3e-83d80b3b369f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
