using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class AcademyDropout : Template
    {
        public static readonly Guid ID = Guid.Parse("729f3170-7a09-462b-9bbf-149ad70d04d3");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Academy Dropout",
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d0aee2f6-b235-4f7a-93ad-216043be4bb1"), Type = TextBlockType.Text, Text = "You were enrolled at a prestigious magical academy, but you've since dropped out. Maybe there was a momentous incident, maybe you had to return to other responsibilities, or perhaps it was just too much for you. Whatever the case, your exit from the academy has shaped your life as much as your entrance and led you to a life of adventure." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("2b89562b-cb60-4421-a42a-3f94d628c050"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("d6a30c2c-5f72-4b1f-9b64-bfc6c03acc05"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("a3a85af4-6f4e-4115-bc1e-0c71c15e5059"), Stats.Instances.Charisma.ID);
            });
            builder.GainAnyAbilityBoost(Guid.Parse("c99b7dd5-aa97-46dc-a0eb-331f6ebd706a"));
            builder.GainSpecificSkillProficiency(Guid.Parse("9c360e7a-71c1-459b-b12c-f8c4904b329a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("c8dc3b72-46d2-489f-be01-d6f5b9349519"), Proficiencies.Instances.Trained.ID, Lores.Instances.Academia.ID);
            builder.GainSpecificFeat(Guid.Parse("17147150-2cb9-4615-abb2-89404b3a5872"), Feats.Instances.DubiousKnowledge.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb414d78-e56e-4d60-ae85-ffcddfc10a17"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 28
            };
        }
    }
}
