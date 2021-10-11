using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class LegendarySurvivalistFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("d264d400-645f-4e7e-8100-ae5b2caf9e0e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Survivalist",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("308d6b71-ee1c-4e7b-b3b5-1ef198b64205"), Type = Utilities.Text.TextBlockType.Text, Text = "You can survive indefinitely without food or water and can endure severe, extreme, and incredible cold and heat without taking damage from doing so." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("8d68493f-4f66-4ebb-aa54-c5fed2ae86b6"), RequiredSkillId = Skills.Instances.Survival.ID, RequiredProficiencyId = Proficiencies.Instances.Legendary.ID };
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
                Id = Guid.Parse("bc6c2b95-7b32-4a6f-92f6-cec7cc831d54"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 263
            };
        }
    }
}
