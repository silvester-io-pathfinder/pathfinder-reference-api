using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("ce36c05b-4169-4b6a-8915-5a2067fafce1");

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
            yield return new TextBlock { Id = Guid.Parse("136dab02-1d9b-4391-b250-61765e6c740b"), Type = TextBlockType.Text, Text = "You�ve learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 if you�re a master, and to 4 if you�re legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("a75032a8-b647-4405-85b0-13c30030624b"), ModifierType.Add, modifier: 2)
               .AddPrerequisites(Guid.Parse("5fc1f7ca-2f73-4e51-ad9e-17351ef96336"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("981a1e1c-ef47-4589-9468-3b50de922d50"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
               });

            builder.ModifyWeaponDamage(Guid.Parse("56c4da55-9217-4136-aae2-90966459f413"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("fcbc3a64-dc63-44a4-af65-fe3881583e86"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("36aeb2ff-417a-4857-9351-ebdb5df3ec8b"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("a0e423bf-cb4c-4a1e-93af-849bdb1385c1"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("116b4d34-3fe7-4b2b-a944-52b430cd298e"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("550cd2c9-d482-4647-82ef-2bfb0064bb55"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("211ef840-e223-4fea-8f4e-3e9664bcc039"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
