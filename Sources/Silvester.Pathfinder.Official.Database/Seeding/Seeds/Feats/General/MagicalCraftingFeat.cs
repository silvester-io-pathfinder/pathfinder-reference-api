using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class MagicalCraftingFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("a90aba98-98fe-4a4d-86a6-93025e5d558a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Crafting",
                Level = 2,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8667db8e-760b-4b1d-a0b1-559e02a22b15"), Type = Utilities.Text.TextBlockType.Text, Text = "You can Craft magic items, though some have other requirements, as listed in Chapter 11. When you select this feat, you gain formulas for four common magic items of 2nd level or lower." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("388aa336-39bb-4172-afcf-ace1e855ee81"), RequiredSkillId = Skills.Instances.Crafting.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
