using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExhortTheFaithful : Template
    {
        public static readonly Guid ID = Guid.Parse("ba7f76c6-8d62-4313-992a-e438be00fc8e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Exhort the Faithful",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d1c40723-1303-4243-a274-ecb1e5b6a0b8"), Type = TextBlockType.Text, Text = "Your knowledge of the tenets of your faith gives you insight into the best ways to get others of your faith to help you or to follow your directions. When you (action: Request) something of or (action: Coerce) members of your own faith, you can attempt a Religion check instead of Diplomacy or Intimidation, and you gain a +2 circumstance bonus to the check. On a critically failed attempt to make a (action: Request), the target’s attitude toward you doesn’t worsen." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("3f7b162f-e399-447e-bf1e-41cfc338a5bb"), Proficiencies.Instances.Expert.ID, Skills.Instances.Religion.ID);
            builder.FollowAnyReligion(Guid.Parse("80d9b693-e1b0-4a76-bbe8-419a3b0408bd"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("465ffb28-a9bb-4b1a-b397-44b4c5b6e16f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
