using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class SteadyBalanceFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("7ba0d3ef-7d44-42e4-8e2d-0b8bce8c9d16");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steady Balance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("be009048-9abe-439f-97f1-d78289d9752c"), Type = Utilities.Text.TextBlockType.Text, Text = "You can keep your balance easily, even in adverse conditions. Whenever you roll a success using the Balance action, you get a critical success instead. You’re not flat-footed while attempting to Balance on narrow surfaces and uneven ground. Thanks to your incredible balance, you can attempt an Acrobatics check instead of a Reflex save to Grab an Edge." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("bcd03bec-9864-4a38-a752-4e59acd26dc2"), RequiredSkillId = Skills.Instances.Acrobatics.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID};
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
                Id = Guid.Parse("c77c336f-96ff-4df5-bfc8-4b5101fc72e3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 267
            };
        }
    }
}
