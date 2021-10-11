using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class MagicalShorthandFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("53bda5e8-f9d2-461f-9495-c9db35ab99c1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Shorthand",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("52ea6d08-fd50-45a1-8ee9-2dca70178979"), Type = Utilities.Text.TextBlockType.Text, Text = "Learning spells comes easily to you. If you’re an expert in a tradition’s associated skill, you take 10 minutes per spell level to learn a spell of that tradition, rather than 1 hour per spell level. If you fail to learn the spell, you can try again after 1 week or after you gain a level, whichever comes first. If you’re a master in the tradition’s associated skill, learning a spell takes 5 minutes per spell level, and if you’re legendary, it takes 1 minute per spell level. You can use downtime to learn and inscribe new spells. This works as if you were using Earn Income with the tradition’s associated skill, but instead of gaining money, you choose a spell available to you to learn and gain a discount on learning it, learning it for free if your earned income equals or exceeds its cost." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new ChoicePrerequisite
            {
                Id = Guid.Parse("7478eed3-36c1-4a1d-a247-21badb079eec"),
                Choices =
                {
                    new SkillPrerequisite { Id = Guid.Parse("cc86f706-7eea-4352-9723-9b001c44eecd"), RequiredSkillId = Skills.Instances.Arcana.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID },
                    new SkillPrerequisite { Id = Guid.Parse("06f72855-bcf2-4a8d-914b-19e9c62594b0"), RequiredSkillId = Skills.Instances.Nature.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID },
                    new SkillPrerequisite { Id = Guid.Parse("623b68a6-9405-4fc1-90ed-12f9ece5c28a"), RequiredSkillId = Skills.Instances.Occultism.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID },
                    new SkillPrerequisite { Id = Guid.Parse("d8f78cae-3e75-4217-a860-6ba2a3560403"), RequiredSkillId = Skills.Instances.Religion.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID },
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bca01ba6-938b-44a3-9ac5-10dfa122f2ab"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 264
            };
        }
    }
}
