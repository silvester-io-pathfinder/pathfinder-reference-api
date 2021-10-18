using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class AlchemicalCraftingFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("57442d19-cae2-465c-9d3d-2e77ecde2a50");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Alchemical Crafting",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("447bc70f-fd26-40a6-8663-02d4ccb6c686"), Type = Utilities.Text.TextBlockType.Text, Text = "Your knowledge has expanded to encompass a new field. Choose an additional Lore skill subcategory. You become trained in it. At 3rd, 7th, and 15th levels, you gain an additional skill increase you can apply only to the chosen Lore subcategory." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("05b93357-0b9d-4e08-9a66-a2ede8b4181c"), RequiredProficiencyId = Proficiencies.Instances.Trained.ID, RequiredSkillId = Skills.Instances.Crafting.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override IEnumerable<Effect> GetCharacterEffects()
        {
            yield return new GainAnyFormulaEffect { Id = Guid.Parse("5e5a10bd-a6b9-4f46-974d-06b280716ef8"), Level = 1 };
            yield return new GainAnyFormulaEffect { Id = Guid.Parse("9f2ab8ce-da8f-4123-a698-f854ac8f688a"), Level = 1 };
            yield return new GainAnyFormulaEffect { Id = Guid.Parse("3c1fd8e9-0bee-4a65-b728-54fe8d8b5804"), Level = 1 };
            yield return new GainAnyFormulaEffect { Id = Guid.Parse("b01ea950-f6e7-4240-a50d-d8df5d07098b"), Level = 1 };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca783efd-665d-4462-a204-41e8dc487a29"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 258
            };
        }
    }
}
