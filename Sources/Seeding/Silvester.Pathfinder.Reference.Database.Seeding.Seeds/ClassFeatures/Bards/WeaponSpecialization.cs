using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("5fcfe78f-5090-4d87-b248-d28342d22d00");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Weapon Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7c427575-62f7-4c44-83a2-6d7f8dea6dcd"), Type = TextBlockType.Text, Text = "you've learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 damage if you're a master, and 4 damage if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("8f49bdb9-11f5-4a07-8544-3d165e9f3247"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("06670801-2506-4ee3-aa80-4462ae6106c1"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("b20c353f-2e24-4cd2-ab11-17119ab5253d"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("285f1b41-469f-47ce-951a-ae06e193bb9c"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("0947b995-a667-4c6d-b765-d57d774dcbee"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("297c0f1b-cf0a-4bc1-a7c0-c754b7ececfa"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("24e2cb32-fc15-4e83-bc41-4b70779ae69d"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("dd7707ba-8e01-46c5-bc96-291f45bfa3b6"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("1f8b744b-587f-4bbb-bdfd-98c40065fd2f"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7f3b985-835e-42ce-90d6-56a63f54b1a6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 99
            };
        }
    }
}
