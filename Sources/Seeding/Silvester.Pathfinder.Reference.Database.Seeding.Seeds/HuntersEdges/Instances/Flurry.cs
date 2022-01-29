using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HuntersEdges.Instances
{
    public class Flurry : Template
    {
        public static readonly Guid ID = Guid.Parse("1f956588-ba54-4dfd-b1b3-b0a315121055");
        
        protected override HuntersEdge GetHuntersEdge()
        {
            return new HuntersEdge
            {
                Id = ID, 
                Name = "Flurry",
                Description = "You have trained to unleash a devastating flurry of attacks upon your prey. Your multiple attack penalty for attacks against your hunted prey is -3 (-2 with an agile weapon) on your second attack of the turn instead of -5, and -6 (-4 with an agile weapon) on your third or subsequent attack of the turn, instead of -10."
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyFeatEffects(Guid.Parse("f4f7069e-0477-4957-a440-73effd4465b0"), Guid.Parse("bf788923-5728-4d9c-a8b1-b5810fa26ed6"), Feats.Instances.HuntPrey.ID, and => 
            {
                and.ModifyMultipleAttackPenalty(Guid.Parse("4c2cca36-7f28-4af5-aa23-88c0f12615f5"), MultipleAttackPenalty.SecondAttack, ModifierType.Subtract, modifier: 2, isWithAgileWeapon: false);
                and.ModifyMultipleAttackPenalty(Guid.Parse("2c3fac44-aaaa-4e3e-852c-db4ae8f9bf34"), MultipleAttackPenalty.SecondAttack, ModifierType.Subtract, modifier: 2, isWithAgileWeapon: true);
                and.ModifyMultipleAttackPenalty(Guid.Parse("638774e0-c83d-44cc-90fe-24f99f347879"), MultipleAttackPenalty.ThirdAttack, ModifierType.Subtract, modifier: 4, isWithAgileWeapon: false);
                and.ModifyMultipleAttackPenalty(Guid.Parse("34a57435-16f1-4d96-9d8a-566295f96d5a"), MultipleAttackPenalty.ThirdAttack, ModifierType.Subtract, modifier: 4, isWithAgileWeapon: true);

                and.AddAnd(Guid.Parse("0717c3d3-d847-4d09-9d3e-6c1ee61296fc"), and => 
                {
                    and.AddPrerequisites(Guid.Parse("fd5d3c0a-a19c-4fcb-92a3-ec4fa0da403b"), prerequisites => 
                    {
                        prerequisites.HaveSpecificLevel(Guid.Parse("d41f6410-e41c-4ec2-ba32-a4490de7052e"), Comparator.GreaterThanOrEqualTo, requiredLevel: 17);
                        prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("8fd0757e-3aa9-4019-8bde-d7e2049f6665"), Comparator.GreaterThanOrEqualTo, Proficiencies.Instances.Master.ID);
                    });
                    and.ModifyMultipleAttackPenalty(Guid.Parse("bec27a6c-bd0e-4144-b0c7-66e1d8c63955"), MultipleAttackPenalty.SecondAttack, ModifierType.Subtract, modifier: 3, isWithAgileWeapon: false);
                    and.ModifyMultipleAttackPenalty(Guid.Parse("60dac535-e0fa-4138-af7f-28041771ac7c"), MultipleAttackPenalty.SecondAttack, ModifierType.Subtract, modifier: 3, isWithAgileWeapon: true);
                    and.ModifyMultipleAttackPenalty(Guid.Parse("653ebaac-f0b2-4638-8d7c-b99fb643e5dd"), MultipleAttackPenalty.ThirdAttack, ModifierType.Subtract, modifier: 2, isWithAgileWeapon: false);
                    and.ModifyMultipleAttackPenalty(Guid.Parse("c2dd38af-4ded-4856-b820-4c55862895d6"), MultipleAttackPenalty.ThirdAttack, ModifierType.Subtract, modifier: 2, isWithAgileWeapon: true);
                });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b899050-e828-4c65-922e-064cff73c422"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 168
            };
        }
    }
}
