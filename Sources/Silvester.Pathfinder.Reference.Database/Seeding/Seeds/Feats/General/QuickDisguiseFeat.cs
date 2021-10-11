using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class QuickDisguiseFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("064690bd-cd97-47a5-9e4c-fb8672bb6225");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Disguise",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9ac62ad5-c1ab-46ae-8e36-403268396a6e"), Type = Utilities.Text.TextBlockType.Text, Text = "You can set up a disguise in half the usual time (generally 5 minutes). If you’re a master, it takes one-tenth the usual time (usually 1 minute). If you’re legendary, you can create a full disguise and Impersonate as a 3-action activity." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("f89492d8-f55d-445c-85a8-cd34e13549ee"), RequiredSkillId = Skills.Instances.Deception.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID };
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
                Id = Guid.Parse("14d6c1c6-e39b-4c40-b180-8479708cd83f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 264
            };
        }
    }
}
