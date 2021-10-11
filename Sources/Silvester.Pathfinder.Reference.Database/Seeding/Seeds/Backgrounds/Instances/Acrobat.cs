using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Acrobat : Template
    {
        public static readonly Guid ID = Guid.Parse("f7a99adb-1eb1-4802-a00d-d19c0ecf87bf");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Acrobat",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9171095f-f771-42d7-a4dd-95f4f72c50c0"), Type = TextBlockType.Text, Text = "In a circus or on the streets, you earned your pay by performing as an acrobat. You might have turned to adventuring when the money dried up, or simply decided to put your skills to better use." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("7d350cc5-8a87-4e0a-8754-75b8b3259fc8"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("37b1c115-10d6-47f4-92bf-600d0a6b7a98"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("dc0d00b3-a098-4502-a944-bff42a01fdb3"), StatId = Stats.Instances.Dexterity.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("dca731af-2aac-41e7-9c1f-5d3c5403ed6d")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("38cb706c-673c-4c68-b85c-dbb06f99bf5c"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Acrobatics.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("75d003c4-5baf-4cbb-b38d-38b5f4bda20b"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Circus.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("ed06b6eb-4dd4-4ccc-8d51-9076f2762459"),
                FeatId = Feats.General.SteadyBalanceFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2384ee7-6581-4872-b9d6-fe2e813fc332"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 60
            };
        }
    }
}
