using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HybridStudies.Instances
{
    public class StarlitSpan : Template
    {
        public static readonly Guid ID = Guid.Parse("122c5a62-a8db-4421-b5d5-db921b73de21");
        
        protected override HybridStudy GetHybridStudy()
        {
            return new HybridStudy
            {
                Id = ID, 
                Name = "Starlit Span",
                ConfluxSpellId = Spells.Instances.ShootingStar.ID,
                SeventhSpellId = Spells.Instances.Darkvision.ID,
                EleventhSpellId = Spells.Instances.WallOfWind.ID,
                ThirteenthSpellId = Spells.Instances.FreedomOfMovement.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d4c8f54e-6f3f-4b35-a6b2-142f8f9173ec"), Type = TextBlockType.Text, Text = "With magic, the sky's the limit, and you can't be bound by the confines of physical proximity. Your power reaches as far as your senses can perceive, transcending the space between you and your target even with spells that normally require direct physical contact." };
            yield return new TextBlock { Id = Guid.Parse("6f0bd26a-a0ef-4a57-b063-1dd16c2b8680"), Type = TextBlockType.Text, Text = "When you use Spellstrike, you can make a ranged weapon or ranged unarmed Strike, as long as the target is within the first range increment of your ranged weapon or ranged unarmed attack. You can deliver the spell even if its range is shorter than the range increment of your ranged attack." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Add the conflux spell.
            builder.GainSpecificSpell(Guid.Parse("b9cc59a1-fd9a-4868-a38c-940f584a4c7c"), Spells.Instances.ShootingStar.ID);

            //Add studious spell slots from level 7 up to and excluding to 11.
            builder.GainSpecificSpellSlot(Guid.Parse("fcaf5c75-c09f-45f9-8dea-2aeb237808ad"), amount: 2, spellSlotLevel: 2, isSpendingPreventable: true)
               .AddPrerequisites(Guid.Parse("d1ce1e94-07cb-49a0-9e89-0f7e90481ea4"), prerequisites =>
               {
                   prerequisites.HaveSpecificLevel(Guid.Parse("4d85b5a8-8aa2-4042-a7fa-32efc3697da4"), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                   prerequisites.HaveSpecificLevel(Guid.Parse("951f35af-13b0-4c99-8aed-e9925636a04e"), Comparator.LessThan, requiredLevel: 11);
               });

            //Add studious spell slots from level 11 up to and excluding to 13.
            builder.GainSpecificSpellSlot(Guid.Parse("5e30848c-0663-493f-9cc9-c55eb473ab15"), amount: 2, spellSlotLevel: 3, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse("37db9c53-d2dc-4034-8394-79aade100d8e"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("caffa035-6ea2-41fa-950b-fe6946dd2d2f"), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                    prerequisites.HaveSpecificLevel(Guid.Parse("3ae5a330-d7b7-4728-8c81-3ee6212f13c0"), Comparator.LessThan, requiredLevel: 13);
                });

            //Add studious spell slots from level 13 and beyond.
            builder.GainSpecificSpellSlot(Guid.Parse("6d8389de-dc1f-432a-8fe9-639b20b73a06"), amount: 2, spellSlotLevel: 4, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse("1ccf6b38-2fef-4627-8238-ed4916c31b25"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("6880f24e-58d6-4ce3-9431-4812f56126f7"), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                });

            builder.AddAnd(Guid.Parse("ef2766f9-d4bc-4c32-acef-eae3efd643fc"), and =>
            {
                and.AddPrerequisites(Guid.Parse("6a464ae2-2423-46b8-9af3-a87e43831a33"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("639c3b46-ae29-4bf5-bede-0ced6baf23e8"), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                });
                and.GainSpecificSpell(Guid.Parse("f90605d0-a350-481d-9f10-0b7a402c9056"), Spells.Instances.SpiderClimb.ID);
                and.GainSpecificSpell(Guid.Parse("bd65f650-cd2b-43aa-925f-7fc53fd54429"), Spells.Instances.TrueStrike.ID);
                and.GainSpecificSpell(Guid.Parse("eb13abd2-e2c2-4877-9a10-5bf54ef4f3a8"), Spells.Instances.WaterBreathing.ID);
                and.GainSpecificSpell(Guid.Parse("8d25a64a-ff3b-4910-885b-4c861992a510"), Spells.Instances.Darkvision.ID);
            });

            builder
              .GainSpecificSpell(Guid.Parse("872aea39-0b00-4f90-bcbf-5a032433ba17"), Spells.Instances.WallOfWind.ID)
              .AddPrerequisites(Guid.Parse("10d1659b-a175-4cc7-a051-f611f107c2d3"), prerequisites =>
              {
                  prerequisites.HaveSpecificLevel(Guid.Parse("87f29d37-7181-4bc1-9860-ef671efc4db3"), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
              });

            builder
                .GainSpecificSpell(Guid.Parse("156feea5-3e25-4908-b613-8de09ff7c492"), Spells.Instances.FreedomOfMovement.ID)
                .AddPrerequisites(Guid.Parse("ae18d51d-7536-40f2-b05f-1f682a5ec0c3"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("0eddab36-541e-430c-976c-9597ed62d54f"), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                });

            //TODO: Add the Arcane Cascade modification effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a79feda4-9a7f-4479-bd66-bfa1081a6b55"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 39
            };
        }
    }
}
