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
        public static readonly Guid ID = Guid.Parse("df82b2e8-3a76-419c-874d-e538b8bd0fa0");
        
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

        protected override IEnumerable<RuneMagicSchoolBinding> GetProhibitedMagicSchools()
        {
            yield return new RuneMagicSchoolBinding { Id = Guid.Parse("2fd42bc9-3cdf-427f-83c6-70f6b86cfc20"), MagicSchoolId = MagicSchools.Instances.Abjuration.ID };
            yield return new RuneMagicSchoolBinding { Id = Guid.Parse("6388abff-5dd9-4617-b8e4-c96a8fcac7ac"), MagicSchoolId = MagicSchools.Instances.Enchantment.ID };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("c7be28d5-8b38-44ba-8a76-f5584ec4c296"), Spells.Instances.Overstuff.ID);
            
            builder
                .GainSpecificSpell(Guid.Parse("f704cbab-6bf9-4284-b04b-6a94dbacd923"), Spells.Instances.TakeItsCourse.ID)
                .AddPrerequisites(Guid.Parse("663b346d-0b1d-4dcf-89e9-e49abafe6bb0"), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("56987fea-6afc-4c86-9e24-a9b7749d7aae"), Comparator.GreaterThanOrEqualTo, requiredLevel: 8);
                });

            builder.ProhibitSpecificMagicSchool(Guid.Parse("8b4f0363-3b98-4a64-bc6f-de7651d30250"), MagicSchools.Instances.Abjuration.ID);
            builder.ProhibitSpecificMagicSchool(Guid.Parse("c89b6e87-d537-48f6-b5c9-62b1af131819"), MagicSchools.Instances.Enchantment.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47e4ab24-c5b2-4514-a63c-1054c94705f3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 239
            };
        }
    }
}
