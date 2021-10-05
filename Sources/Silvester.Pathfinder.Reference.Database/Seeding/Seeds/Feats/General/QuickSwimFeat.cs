using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class QuickSwimFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("eda136b0-c9e5-4b60-abd3-cc534c043a00");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Swim",
                Level = 7,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("08b12c02-c83f-43de-be5c-dd9ec87334cf"), Type = Utilities.Text.TextBlockType.Text, Text = "You Swim 5 feet farther on a success and 10 feet farther on a critical success, to a maximum of your Speed. If you’re legendary in Athletics, you gain a swim Speed equal to your Speed." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("8c0101c8-da77-49a0-b727-b56b58eafbcc"), RequiredSkillId = Skills.Instances.Athletics.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
