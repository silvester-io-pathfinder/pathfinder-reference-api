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
        public static readonly Guid ID = Guid.Parse("147a3cdd-aded-4027-81b6-83937bca3470");
        
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

        protected override IEnumerable<RuneMagicSchoolBinding> GetProhibitedMagicSchools()
        {
            yield return new RuneMagicSchoolBinding { Id = Guid.Parse("01632b49-7af4-41ac-8e4d-25ca66d99323"), MagicSchoolId = MagicSchools.Instances.Necromancy.ID };
            yield return new RuneMagicSchoolBinding { Id = Guid.Parse("e89f9f2b-7744-4aee-9d46-cab1a0eb63d9"), MagicSchoolId = MagicSchools.Instances.Transmutation.ID };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("e39e64cb-e4f6-40cc-89df-393e60f0994c"), Spells.Instances.CharmingTouch.ID);
            
            builder
                .GainSpecificSpell(Guid.Parse("82cd69cb-7803-4dba-b6da-3f17df540a61"), Spells.Instances.CaptivatingAdoration.ID)
                .AddPrerequisites(Guid.Parse("ed1c6337-1487-426a-a5a4-cfe61eb43c8d"), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("0b2d3632-ad44-4c4e-86bd-f7c41169c2bf"), Comparator.GreaterThanOrEqualTo, requiredLevel: 8);
                });

            builder.ProhibitSpecificMagicSchool(Guid.Parse("6c649d14-e0ac-40ed-a89a-eb1e6afeb53e"), MagicSchools.Instances.Necromancy.ID);
            builder.ProhibitSpecificMagicSchool(Guid.Parse("35e484be-f752-47ad-ac2d-78c8873b1715"), MagicSchools.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c323dae-95ea-4f91-89cb-82c77b3a2454"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 239
            };
        }
    }
}
