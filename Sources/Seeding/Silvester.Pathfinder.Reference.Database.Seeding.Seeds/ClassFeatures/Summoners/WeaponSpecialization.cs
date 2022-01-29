using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("b3ebab91-4a8b-4c61-a553-39e281421a4d");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Weapon Specialization", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("34ffa1db-1747-4190-8deb-e21ee84f7577"), Type = TextBlockType.Text, Text = "you've learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 damage if you're a master, and 4 damage if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("f3b8993c-42b4-4570-9699-ba469df42f1a"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("1d640fbe-66c3-450b-9fef-cef49cdf6d12"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("a343d21d-88dd-433e-9ebb-6c4f70d46a2f"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("33740fb9-5081-4070-9796-08dd54b4aaf3"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("cc65c91f-c90c-4ad2-b0ff-4bda22d19a0b"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("8cae7fad-285f-47c1-8fb9-f3d170f1b220"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("efa9c0a1-686a-4439-84dc-315c080395c6"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("39bcbefc-0f74-47b8-805f-f53ee2bf2479"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("59863bc9-9864-42e8-8829-bd1c9463dcda"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c3e739e-3e76-4053-8c7a-295f531169a1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 57
            };
        }
    }
}
