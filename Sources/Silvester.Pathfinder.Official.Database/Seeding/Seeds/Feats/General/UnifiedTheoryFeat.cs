using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class UnifiedTheoryFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("ce1dc7c1-c529-42a2-a2f5-f6ca99df1804");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unified Theory",
                Level = 15,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c53778be-16f6-4284-9f86-328a4191a823"), Type = Utilities.Text.TextBlockType.Text, Text = "You’ve started to make a meaningful connection about the common underpinnings of the four traditions of magic and magical essences, allowing you to understand them all through an arcane lens. Whenever you use a skill action or a skill feat that requires a Nature, Occultism, or Religion check, depending on the magic tradition, you can use Arcana instead. If you would normally take a penalty or have a higher DC for using Arcana on other magic (such as when using Identify Magic), you no longer do so." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("3bf369c3-0238-4948-9eee-6c951a87ae80"), RequiredSkillId = Skills.Instances.Arcana.ID, RequiredProficiencyId = Proficiencies.Instances.Legendary.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
