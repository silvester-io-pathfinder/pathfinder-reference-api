using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ArmorAssistFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("d93499e3-2477-4e4f-9375-367e14ceeb6f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Armor Assist",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.Skill.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("75937a13-df9f-4513-ac88-f612e88eced9"), Type = TextBlockType.Text, Text = "After your service aiding armored combatants, you are practiced in helping yourself and others don heavy gear. You can attempt an Athletics or Warfare Lore check with a DC determined by the GM (but usually 15 for common armor, DC 20 for uncommon armor, and DC 25 for rare armor) to halve the time you take to don armor. You can halve an ally's time to don armor by working with them to don the armor and succeeding at an Athletics or Warfare Lore check against the same DC." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new OrPrerequisite
            {
                Id = Guid.Parse("63eb26b6-ac20-4182-ab56-481642358fd3"),
                Choices = new Prerequisite[]
                {
                    new SkillPrerequisite { Id = Guid.Parse("b8160242-4cea-4e4d-9839-9281916c9c1e"), RequiredSkillId = Skills.Instances.Athletics.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID },
                    new LorePrerequisite { Id = Guid.Parse("474ecdc2-6ceb-47f9-b199-314951818369"), RequiredProficiencyId = Proficiencies.Instances.Trained.ID, RequiredLoreId = Lores.Instances.Warfare.ID }
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
