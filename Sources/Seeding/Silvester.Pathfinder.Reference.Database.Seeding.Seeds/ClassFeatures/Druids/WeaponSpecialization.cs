using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Druids
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("bb0a409b-1e31-4255-9895-74bd7c20542f");

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
            yield return new TextBlock { Id = Guid.Parse("39efe97f-9456-4541-b12c-24a62055f0dc"), Type = TextBlockType.Text, Text = "you've learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 damage if you're a master, and 4 damage if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("db14efc4-5af7-45c9-bbfc-0e2b5bb7ed82"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("0a631199-6025-4e67-bf65-d38ee064f261"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("469dc029-c7ec-41a0-bc0a-73dae8f81e26"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("df00bab5-d611-4947-b233-dfcde918a2d9"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("9b91502d-ed92-49ef-86ae-564146cc4fb9"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("f553e385-3cca-46e8-9ba3-69a3c8d2355f"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("341403bb-ccf1-4dfb-b383-171708bd5b02"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("5aa9df1d-f35e-4b76-a3bb-9bec459bc515"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("cf076ad2-7006-4701-b36e-74c2b934543e"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce4a60bc-3c76-4273-8df3-abf8050851f7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 133
            };
        }
    }
}
