using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class RootMagicFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("07015575-cfa8-4037-b8a1-50ff13825635");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Root Magic",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc10a49b-30f8-4830-9a06-907c6aab0f2f"), Type = Utilities.Text.TextBlockType.Text, Text = "Your talismans ward against foul magic. During your daily preparations, you can assemble a small pouch with bits of herbs, hair, sacred oils, and other ritual ingredients, which you give to one ally. The first time that day the ally attempts a saving throw against a spell or haunt, they gain a +1 circumstance bonus to the roll. This bonus increases to +2 if you're an expert in Occultism or +3 if you're legendary." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("71d3d4f8-2f48-4975-b242-242e2271e82f"), RequiredSkillId = Skills.Instances.Occultism.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
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
                Id = Guid.Parse("822d07c4-8c72-4e9c-b61b-c4810facc114"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 208
            };
        }
    }
}
