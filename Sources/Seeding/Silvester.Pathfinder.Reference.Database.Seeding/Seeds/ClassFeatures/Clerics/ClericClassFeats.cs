using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class ClericClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("68c63c05-273f-4846-bf08-47f08f050319");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Name = "Cleric Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c0a4d4a2-6ba6-49c3-9639-ec6b33a8218c"), Type = TextBlockType.Text, Text = "At 2nd level and every two levels thereafter, you gain a cleric class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("d656a6bf-8b41-4cdc-b0db-a807661b2302"), Guid.Parse("d28ce30f-75d0-4482-89e5-53c4699c761b"), Classes.Instances.Cleric.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("2139f9d3-e338-4fa3-b75f-e01f4871d07e"), Guid.Parse("606857b2-33c6-4b2b-a063-d3d3eb7285bb"), Classes.Instances.Cleric.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("6532a607-7320-4cfb-af8a-dc013499bd5d"), Guid.Parse("8537684a-34ee-4cc2-a174-317b3da3615c"), Classes.Instances.Cleric.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("5820c7ba-1ef9-4bd2-a107-567d13b4eb58"), Guid.Parse("60290962-6f93-45d1-999d-550c5577f7e6"), Classes.Instances.Cleric.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("8553cc72-bbf8-45e8-8228-9c2d1a49e0b0"), Guid.Parse("6293bef4-7e7d-4ce0-abc0-b1ad6aeb6427"), Classes.Instances.Cleric.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("81d99f92-6f5d-489c-8467-85516ab005b1"), Guid.Parse("5d109c33-496f-483c-a002-908e7dee9e96"), Classes.Instances.Cleric.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("3eceda1e-ffbc-4b94-8bad-656fd96047ab"), Guid.Parse("b1f79008-a3b0-40c7-b57e-89e86bcbe61c"), Classes.Instances.Cleric.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("167bd6c5-bf4f-487e-bfe9-02a5a1f0f709"), Guid.Parse("bd8c2d46-7134-4eef-b720-b00d097caf8b"), Classes.Instances.Cleric.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("5422be7f-855d-4ce2-9516-185e37e2fbdf"), Guid.Parse("a88e3adc-3d3a-445c-8b2c-52a6b801e5fc"), Classes.Instances.Cleric.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("39ca666c-988b-450b-8dec-784a7fb36e8f"), Guid.Parse("b019fd1f-92a0-45c7-8b95-46b9f3ce9bd3"), Classes.Instances.Cleric.ID, level: 20);  
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cebdf955-8d0a-499f-bccd-bf7207d76e23"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 120
            };
        }
    }
}
