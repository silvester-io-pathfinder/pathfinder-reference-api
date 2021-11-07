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
    public class Sloth : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override RuneMagic GetRuneMagic()
        {
            return new RuneMagic
            {
                Id = ID, 
                Name = "Sloth",
                Description = "Runelords of conjuration use their magic to create what they need as they need it, and call forth servants to do their bidding.",
                InitialRuneSpellId = Spells.Instances.EfficientApport.ID,
                AdvancedRuneSpellId = Spells.Instances.SwampOfSloth.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        protected override IEnumerable<Guid> GetProhibitedMagicSchools()
        {
            yield return MagicSchools.Instances.Evocation.ID;
            yield return MagicSchools.Instances.Illusion.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.EfficientApport.ID);
            
            builder
                .GainSpecificSpell(Guid.Parse(""), Spells.Instances.SwampOfSloth.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 8);
                });

            builder.ProhibitSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Evocation.ID);
            builder.ProhibitSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Illusion.ID);
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
