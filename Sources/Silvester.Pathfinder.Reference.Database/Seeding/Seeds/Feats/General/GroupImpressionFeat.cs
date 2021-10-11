using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class GroupImpressionFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("738f86de-6f73-4ffa-a790-abd8feeb43c5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Group Impression",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7dd54aeb-9180-4509-ac60-9d9f31b4d9c9"), Type = Utilities.Text.TextBlockType.Text, Text = "When you Make an Impression, you can compare your Diplomacy check result to the Will DCs of two targets instead of one. It’s possible to get a different degree of success for each target. The number of targets increases to four if you’re an expert, 10 if you’re a master, and 25 if you’re legendary." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("c591078d-1a92-40eb-a7b9-611748799608"), RequiredSkillId = Skills.Instances.Diplomacy.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
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
                Id = Guid.Parse("8ca60405-36a1-45f8-a6c2-5fe5528f59a7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 262
            };
        }
    }
}
