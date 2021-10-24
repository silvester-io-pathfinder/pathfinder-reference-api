using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Doctrines.Instances
{
    public class Warpriest : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Doctrine GetDoctrine()
        {
            return new Doctrine
            {
                Id = ID,
                Name = "Warpriest",
                Description = "You have trained in the more militant doctrine of your church, focusing on both spells and battle."
            };
        }

        public override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddAnd(Guid.Parse(""), and => 
            {
                and.Name("First Doctrine");
                and.GainSpecificArmorCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
                and.GainSpecificArmorCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
                and.GainSpecificSavingThrowProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
                and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.ShieldBlock.ID);
                and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.DeadlySimplicity.ID)
                    .AddPrerequisites(Guid.Parse(""), prerequisites => 
                    {
                        prerequisites.HaveSpecificDeityWeaponCategory(Guid.Parse(""), WeaponCategories.Instances.Simple.ID);
                    });
                and.GainSpecificArmorCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID)
                    .AddPrerequisites(Guid.Parse(""), prerequisites =>
                    {
                        prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                    });
                and.GainSpecificArmorCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.MediumArmor.ID)
                   .AddPrerequisites(Guid.Parse(""), prerequisites =>
                   {
                       prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                   });
            });


            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Martial.ID)
                .Name("Second Doctrine")
                .AddPrerequisites(Guid.Parse(""), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 3);
                });

            builder.AddAnd(Guid.Parse(""), and =>
            {
                and.Name("Third Doctrine");
                and.AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                });
                and.GainDeityFavoredWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID);
                and.GainDeityFavoredWeaponSpecialization(Guid.Parse(""));
            });

            builder.AddAnd(Guid.Parse(""), and =>
            {
                and.Name("Fourth Doctrine");
                and.AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                });
                and.GainSpecificSpellAttackProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID);
                and.GainSpecificSpellDcProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID);
            });

            builder.AddAnd(Guid.Parse(""), and =>
            {
                and.Name("Fifth Doctrine");
                and.AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 15);
                });
                and.GainSpecificSavingThrowProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Fortitude.ID);
                and.ModifySpecificSavingThrow(Guid.Parse(""), SavingThrowStats.Instances.Fortitude.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
            });

            builder.AddAnd(Guid.Parse(""), and =>
            {
                and.Name("Final Doctrine");
                and.AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 19);
                });
                and.GainSpecificSpellAttackProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID);
                and.GainSpecificSpellDcProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID);
            });
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 120
            };
        }
    }
}
