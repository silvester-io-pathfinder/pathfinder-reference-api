using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("2d0860c1-1a32-4d8e-a042-891fb75335ed"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("a66e5e47-2ba9-4996-8cc0-59e131a82958"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("41bd0ed9-c65c-4380-b03f-a1af4f201ef4"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("230dfa86-d54c-49f9-9590-8a5685be655f")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("214127c8-5eb7-49a0-a9b1-89eb9ee9d8b5"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Arcana.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("967bea91-d78c-42a3-9fde-6623ecaffa50"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Academia.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("69e90215-cb97-4d14-bc15-3eac06f3d70b"),
                FeatId = Feats.General.DubiousKnowledgeFeat.ID
            };
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
