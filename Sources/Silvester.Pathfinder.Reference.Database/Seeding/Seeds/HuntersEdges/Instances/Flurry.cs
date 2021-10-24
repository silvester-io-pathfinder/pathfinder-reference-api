using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HuntersEdges.Instances
{
    public class Flurry : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override HuntersEdge GetHuntersEdge()
        {
            return new HuntersEdge
            {
                Id = ID, 
                Name = "Flurry",
                Description = "You have trained to unleash a devastating flurry of attacks upon your prey. Your multiple attack penalty for attacks against your hunted prey is –3 (–2 with an agile weapon) on your second attack of the turn instead of –5, and –6 (–4 with an agile weapon) on your third or subsequent attack of the turn, instead of –10."
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyFeatEffects(Guid.Parse(""), Feats.Instances.HuntPrey.ID, and => 
            {
                and.ModifyMultipleAttackPenalty(Guid.Parse(""), MultipleAttackPenalty.SecondAttack, ModifierType.Subtract, modifier: 2, isWithAgileWeapon: false);
                and.ModifyMultipleAttackPenalty(Guid.Parse(""), MultipleAttackPenalty.SecondAttack, ModifierType.Subtract, modifier: 2, isWithAgileWeapon: true);
                and.ModifyMultipleAttackPenalty(Guid.Parse(""), MultipleAttackPenalty.ThirdAttack, ModifierType.Subtract, modifier: 4, isWithAgileWeapon: false);
                and.ModifyMultipleAttackPenalty(Guid.Parse(""), MultipleAttackPenalty.ThirdAttack, ModifierType.Subtract, modifier: 4, isWithAgileWeapon: true);

                and.AddAnd(Guid.Parse(""), and => 
                {
                    and.AddPrerequisites(Guid.Parse(""), prerequisites => 
                    {
                        prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 17);
                        prerequisites.HaveCurrentWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID);
                    });
                    and.ModifyMultipleAttackPenalty(Guid.Parse(""), MultipleAttackPenalty.SecondAttack, ModifierType.Subtract, modifier: 3, isWithAgileWeapon: false);
                    and.ModifyMultipleAttackPenalty(Guid.Parse(""), MultipleAttackPenalty.SecondAttack, ModifierType.Subtract, modifier: 3, isWithAgileWeapon: true);
                    and.ModifyMultipleAttackPenalty(Guid.Parse(""), MultipleAttackPenalty.ThirdAttack, ModifierType.Subtract, modifier: 2, isWithAgileWeapon: false);
                    and.ModifyMultipleAttackPenalty(Guid.Parse(""), MultipleAttackPenalty.ThirdAttack, ModifierType.Subtract, modifier: 2, isWithAgileWeapon: true);
                });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 168
            };
        }
    }
}
