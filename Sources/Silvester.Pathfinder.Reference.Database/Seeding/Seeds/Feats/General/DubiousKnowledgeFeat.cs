using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class DubiousKnowledgeFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("fffc0274-b5cd-428f-8144-a7d8b01f5986");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dubious Knowledge",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("28d7b87a-55a3-48f3-9071-ab3e1600f129"), Type = Utilities.Text.TextBlockType.Text, Text = "You’re a treasure trove of information, but not all of it comes from reputable sources. When you fail (but don’t critically fail) a Recall Knowledge check using any skill, you learn a bit of true knowledge and a bit of erroneous knowledge, but you don’t have any way to differentiate which is which." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new RecallKnowledgePrerequisite { Id = Guid.Parse("a85e2c74-32bb-42f4-b3bd-dd42dd68fdc0"), RequiresAssurance = false, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
