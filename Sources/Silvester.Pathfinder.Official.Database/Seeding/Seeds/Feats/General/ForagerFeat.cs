using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ForagerFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("3f62ad52-d80b-4662-979c-6eb66a224801");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Foil Senses",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("89245459-0885-4ec0-bab4-0ce44729a508"), Type = Utilities.Text.TextBlockType.Text, Text = "While using Survival to Subsist, if you roll any result worse than a success, you get a success. On a success, you can provide subsistence living for yourself and four additional creatures, and on a critical success, you can take care of twice as many creatures as on a success." };
            yield return new TextBlock { Id = Guid.Parse("a6f780cc-319d-4c0e-84b5-18dd1f1b3889"), Type = Utilities.Text.TextBlockType.Text, Text = "Each time your proficiency rank in Survival increases, double the number of additional creatures you can take care of on a success (to eight if you’re an expert, 16 if you’re a master, or 32 if you’re legendary). You can choose to care for half the number of additional creatures and provide a comfortable living instead of subsistence living." };
            yield return new TextBlock { Id = Guid.Parse("a9300d60-b3e5-4b0b-9376-75a590caf556"), Type = Utilities.Text.TextBlockType.Text, Text = "Multiple smaller creatures or creatures with significantly smaller appetites than a human are counted as a single creature for this feat, and larger creatures or those with significantly greater appetites each count as multiple creatures. The GM determines how much a non-human creature needs to eat." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("93adf76b-93db-4a21-96dd-18344ed3f4e6"), RequiredSkillId = Skills.Instances.Survival.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
