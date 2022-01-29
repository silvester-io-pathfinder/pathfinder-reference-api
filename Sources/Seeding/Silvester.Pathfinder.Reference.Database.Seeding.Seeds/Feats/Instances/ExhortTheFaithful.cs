using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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
            yield return new TextBlock { Id = Guid.Parse("39a7bb63-244b-4104-8471-5e7888e1bb07"), Type = TextBlockType.Text, Text = $"Your knowledge of the tenets of your faith gives you insight into the best ways to get others of your faith to help you or to follow your directions. When you {ToMarkdownLink<Models.Entities.SkillAction>("Request", SkillActions.Instances.Request.ID)} something of or {ToMarkdownLink<Models.Entities.SkillAction>("Coerce", SkillActions.Instances.Coerce.ID)} members of your own faith, you can attempt a Religion check instead of Diplomacy or Intimidation, and you gain a +2 circumstance bonus to the check. On a critically failed attempt to make a {ToMarkdownLink<Models.Entities.SkillAction>("Request", SkillActions.Instances.Request.ID)}, the target's attitude toward you doesn't worsen." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e2917c9b-885f-4906-98c3-5166acd9f65f"), Proficiencies.Instances.Expert.ID, Skills.Instances.Religion.ID);
            builder.FollowAnyReligion(Guid.Parse("ed828491-aad5-41df-81aa-9c070cb8af88"));
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("46818adb-ad64-44bd-a93a-ce50e6d93c06"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("c971167f-5b1e-4967-b443-2b32a6e2973f"), Traits.Instances.Skill.ID);

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
