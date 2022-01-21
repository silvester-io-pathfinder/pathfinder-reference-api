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
    public class Wrath : Template
    {
        public static readonly Guid ID = Guid.Parse("1eaf7e3d-37df-429d-a0ee-bbf99eade8e4");
        
        protected override RuneMagic GetRuneMagic()
        {
            return new RuneMagic
            {
                Id = ID, 
                Name = "Wrath",
                Description = "Runelords of evocation channel raw destructive energies and direct them toward all who would oppose their will.",
                InitialRuneSpellId = Spells.Instances.WeaponSurge.ID,
                AdvancedRuneSpellId = Spells.Instances.ZealForBattle.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        protected override IEnumerable<RuneMagicSchoolBinding> GetProhibitedMagicSchools()
        {
            yield return new RuneMagicSchoolBinding { Id = Guid.Parse("eae9ad34-3e7d-4f6c-90b1-9987f76db65b"), MagicSchoolId = MagicSchools.Instances.Abjuration.ID };
            yield return new RuneMagicSchoolBinding { Id = Guid.Parse("ca5c07ac-77b3-4caa-902e-82b9d55655ff"), MagicSchoolId = MagicSchools.Instances.Conjuration.ID };
        }


        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("61a2625b-9a92-4142-806f-293227fea1f7"), Spells.Instances.WeaponSurge.ID);
            
            builder
                .GainSpecificSpell(Guid.Parse("b800c2b5-1766-432b-afa5-50c316f0d212"), Spells.Instances.ZealForBattle.ID)
                .AddPrerequisites(Guid.Parse("2f617dc8-3776-4844-8788-83590cf5b93b"), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("d2e76c1a-76c4-4418-9bcc-16c9b7ed417b"), Comparator.GreaterThanOrEqualTo, requiredLevel: 8);
                });

            builder.ProhibitSpecificMagicSchool(Guid.Parse("c32f9e6e-c9dc-42ff-bdc3-c2f704bbfbba"), MagicSchools.Instances.Abjuration.ID);
            builder.ProhibitSpecificMagicSchool(Guid.Parse("221d5061-e4a7-4197-8b4d-b16c5570901c"), MagicSchools.Instances.Conjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9c2be7b-ec94-492f-99dc-a12cfa93261b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 239
            };
        }
    }
}
