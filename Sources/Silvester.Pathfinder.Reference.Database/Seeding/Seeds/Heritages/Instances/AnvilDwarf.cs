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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You are a descendant of a famed crafter and have your own amazing talent. Other dwarves might consider this a blessing from your ancestors or from the Forgefather himself, depending on where you grew up. You become trained in Crafting (or another skill if you were already trained in Crafting) and gain the Specialty Crafting skill feat, but you can pick two different specialties instead of one." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or => 
            {
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
                or.GainAnySkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse(""), prerequisites => 
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
                    });
            });

            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.SpecialtyCrafting.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.SpecialtyCrafting.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
