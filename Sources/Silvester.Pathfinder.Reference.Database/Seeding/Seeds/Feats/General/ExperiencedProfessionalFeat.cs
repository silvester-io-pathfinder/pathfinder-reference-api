using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ExperiencedProfessionalFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("0e715099-8cfd-449b-a6b0-37467f68accc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Experienced Professional",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5ca60765-3953-40b6-8d4a-0532b2e4c80d"), Type = Utilities.Text.TextBlockType.Text, Text = "You carefully safeguard your professional endeavors to prevent disaster. When you use Lore to Earn Income, if you roll a critical failure, you instead get a failure. If you’re an expert in Lore, you gain twice as much income from a failed check to Earn Income, unless it was originally a critical failure." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new LorePrerequisite { Id = Guid.Parse("e412585e-1ba6-4f86-9c06-7f7ce9ae82f9"), RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
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
                Id = Guid.Parse("cc7e8920-7ac9-4d87-be25-866802a668c7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 261
            };
        }
    }
}
