using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class InventorClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("8ac18a6a-1a3e-484a-800d-e1dbe4cf3007");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Inventor Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d8116aa5-07af-4789-bdc7-ae8ad9d8d64b"), Type = TextBlockType.Text, Text = "At 1st level and every even-numbered level, you gain an inventor class feat. Some features and feats use an assortment of gizmos you keep on your person. For simplicity, these are left abstract, but if you are deprived of your gear for some reason, you might lose access to many feats and features, subject to GM discretion." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("76e5522e-621c-484b-b52f-da3a8f066798"), Guid.Parse("869d3aed-f6e8-43e5-821e-cfcc21a76755"), Classes.Instances.Inventor.ID, level: 1);
            builder.GainAnyClassFeat(Guid.Parse("059e8679-7aa4-4f2a-bc09-5fc70e8b5f6f"), Guid.Parse("d28e65ad-2e6a-4cfd-870c-47154e80833f"), Classes.Instances.Inventor.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("1a3f90f3-2c57-4173-ad19-9363e5e39440"), Guid.Parse("c19c4c52-415a-4541-9f17-b06e08137f5d"), Classes.Instances.Inventor.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("4a4edfae-a7f3-4ae5-869c-7b3a95a77c44"), Guid.Parse("7346aea5-fa45-4ac6-9c8a-960dceadc5aa"), Classes.Instances.Inventor.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("153328ca-15f3-4a73-b3e7-0a18d5e473c1"), Guid.Parse("6a28011d-8c55-4692-8584-c42bc2719852"), Classes.Instances.Inventor.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("5b03cefc-f3e4-44b8-8b2c-d319723a0152"), Guid.Parse("a8a26c11-8c51-4fca-97dd-9df098f5749f"), Classes.Instances.Inventor.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("4ba1b5ba-5fc3-45b3-b64c-9b3b7e30a043"), Guid.Parse("6ad8b2fa-9d46-4ec1-bd92-44182ab4a601"), Classes.Instances.Inventor.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("34ed28a5-8b1e-4f70-a38b-e6877ee174f2"), Guid.Parse("fec5f30c-c330-41cc-9967-4687b2835c9e"), Classes.Instances.Inventor.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("11c682a8-97ad-4b8a-bf29-b4b9dce07b4c"), Guid.Parse("11561df3-0939-407c-b4e0-707d9e6e590e"), Classes.Instances.Inventor.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("a1e4b755-596b-42d7-a1be-7dab010e4c8e"), Guid.Parse("bb6d5c08-1f11-4667-8f59-5d6934e7f80a"), Classes.Instances.Inventor.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("15e645d5-7169-4e16-aa09-4f80eea95bdb"), Guid.Parse("56599c14-264c-4766-9299-24cfa0b96b60"), Classes.Instances.Inventor.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2148bdd7-c182-4b58-864a-05852478e6fd"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 20
            };
        }
    }
}
