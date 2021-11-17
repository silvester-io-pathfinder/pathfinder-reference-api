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
    public class GreaterWeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("4db2d40b-46f6-4ef7-a449-d2e7d2a527ea");

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
            yield return new TextBlock { Id = Guid.Parse("9cea7491-c664-4997-ab38-482c50459a50"), Type = TextBlockType.Text, Text = "Your damage from weapon specialization increases to 4 with weapons and unarmed attacks in which you�re an expert, 6 if you�re a master, and 8 if you�re legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("d8693bb0-4cd8-4a5b-a84d-07b7837ea091"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("12d29dca-c7cd-46d2-9052-bc3aa9bfab63"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("4c838a9a-98e9-4f66-a433-a9b2bd08f051"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("09b115bf-f514-4e54-936e-93ceadba8bf9"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("94a102f7-0974-4d23-8e7d-f251904bc24d"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("466ebe07-1f43-475a-b52e-6ac56447ee23"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("50e0be5c-9b78-4271-a9ef-38c08f4ececa"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("459e70a4-18a2-408b-8d4d-1bb4b536b557"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("265be6b3-fb0c-47c7-b66e-ecdf29537ad9"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d4532cc-8f5d-4fa7-98e0-a2079db64a17"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 109
            };
        }
    }
}
