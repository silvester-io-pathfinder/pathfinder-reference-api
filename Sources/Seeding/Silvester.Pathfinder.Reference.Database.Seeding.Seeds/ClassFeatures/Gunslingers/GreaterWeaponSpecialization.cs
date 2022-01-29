using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class GreaterWeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("c311e723-8ca9-4ad3-81e9-08999e582540");

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
            yield return new TextBlock { Id = Guid.Parse("1c5c0594-e2a7-4fee-81ac-a1fe77aa44f6"), Type = TextBlockType.Text, Text = "Your damage from weapon specialization increases to 4 with weapons and unarmed attacks in which you're an expert, 6 if you're a master, and 8 if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("ee8c5926-484d-46f5-8e74-cfc7695e48c8"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("7d67c10e-a91b-44a0-92c5-7a82eae8d92e"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("841b595d-e1a2-4300-8354-0534cfdec3ff"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("adf15e4b-15ec-4992-9bb1-10f285818a78"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("005063fc-c931-4f15-a3a2-2af944dc81b1"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("db00c7bb-d09b-4596-b343-b50a2417ce20"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("128a4e88-8d46-4723-8070-da8de83fdd7f"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("6affd0d4-e4da-4f0a-9695-063e2fe58fb3"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("ed063e93-e242-4226-96bd-151b1ce0bbd0"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f55911c9-23a4-4a9e-bf2d-910149fd0b83"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
