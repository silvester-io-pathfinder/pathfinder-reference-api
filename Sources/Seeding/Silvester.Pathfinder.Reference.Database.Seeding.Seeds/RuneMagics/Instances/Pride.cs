using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.RuneMagics.Instances
{
    public class Pride : Template
    {
        public static readonly Guid ID = Guid.Parse("249ede5b-0b86-4635-89eb-fd714c54dff2");
        
        protected override RuneMagic GetRuneMagic()
        {
            return new RuneMagic
            {
                Id = ID, 
                Name = "Pride",
                Description = "Runelords of illusion use magic to create the perfect appearance and fool others through trickery, deception, and misdirection.",
                InitialRuneSpellId = Spells.Instances.VeilOfConfidence.ID,
                AdvancedRuneSpellId = Spells.Instances.DelusionalPride.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        protected override IEnumerable<RuneMagicSchoolBinding> GetProhibitedMagicSchools()
        {
            yield return new RuneMagicSchoolBinding { Id = Guid.Parse("50f6e903-1430-4bce-aabc-754bdeb4dfa8"), MagicSchoolId = MagicSchools.Instances.Conjuration.ID };
            yield return new RuneMagicSchoolBinding { Id = Guid.Parse("5f7e713c-db0b-4320-af99-fa6836fb2778"), MagicSchoolId = MagicSchools.Instances.Transmutation.ID };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("59d9268a-4a3e-4474-85ae-051ac707f164"), Spells.Instances.VeilOfConfidence.ID);
            
            builder
                .GainSpecificSpell(Guid.Parse("8e55e738-02b2-44a7-adf4-acedbfffb4df"), Spells.Instances.DelusionalPride.ID)
                .AddPrerequisites(Guid.Parse("eab8ddba-24df-4eef-bdf9-5646b64ae524"), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("d0a5259a-a393-4a64-9eda-b591184e4bca"), Comparator.GreaterThanOrEqualTo, requiredLevel: 8);
                });

            builder.ProhibitSpecificMagicSchool(Guid.Parse("6a574cdd-7b3f-4f94-9a3d-2b55251b4add"), MagicSchools.Instances.Conjuration.ID);
            builder.ProhibitSpecificMagicSchool(Guid.Parse("ddd2e36c-a9b4-4ed7-a07e-02468faede71"), MagicSchools.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8c3a6e3-5cb4-467d-9519-01d7251b5636"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 239
            };
        }
    }
}
