using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("1f8bd2fd-29d3-48a1-ad3e-22344a5a9f96");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Weapon Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6bb15467-225b-4f6c-a6cf-e74809a40671"), Type = TextBlockType.Text, Text = "You�ve learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 damage if you�re a master, and 4 damage if you�re legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("3eb155e6-4c6a-438f-be98-a84bec309f99"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("66b2b9ca-9296-4468-b210-33cf41fa46a5"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("2974afb5-610d-4252-bf19-04a3e77c6a91"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("16b38015-57e2-4745-8859-a99e167d3e71"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("eafe3639-6ca9-48cb-ac84-eed104cea6b9"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("0021f37d-f27c-450c-bb49-4154f94b19de"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("ba10e623-e722-49e3-b456-6958c01f82e4"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("afbd31fa-d07f-44a3-874e-f22b7e66e0ca"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("a889ed78-38db-4858-adc7-a9dbd2cfb880"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f477d64-fa9c-42ca-9b9a-5abf8b08a757"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 182
            };
        }
    }
}
