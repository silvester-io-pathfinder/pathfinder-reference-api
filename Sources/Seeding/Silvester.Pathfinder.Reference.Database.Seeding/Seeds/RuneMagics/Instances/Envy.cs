using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.RuneMagics.Instances
{
    public class Envy : Template
    {
        public static readonly Guid ID = Guid.Parse("b7278704-70fc-4ae7-abfa-d18061845933");
        
        protected override RuneMagic GetRuneMagic()
        {
            return new RuneMagic
            {
                Id = ID, 
                Name = "Envy",
                Description = "Runelords of abjuration specialize in protective magic and in suppressing all other magic to glorify their own.",
                InitialRuneSpellId = Spells.Instances.BlindAmbition.ID,
                AdvancedRuneSpellId = Spells.Instances.CompetitiveEdge.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        protected override IEnumerable<RuneMagicSchoolBinding> GetProhibitedMagicSchools()
        {
            yield return new RuneMagicSchoolBinding { Id = Guid.Parse("b0cd5366-7e27-48f6-91dc-bee83f32d47c"), MagicSchoolId = MagicSchools.Instances.Evocation.ID };
            yield return new RuneMagicSchoolBinding { Id = Guid.Parse("fc3f743d-8f67-4d37-8f0f-e375b92d49cc"), MagicSchoolId = MagicSchools.Instances.Necromancy.ID };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("c3b4bc90-7d56-482e-8777-7d05c55bf737"), Spells.Instances.BlindAmbition.ID);

            builder
                .GainSpecificSpell(Guid.Parse("faf0d696-3cbd-4d31-8a54-846271544ba0"), Spells.Instances.CompetitiveEdge.ID)
                .AddPrerequisites(Guid.Parse("2c3dcd4d-238b-44ab-895d-36723dbcb9ac"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("c1954394-7825-4692-aa2d-23d2532bfa9e"), Comparator.GreaterThanOrEqualTo, requiredLevel: 8);
                });

            builder.ProhibitSpecificMagicSchool(Guid.Parse("3a16f0f2-c44f-44e5-a9fb-8a24dee41cb9"), MagicSchools.Instances.Evocation.ID);
            builder.ProhibitSpecificMagicSchool(Guid.Parse("7bf4ba49-b3ef-421b-ad81-0c57ce4b92b4"), MagicSchools.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4517b3eb-340e-4b8e-9684-3c233d01f502"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 238
            };
        }
    }
}
