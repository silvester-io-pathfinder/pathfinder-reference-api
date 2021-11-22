using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExhortTheFaithful : Template
    {
        public static readonly Guid ID = Guid.Parse("e4d9fae2-604c-45f8-8862-221ca23bcb02");

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
            yield return new TextBlock { Id = Guid.Parse("39a7bb63-244b-4104-8471-5e7888e1bb07"), Type = TextBlockType.Text, Text = "Your knowledge of the tenets of your faith gives you insight into the best ways to get others of your faith to help you or to follow your directions. When you (action: Request) something of or (action: Coerce) members of your own faith, you can attempt a Religion check instead of Diplomacy or Intimidation, and you gain a +2 circumstance bonus to the check. On a critically failed attempt to make a (action: Request), the target's attitude toward you doesn't worsen." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e2917c9b-885f-4906-98c3-5166acd9f65f"), Proficiencies.Instances.Expert.ID, Skills.Instances.Religion.ID);
            builder.FollowAnyReligion(Guid.Parse("ed828491-aad5-41df-81aa-9c070cb8af88"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5547a27-ee8a-4b3a-952a-016ca8d1dbf8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
