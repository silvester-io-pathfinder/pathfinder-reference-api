using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Special
{
    public class RaveningsDesperationFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("02095904-2586-4030-adbc-caf83cf5a92f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ravening's Desperation",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ed5749df-1e63-45de-a096-d0e5b3ad82c4"), Type = TextBlockType.Text, Text = "Your study of the Beast of Gluttondark has taught you how to make do in the most trying of circumstances rather than succumb to weakness. As long as your current Hit Points are less than half your maximum Hit Points, you gain a +1 circumstance bonus to Survival and Stealth checks. If your current Hit Points are less than a quarter your maximum Hit Points, the circumstance bonus is +2 instead." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificLoreProficiencyPrerequisite { Id = Guid.Parse("babce2de-df3f-4a7b-929f-9517dd76fa6f"), RequiredLoreId = Lores.Instances.Zevgavizeb.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6d0c16d-811d-46a8-8e9d-ae4afddeb615"),
                SourceId = Sources.Instances.Pathfinder153.ID,
                Page = 67
            };
        }
    }
}
