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
    public class CloisteredCleric : Template
    {
        public static readonly Guid ID = Guid.Parse("0c551519-d9be-44b7-ba4c-3bbae0b280b8");

        public override Doctrine GetDoctrine()
        {
            return new Doctrine
            {
                Id = ID,
                Name = "Cloistered Cleric",
                Description = "You are a cleric of the cloth, focusing on divine magic and your connection to your deity's domains."
            };
        }

        public override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("5b73a458-4954-45e9-a066-16833ae866b2"), Feats.Instances.DomainInitiate.ID)
                .Name("First Doctrine");

            builder.GainSpecificSavingThrowProficiency(Guid.Parse("012b487f-8ca0-46ee-b646-1e75bcb04633"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID)
                .AddPrerequisites(Guid.Parse("736dd918-3c9b-465b-a348-53eabfac3c2f"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("cebfbe56-96ad-473a-8e38-eae7655b22d1"), Comparator.GreaterThanOrEqualTo, requiredLevel: 3);
                })
                .Name("Second Doctrine");

            builder.AddAnd(Guid.Parse("61b391d6-3421-4ca6-bb46-b30e64bcd013"), and =>
            {
                and.Name("Third Doctrine");
                and.AddPrerequisites(Guid.Parse("f0222dde-96cb-405c-8fe8-e7a2a910ccb2"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("68b7432b-0cbd-4d5f-b306-6fe93b5fb59b"), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                });
                and.GainSpecificSpellAttackProficiency(Guid.Parse("f7f66178-7832-4014-8757-8ee5ab5072e8"), Proficiencies.Instances.Expert.ID);
                and.GainSpecificSpellDcProficiency(Guid.Parse("6e497079-45ae-4035-91c7-c8d7a71b5004"), Proficiencies.Instances.Expert.ID);
            });

            builder.AddAnd(Guid.Parse("0c4782ae-6998-4f52-9a00-7215c4de7ef3"), and =>
            {
                and.Name("Fourth Doctrine");
                and.AddPrerequisites(Guid.Parse("88022a2d-00a3-44d2-975d-0c3f6e5383ee"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("4ea10efe-5149-476d-9fde-157fd61fb013"), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                });
                and.GainDeityFavoredWeaponProficiency(Guid.Parse("3520d82c-a481-4d55-a784-5fabad3b5bbc"), Proficiencies.Instances.Expert.ID);
                and.GainDeityFavoredWeaponSpecialization(Guid.Parse("786a7f04-baa3-475e-8770-0dc02d4d5767"));
            });

            builder.AddAnd(Guid.Parse("23105702-69b9-4a1c-bc1a-2481f5060068"), and =>
            {
                and.Name("Fifth Doctrine");
                and.AddPrerequisites(Guid.Parse("47dc9fca-7b4f-43c8-b022-0c3e315408be"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("8bdfb646-c619-4146-98b8-07e7645217e6"), Comparator.GreaterThanOrEqualTo, requiredLevel: 15);
                });
                and.GainSpecificSpellAttackProficiency(Guid.Parse("2eb71d4d-dbbb-4d04-b7f9-aed12310883c"), Proficiencies.Instances.Master.ID);
                and.GainSpecificSpellDcProficiency(Guid.Parse("b1149370-2589-4e96-8c5f-f4ac87564960"), Proficiencies.Instances.Master.ID);
            }); 
            
            builder.AddAnd(Guid.Parse("233e2daf-297b-4a1e-8b57-b3be44394f5f"), and =>
            {
                and.Name("Final Doctrine");
                and.AddPrerequisites(Guid.Parse("89c7506b-9100-4f4e-a2c1-07ca9f22dfc1"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("4dc697d9-0b6c-49b8-930c-d232153346fc"), Comparator.GreaterThanOrEqualTo, requiredLevel: 19);
                });
                and.GainSpecificSpellAttackProficiency(Guid.Parse("07ce648b-92a0-4fce-a833-4b84bee0df0a"), Proficiencies.Instances.Legendary.ID);
                and.GainSpecificSpellDcProficiency(Guid.Parse("c140876e-7674-417f-89a9-52efc69566f9"), Proficiencies.Instances.Legendary.ID);
            });
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ef2a7bb-1659-4846-a214-5233cddba31c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 119
            };
        }
    }
}
