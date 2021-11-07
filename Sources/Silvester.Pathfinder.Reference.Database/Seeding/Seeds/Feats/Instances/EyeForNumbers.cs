using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EyeForNumbers : Template
    {
        public static readonly Guid ID = Guid.Parse("20ff4d12-f393-4cfe-87f1-c6a55efe820c");

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
            yield return new TextBlock { Id = Guid.Parse("32b144b3-ba14-42b4-a542-ff23d72937a3"), Type = TextBlockType.Text, Text = "You’ve learned to subitize, quickly estimating the number of items in a group with relative accuracy at only a glance. You immediately learn the number of visually similar items in a group you can see (such as coins, books, or people), rounded to the first digit in the total number. For example, you could look at a case of potion vials and learn that it held about 30 vials, but you wouldn’t know that it was exactly 33 vials, how many different types of potions there were, or how many of which type. Similarly, you could look at a pile of 2,805 coins and know that there were about 3,000 coins in all. You can use this ability only on items that can typically be counted, so you can’t use it on grains of sand or stars in the sky, for example." };
            yield return new TextBlock { Id = Guid.Parse("43444751-8392-41a9-ad23-d3a8ca6cb60e"), Type = TextBlockType.Text, Text = "In addition, when you attempt to (action: Decipher Writing) that is primarily numerical or mathematical, you gain a +2 circumstance bonus to your check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1e627e9d-a61c-4724-b620-c650597bcde4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1134084d-4733-42f8-bb56-d1dc9cb73988"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
