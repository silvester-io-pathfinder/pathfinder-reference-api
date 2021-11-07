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
        public static readonly Guid ID = Guid.Parse("");
        
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

        protected override IEnumerable<Guid> GetProhibitedMagicSchools()
        {
            yield return MagicSchools.Instances.Evocation.ID;
            yield return MagicSchools.Instances.Necromancy.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.BlindAmbition.ID);

            builder
                .GainSpecificSpell(Guid.Parse(""), Spells.Instances.CompetitiveEdge.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 8);
                });

            builder.ProhibitSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Evocation.ID);
            builder.ProhibitSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 238
            };
        }
    }
}
