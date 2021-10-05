using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class RapidMantelFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("73d6b44a-a2a6-4a70-be2c-2dd59c09657a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rapid Mantel",
                Level = 2,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("600a8c6c-ad12-4e0c-b656-70f740cce02e"), Type = Utilities.Text.TextBlockType.Text, Text = "You easily pull yourself onto ledges. When you Grab an Edge, you can pull yourself onto that surface and stand. You can use Athletics instead of a Reflex save to Grab an Edge." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("55c2a3ac-ec97-4882-b7a1-af9650b2b4d8"), RequiredSkillId = Skills.Instances.Athletics.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
