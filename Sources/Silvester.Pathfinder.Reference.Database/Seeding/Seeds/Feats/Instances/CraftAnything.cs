using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CraftAnything : Template
    {
        public static readonly Guid ID = Guid.Parse("b189bfae-cbb2-4162-8e02-2eefdf53329d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Craft Anything",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4edcfb29-a95c-406a-ac96-f4d71c265cf4"), Type = TextBlockType.Text, Text = "You can find ways to craft just about anything, despite restrictions. As long as you have the appropriate Crafting skill feat (such as (feat: Magical Crafting) for magic items) and meet the item’s level and proficiency requirement, you ignore just about any other requirement, such as being of a specific ancestry or providing spells. The only exceptions are requirements that add to the item’s cost, including castings of spells that themselves have a cost, and requirements of special items such as the (item: philosopher’s stone) that have exclusive means of access and Crafting. The GM decides whether you can ignore a requirement." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9c236f7c-f607-4f02-a70d-5015998bb3b4"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6ac0236-4ff8-4e38-9788-22e081ba1fd9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
