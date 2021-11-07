using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CraftAnything : Template
    {
        public static readonly Guid ID = Guid.Parse("18d5ac7b-699c-4025-9f13-27b34127355d");

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
            yield return new TextBlock { Id = Guid.Parse("99abbf49-90bd-41e4-8e4b-729fae96b24d"), Type = TextBlockType.Text, Text = "You can find ways to craft just about anything, despite restrictions. As long as you have the appropriate Crafting skill feat (such as (feat: Magical Crafting) for magic items) and meet the item’s level and proficiency requirement, you ignore just about any other requirement, such as being of a specific ancestry or providing spells. The only exceptions are requirements that add to the item’s cost, including castings of spells that themselves have a cost, and requirements of special items such as the (item: philosopher’s stone) that have exclusive means of access and Crafting. The GM decides whether you can ignore a requirement." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e5b37bee-8dc3-4607-b4a7-ac8d36fdedce"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0bb769df-cdf7-43ea-b0d8-ad53cad6ad08"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
