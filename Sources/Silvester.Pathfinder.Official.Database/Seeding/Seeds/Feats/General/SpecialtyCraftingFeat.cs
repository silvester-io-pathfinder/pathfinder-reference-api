using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class SpecialtyCraftingFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("b1c71e21-bea7-453b-b23a-13ecc1b3675b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Specialty Crafting",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("19cd7955-cd5b-4133-8967-48d9f9379ef4"), Type = Utilities.Text.TextBlockType.Text, Text = "In situations where you can physically menace the target when you Coerce or Demoralize, you gain a +1 circumstance bonus to your Intimidation check and you ignore the penalty for not sharing a language. If your Strength score is 20 or higher and you are a master in Intimidation, this bonus increases to +2." };
            yield return new TextBlock { Id = Guid.Parse("3437ee0d-8348-4ee0-b08f-7cb793843223"), Type = Utilities.Text.TextBlockType.Text, Text = "If it’s unclear whether the specialty applies, the GM decides. Some specialties might apply only partially. For example, if you were making a morningstar and had specialty in woodworking, the GM might give you half your bonus because the item requires both blacksmithing and woodworking." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("68ff9988-9cbf-493c-ac08-d3ede1bef387"), RequiredSkillId = Skills.Instances.Crafting.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }


        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
