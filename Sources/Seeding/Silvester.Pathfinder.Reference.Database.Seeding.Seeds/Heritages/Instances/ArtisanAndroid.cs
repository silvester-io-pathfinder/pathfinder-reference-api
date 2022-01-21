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
        public static readonly Guid ID = Guid.Parse("33c97798-29b9-48a6-9033-dadde5899fbd");

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
            yield return new TextBlock { Id = Guid.Parse("49c19acd-c3ba-4684-b6a9-d7754c4df77e"), Type = TextBlockType.Text, Text = "Your body was originally designed to create works of art, complex tools, or maintain advanced machinery. You become trained in Crafting (or another skill if you're already trained in Crafting), and you gain the Specialty Crafting skill feat in a specialty of your choice." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("879d1ce0-9587-4d77-b895-1c5c23ce3127"), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse("45374dff-228e-41e1-9d58-a387647f7526"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
                or.GainAnySkillProficiency(Guid.Parse("7b9af24d-3887-4b89-ba0b-ee483d6343a4"), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse("f9fa1693-79b9-4fae-9d69-350fd06a565c"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse("4962c99f-5160-4519-bbbb-be765e3fa72f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
                    });
            });

            builder.GainSpecificFeat(Guid.Parse("1a5cb29f-ccf5-4661-96fd-87ca8e45818f"), Feats.Instances.SpecialtyCrafting.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd8b333a-a987-4fef-8d8c-723730939c30"),
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
