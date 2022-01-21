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
        public static readonly Guid ID = Guid.Parse("e6647ca6-0df1-4f18-983d-22c4654ac2b2");

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
            builder.AddAnd(Guid.Parse("064a85e6-de82-49a4-ac54-96899168f956"), and => 
            {
                and.Name("First Doctrine");
                and.GainSpecificArmorCategoryProficiency(Guid.Parse("1a22d54b-32d3-4e0e-a71a-ab7a85919d45"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
                and.GainSpecificArmorCategoryProficiency(Guid.Parse("bb4b78b3-bd0c-4c35-b776-7d9db4af4128"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
                and.GainSpecificSavingThrowProficiency(Guid.Parse("5a324aaa-9af7-42b0-8f35-9ea2ee117a97"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
                and.GainSpecificFeat(Guid.Parse("7f1cc5c3-5375-40e7-aebe-e73e1e2aa587"), Feats.Instances.ShieldBlock.ID);
                and.GainSpecificFeat(Guid.Parse("75aaec4b-39ab-4735-80ea-803229222fcc"), Feats.Instances.DeadlySimplicity.ID)
                    .AddPrerequisites(Guid.Parse("8723f285-2f26-4ea9-9486-4d26958cef78"), prerequisites => 
                    {
                        prerequisites.HaveSpecificDeityWeaponCategory(Guid.Parse("658795a9-a67d-45bc-a0b8-60a962044476"), WeaponCategories.Instances.Simple.ID);
                    });
                and.GainSpecificArmorCategoryProficiency(Guid.Parse("58a157cc-4890-46ed-98fc-616ee703863b"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID)
                    .AddPrerequisites(Guid.Parse("5c202d09-3ac7-4c28-b2ee-115e4f5f6d93"), prerequisites =>
                    {
                        prerequisites.HaveSpecificLevel(Guid.Parse("5122764c-028a-4b57-a0cd-090b7146bee6"), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                    });
                and.GainSpecificArmorCategoryProficiency(Guid.Parse("abb914b7-01c4-4173-9301-9b8e2d4ac994"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.MediumArmor.ID)
                   .AddPrerequisites(Guid.Parse("68be3c98-36c4-49b7-892b-b2ae13ba97c4"), prerequisites =>
                   {
                       prerequisites.HaveSpecificLevel(Guid.Parse("e0a79a3a-fcfa-4d5e-bef0-6cf35e1d483d"), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                   });
            });


            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("5156800f-b9b7-48de-93a3-c80f696b4ddd"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Martial.ID)
                .Name("Second Doctrine")
                .AddPrerequisites(Guid.Parse("b91022ab-3b77-4b86-834d-1d8fbc411c82"), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("098842ac-e201-4a52-9b4c-0ca9f191b85f"), Comparator.GreaterThanOrEqualTo, requiredLevel: 3);
                });

            builder.AddAnd(Guid.Parse("c17bb601-2b6f-4c82-abcf-7121bb99e112"), and =>
            {
                and.Name("Third Doctrine");
                and.AddPrerequisites(Guid.Parse("fb2b87ce-7b9b-4ee0-85d2-e5f4fcf68d92"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("4a7bac2e-f9fb-496e-820f-7069542425be"), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                });
                and.GainDeityFavoredWeaponProficiency(Guid.Parse("9241f66d-85c1-4720-80d5-f04a0fadcd21"), Proficiencies.Instances.Expert.ID);
                and.GainDeityFavoredWeaponSpecialization(Guid.Parse("15f17ec1-8e9e-4143-a574-f26b26a4c420"));
            });

            builder.AddAnd(Guid.Parse("1bbbdc84-ddbe-4c70-b5c8-a6237b1f5f89"), and =>
            {
                and.Name("Fourth Doctrine");
                and.AddPrerequisites(Guid.Parse("6260e6b3-fb90-4dad-a20d-68db3a2c60b4"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("a63fce16-6fbc-4de4-94c8-bbeb24ec667f"), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                });
                and.GainSpecificSpellAttackProficiency(Guid.Parse("49713729-5a44-4571-bb7f-55a1507364f4"), Proficiencies.Instances.Expert.ID);
                and.GainSpecificSpellDcProficiency(Guid.Parse("b66cf424-e546-4718-a88a-65524a9b546a"), Proficiencies.Instances.Expert.ID);
            });

            builder.AddAnd(Guid.Parse("c78aa63d-8453-4382-b6d3-c0ec730cc530"), and =>
            {
                and.Name("Fifth Doctrine");
                and.AddPrerequisites(Guid.Parse("e8c9d81e-ddfb-481d-88d6-93ae05aa489b"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("450d43d2-9abb-46bf-b69b-6890d81c0002"), Comparator.GreaterThanOrEqualTo, requiredLevel: 15);
                });
                and.GainSpecificSavingThrowProficiency(Guid.Parse("36745bcc-170e-455a-92d6-43863aeebb5c"), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Fortitude.ID);
                and.ImproveSpecificSavingThrow(Guid.Parse("9e36d160-edfc-4c24-bf2a-9fed9c4a47ce"), SavingThrowStats.Instances.Fortitude.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
            });

            builder.AddAnd(Guid.Parse("986e9fda-1d9c-4730-bbde-08675439703c"), and =>
            {
                and.Name("Final Doctrine");
                and.AddPrerequisites(Guid.Parse("350e8817-78e1-4cdf-ad7f-88c18ff62415"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("2d30990b-314a-4447-b1e5-8b12b5dc9e0e"), Comparator.GreaterThanOrEqualTo, requiredLevel: 19);
                });
                and.GainSpecificSpellAttackProficiency(Guid.Parse("79c4b42f-989e-4e20-93a3-a277087a7b4f"), Proficiencies.Instances.Master.ID);
                and.GainSpecificSpellDcProficiency(Guid.Parse("47d2a36c-23dc-4fdf-af17-f49aec27c2b9"), Proficiencies.Instances.Master.ID);
            });
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18f0ecec-e1ee-4141-a42a-9dc8d9307305"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 120
            };
        }
    }
}
