using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class CraftersAppraisal : Template
    {
        public static readonly Guid ID = Guid.Parse("a15d0324-9d8e-4ba7-a23f-2eadb3180a75");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crafter's Appraisal",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad8f1667-9b8a-4ea5-9b3e-bd2145a557d8"), Type = TextBlockType.Text, Text = "Your knowledge of items' construction allows you to discern their magical effects as well. You can use Crafting instead of a skill associated with a magic tradition to Identify Magic on magic items, though not on any other sorts of magic." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("dab50d75-84c8-4b76-ba88-da1908ab0044"), RequiredProficiencyId = Proficiencies.Instances.Trained.ID, RequiredSkillId = Skills.Instances.Crafting.ID };
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
                Id = Guid.Parse("bbf17823-69f5-4632-b22a-5cda5fdd9713"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 204
            };
        }
    }
}
