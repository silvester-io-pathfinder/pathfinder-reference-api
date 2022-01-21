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
    public class Greed : Template
    {
        public static readonly Guid ID = Guid.Parse("8ac8caa0-2cc8-4461-b368-a9f15162b391");
        
        protected override RuneMagic GetRuneMagic()
        {
            return new RuneMagic
            {
                Id = ID, 
                Name = "Greed",
                Description = "Runelords of transmutation not only transform objects to create value, but also transform and enhance their own power.",
                InitialRuneSpellId = Spells.Instances.AppearanceOfWealth.ID,
                AdvancedRuneSpellId = Spells.Instances.PreciousMetals.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        protected override IEnumerable<RuneMagicSchoolBinding> GetProhibitedMagicSchools()
        {
            yield return new RuneMagicSchoolBinding { Id = Guid.Parse("f4fdbcdd-f633-4dba-bc4e-67440f048d7f"), MagicSchoolId = MagicSchools.Instances.Enchantment.ID };
            yield return new RuneMagicSchoolBinding { Id = Guid.Parse("06571278-0171-4c9f-8e06-151782a1dc55"), MagicSchoolId = MagicSchools.Instances.Illusion.ID };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("eb678688-20bc-412f-a611-6850eae8991d"), Spells.Instances.AppearanceOfWealth.ID);
            
            builder
                .GainSpecificSpell(Guid.Parse("3f27101e-a65c-4e67-a0f5-a27f98766920"), Spells.Instances.PreciousMetals.ID)
                .AddPrerequisites(Guid.Parse("6e9aa533-0802-4967-b44e-d2ae62d47420"), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("f90ef912-3139-45c4-b195-ed22a12e4024"), Comparator.GreaterThanOrEqualTo, requiredLevel: 8);
                });

            builder.ProhibitSpecificMagicSchool(Guid.Parse("325cd2f9-e610-4ac6-8317-b60d419303da"), MagicSchools.Instances.Enchantment.ID);
            builder.ProhibitSpecificMagicSchool(Guid.Parse("f0017d61-d095-44f2-a1e4-2c32f7355e7b"), MagicSchools.Instances.Illusion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("333c6478-e926-4e4f-baed-2202294671e1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 239
            };
        }
    }
}
