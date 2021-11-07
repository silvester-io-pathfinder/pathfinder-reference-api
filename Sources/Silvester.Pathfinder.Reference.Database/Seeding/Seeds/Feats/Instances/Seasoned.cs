using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Seasoned : Template
    {
        public static readonly Guid ID = Guid.Parse("2ad0b582-dddf-4df6-b99c-adb007ef54ea");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Seasoned",
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
            yield return new TextBlock { Id = Guid.Parse("db003d88-6d03-4162-b488-a02939080fec"), Type = TextBlockType.Text, Text = "You’ve mastered the preparation of many types of food and drink. You gain a +1 circumstance bonus to checks to (action: Craft) food and drink, including potions. If you are a master in one of the prerequisite skills, this bonus increases to +2." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("cbbc5a57-5279-4d8e-90af-1093c4e83d74"), or => 
            {
                or.HaveSpecificLoreSpecificProficiency(Guid.Parse("f743c9b6-863f-4b97-b0a6-9c225bd8ced5"), Proficiencies.Instances.Trained.ID, Lores.Instances.Alcohol.ID);
                or.HaveSpecificLoreSpecificProficiency(Guid.Parse("8c4dafe0-905c-4908-840d-790958443801"), Proficiencies.Instances.Trained.ID, Lores.Instances.Cooking.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("c58917e4-9972-4ffb-9269-2fb3f4d4bb61"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcf3da0a-e319-4bb5-8d20-f4729e00e554"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
