using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class AnvilDwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("e019e11d-e494-49d6-8861-5c61a4768b6a");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            {
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Anvil Dwarf"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("53cd56e4-c659-4dbd-8c87-6e59160fb78a"), Type = TextBlockType.Text, Text = "You are a descendant of a famed crafter and have your own amazing talent. Other dwarves might consider this a blessing from your ancestors or from the Forgefather himself, depending on where you grew up. You become trained in Crafting (or another skill if you were already trained in Crafting) and gain the Specialty Crafting skill feat, but you can pick two different specialties instead of one." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("21b0c551-3606-4437-9741-abdb26a901c0"), or => 
            {
                or.GainSpecificSkillProficiency(Guid.Parse("f35151bf-202b-4738-9ba5-2f866dc0d5e6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
                or.GainAnySkillProficiency(Guid.Parse("b8fccd70-d47b-4af7-a9b2-e527ab05497a"), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse("4ed7af11-ccc7-4a7e-8ce0-b6aade3b47a1"), prerequisites => 
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse("1b90acc0-50ea-4e2f-94a6-070a23766077"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
                    });
            });

            builder.GainSpecificFeat(Guid.Parse("23aa5873-2fd2-4a54-8a17-c060e8f2348c"), Feats.Instances.SpecialtyCrafting.ID);
            builder.GainSpecificFeat(Guid.Parse("57a8bd66-fa7c-4b16-b8cc-75d88f8cc1ad"), Feats.Instances.SpecialtyCrafting.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1aab5ec-299a-4d09-970d-b69a5342bfc1"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 19
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Dwarf.ID;
        }
    }
}
