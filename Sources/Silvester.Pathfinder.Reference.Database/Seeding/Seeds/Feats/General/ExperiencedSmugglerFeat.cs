using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ExperiencedSmugglerFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("fa30f639-b913-4050-b7bc-a8e9991178f1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Experienced Smuggler",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0b11531a-68c6-4cd9-a7f9-e4f3494f4ab3"), Type = Utilities.Text.TextBlockType.Text, Text = "You often smuggle things past the authorities. When the GM rolls your Stealth check to see if a passive observer notices a small item you have concealed, the GM uses the number rolled or 10—whichever is higher—as the result of your die roll, adding it to your Stealth modifier to determine your Stealth check result. If you’re a master in Stealth, the GM uses the number rolled or 15, and if you’re legendary in Stealth, you automatically succeed at hiding a small concealed item from passive observers. This provides no benefits when a creature attempts a Perception check while actively searching you for hidden items. Due to your smuggling skill, you’re more likely to find more lucrative smuggling jobs when using Underworld Lore to Earn Income" };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("56e776af-2740-4dc6-b0ce-d1d31abcea9f"), RequiredSkillId = Skills.Instances.Stealth.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
