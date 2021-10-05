using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ArcaneSenseFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("a6def9d1-3dd5-4d2f-8e75-1773753119d9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Sense",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("72e1ef9e-b124-40eb-b185-e1f6199d6c77"), Type = Utilities.Text.TextBlockType.Text, Text = "Your study of magic allows you to instinctively sense its presence. You can cast 1st-level detect magic at will as an arcane innate spell. If you’re a master in Arcana, the spell is heightened to 3rd level; if you’re legendary, it is heightened to 4th level." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("d117552a-f149-48fd-8ff1-425893fb7b00"), RequiredProficiencyId = Proficiencies.Instances.Trained.ID, RequiredSkillId = Skills.Instances.Arcana.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
