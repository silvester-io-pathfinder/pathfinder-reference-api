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
    public class Lust : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override RuneMagic GetRuneMagic()
        {
            return new RuneMagic
            {
                Id = ID, 
                Name = "Lust",
                Description = "Runelords of enchantment specialize in magic that compels and controls the minds of others, often to fulfill their own needs and desires.",
                InitialRuneSpellId = Spells.Instances.CharmingTouch.ID,
                AdvancedRuneSpellId = Spells.Instances.CaptivatingAdoration.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        protected override IEnumerable<Guid> GetProhibitedMagicSchools()
        {
            yield return MagicSchools.Instances.Necromancy.ID;
            yield return MagicSchools.Instances.Transmutation.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.CharmingTouch.ID);
            
            builder
                .GainSpecificSpell(Guid.Parse(""), Spells.Instances.CaptivatingAdoration.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 8);
                });

            builder.ProhibitSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Necromancy.ID);
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
