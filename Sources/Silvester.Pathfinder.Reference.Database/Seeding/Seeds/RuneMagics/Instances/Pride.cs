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
        public static readonly Guid ID = Guid.Parse("");
        
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

        protected override IEnumerable<Guid> GetProhibitedMagicSchools()
        {
            yield return MagicSchools.Instances.Conjuration.ID;
            yield return MagicSchools.Instances.Transmutation.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.VeilOfConfidence.ID);
            
            builder
                .GainSpecificSpell(Guid.Parse(""), Spells.Instances.DelusionalPride.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 8);
                });

            builder.ProhibitSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Conjuration.ID);
            builder.ProhibitSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 239
            };
        }
    }
}
