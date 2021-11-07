using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class ArtisanAndroid : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Artisan Android"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your body was originally designed to create works of art, complex tools, or maintain advanced machinery. You become trained in Crafting (or another skill if you're already trained in Crafting), and you gain the Specialty Crafting skill feat in a specialty of your choice." };
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
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 71
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Android.ID;
        }
    }
}
