using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class LegendaryLinguistFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("3afb7bd6-f0c2-4187-9d47-f7a06d512fd3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Linguist",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6156f6a0-8ca3-4260-aa1c-8842c9a6d780"), Type = Utilities.Text.TextBlockType.Text, Text = "You’re so skilled with languages you can create a pidgin instantly. You can always talk to any creature that has a language—even a language you don’t know —by creating a new pidgin language that uses simplified terms and conveys basic concepts. To do so, you must first understand at least what medium of communication the creature uses (speech, sign language, and so on)." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("b7c2609b-e269-4df4-8aeb-2abf5fe06560"), RequiredSkillId = Skills.Instances.Society.ID, RequiredProficiencyId = Proficiencies.Instances.Legendary.ID };
            yield return new HaveSpecificFeatPrerequisite { Id = Guid.Parse("1abf8f92-6500-471f-8a76-0890564bd71b"), RequiredFeatId = MultilingualFeat.ID};
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
                Id = Guid.Parse("7a064542-cc7d-4dd6-b19d-89581e53130a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 263
            };
        }
    }
}
