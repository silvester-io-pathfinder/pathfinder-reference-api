using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class HookclawDigger : Template
    {
        public static readonly Guid ID = Guid.Parse("eb3a27b0-4c04-44d7-ac2e-d0727764b32f");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Hookclaw Digger",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f4903e5b-2328-47e4-911b-3176ae9628d1"), Type = TextBlockType.Text, Text = "You are a digger from the Hookclaw kobold tribe, born beneath the streets of Absalom, with muscles and mind hardened by years spent tunneling through rock and earth and a confidence built upon your pride in your draconic heritage." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificAncestryPrerequisite { Id = Guid.Parse("879737ef-46bc-4cf6-931b-78a220c13c83"), RequiredAncestryId = Ancestries.Instances.Kobold.ID };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("aac81b39-d9ee-4747-9b99-b1cba0d9f4b5"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("da602150-4946-4ee6-bb87-edeefe531050"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("e2c89392-152e-4aaf-9c16-b3cf57fdaf74"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("f933ada3-e657-43d6-845a-cf2a87ea02a3")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("08b867af-e478-4ddf-bb29-846bd3e74135"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Crafting.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("b94d178a-521e-4825-84da-5d7796040363"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Mining.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("c6a0b2b1-673e-4dea-92de-209db04750c1"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Engineering.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("01d04f54-db43-4dbc-a912-d6bf5fedf00e"),
                FeatId = Feats.General.ImproviseToolFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa7b6c98-54c7-466f-b9c6-fd3c4e34e26d"),
                SourceId = Sources.Instances.LittleTroubleInBigAbsalom.ID,
                Page = 0
            };
        }
    }
}
