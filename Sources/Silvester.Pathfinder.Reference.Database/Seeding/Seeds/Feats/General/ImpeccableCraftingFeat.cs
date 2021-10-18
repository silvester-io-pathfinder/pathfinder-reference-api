using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ImpeccableCraftingFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("89921651-065e-48f8-98cb-c9b6cf6c71e9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impeccable Crafting",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6b5087c0-7e76-445c-966e-7a50f572448f"), Type = Utilities.Text.TextBlockType.Text, Text = "You craft flawless creations with great efficiency. Whenever you roll a success at a Crafting check to make an item of the type you chose with Specialty Crafting, you get a critical success instead." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("04f0104f-5c14-447e-95b4-cfaaba3f4cbc"), RequiredSkillId = Skills.Instances.Crafting.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID };
            yield return new HaveSpecificFeatPrerequisite { Id = Guid.Parse("60c37f30-39dd-4fb1-9ecc-3ad80b2ab3ef"), RequiredFeatId = SpecialtyCraftingFeat.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b509279-db3e-429f-9968-b2350b5e5206"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 262
            };
        }
    }
}
