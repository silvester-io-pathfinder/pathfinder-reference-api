using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EyeForNumbers : Template
    {
        public static readonly Guid ID = Guid.Parse("de74f8b2-a1fb-4eab-91ef-3c6d48981401");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eye for Numbers",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("403969af-b456-407f-be86-495d9dabb52b"), Type = TextBlockType.Text, Text = $"You've learned to subitize, quickly estimating the number of items in a group with relative accuracy at only a glance. You immediately learn the number of visually similar items in a group you can see (such as coins, books, or people), rounded to the first digit in the total number. For example, you could look at a case of potion vials and learn that it held about 30 vials, but you wouldn't know that it was exactly 33 vials, how many different types of potions there were, or how many of which type. Similarly, you could look at a pile of 2,805 coins and know that there were about 3,000 coins in all. You can use this ability only on items that can typically be counted, so you can't use it on grains of sand or stars in the sky, for example." };
            yield return new TextBlock { Id = Guid.Parse("9cb9e0b1-7623-40af-bb4b-0f333f7594fb"), Type = TextBlockType.Text, Text = $"In addition, when you attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Decipher Writing", SkillActions.Instances.DecipherWriting.ID)} that is primarily numerical or mathematical, you gain a +2 circumstance bonus to your check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("84285269-67ca-44c8-b8a8-cd514ba99cda"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2255c9ef-b74d-4bea-9cf5-ec6d92aaaf64"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
