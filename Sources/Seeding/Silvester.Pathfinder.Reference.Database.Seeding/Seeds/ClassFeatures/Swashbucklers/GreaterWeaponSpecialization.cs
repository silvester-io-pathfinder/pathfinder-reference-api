using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class GreaterWeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("dc8cd0ca-e5c2-44e1-b01b-954d54549014");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Greater Weapon Specialization", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("da673151-facd-4248-afe9-be96715e561c"), Type = TextBlockType.Text, Text = "Your damage from weapon specialization increases to 4 with weapons and unarmed attacks in which you�re an expert, 6 if you�re a master, and 8 if you�re legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("86b96980-de62-4b14-a397-560372f0c70d"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("19f49922-ffc3-4944-9cb9-070d4b62f425"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("ae3db87b-6188-4150-95ad-8fe4031b6b88"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("8039e829-b11e-4331-afec-be448377e51a"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("c896bf6c-66ae-4268-9623-3fb21556a9b2"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("7dba7c7e-0dd1-4aa5-b8e7-56f15445fdb1"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("17076b94-0013-466e-9ce7-93f7a5f415ac"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("a68a42c3-f2c5-436b-8aa0-859e8daa8778"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("29da6247-a0c9-4627-8066-eca38902cd5d"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14e8204b-415d-40a3-a5c8-9eb31892fbdf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 87
            };
        }
    }
}
