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
    public class Gluttony : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override RuneMagic GetRuneMagic()
        {
            return new RuneMagic
            {
                Id = ID, 
                Name = "Gluttony",
                Description = "Runelords of necromancy tap into their constant hunger for more power and enhancing their longevity, potentially even unto undeath.",
                InitialRuneSpellId = Spells.Instances.Overstuff.ID,
                AdvancedRuneSpellId = Spells.Instances.TakeItsCourse.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        protected override IEnumerable<Guid> GetProhibitedMagicSchools()
        {
            yield return MagicSchools.Instances.Abjuration.ID;
            yield return MagicSchools.Instances.Enchantment.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Overstuff.ID);
            
            builder
                .GainSpecificSpell(Guid.Parse(""), Spells.Instances.TakeItsCourse.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 8);
                });

            builder.ProhibitSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Abjuration.ID);
            builder.ProhibitSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Enchantment.ID);
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
