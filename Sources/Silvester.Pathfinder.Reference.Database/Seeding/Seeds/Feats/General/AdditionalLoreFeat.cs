using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class AdditionalLoreFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("2c8b47a4-eb56-491b-82fd-a3f894282025");

		protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Additional Lore",
                Level = 1,
                Special = "You can select this feat more than once. Each time you must select a new subcategory of Lore and you gain the additional skill increases to that subcategory for the listed levels.",
                CanBeLearnedMoreThanOnce = true,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8c4e02b6-3966-491d-a8e8-aa05e8f6c0cb"), Type = Utilities.Text.TextBlockType.Text, Text = "Your knowledge has expanded to encompass a new field. Choose an additional Lore skill subcategory. You become trained in it. At 3rd, 7th, and 15th levels, you gain an additional skill increase you can apply only to the chosen Lore subcategory." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new LorePrerequisite { Id = Guid.Parse("abe5405c-a349-4fb2-8a49-ac761cfe23da"), RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override IEnumerable<FeatEffect> GetEffects()
        {
            yield return new GainLoreEffect { Id = Guid.Parse("43501d01-6d1e-497d-9cf8-81c0a0266232"), ProficiencyId = Proficiencies.Instances.Trained.ID };
            yield return new GainLoreEffect { Id = Guid.Parse("aab01fbb-7034-4f04-b135-dcaecd6e765a"), TriggeredAtLevel = 3, ProficiencyId = Proficiencies.Instances.Expert.ID };
            yield return new GainLoreEffect { Id = Guid.Parse("6634aaf1-a340-4b96-a815-8227dcffa9e5"), TriggeredAtLevel = 7, ProficiencyId = Proficiencies.Instances.Master.ID };
            yield return new GainLoreEffect { Id = Guid.Parse("a7158664-5a5e-4ca9-af4d-fd6d5e183da5"), TriggeredAtLevel = 15, ProficiencyId = Proficiencies.Instances.Legendary.ID };
        }
    }
}
