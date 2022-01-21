using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class LightningReflexes : Template
    {
        public static readonly Guid ID = Guid.Parse("cca77cd0-012f-4a09-89c3-3d4ebd38b122");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Lightning Reflexes", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ec14bd8e-a4ff-4d2f-9528-8d9e5c8b1351"), Type = TextBlockType.Text, Text = "Your reflexes are lightning fast. Your proficiency rank for Reflex saves increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("55c19ee6-76f0-4f65-a02d-eca24a6c15bd"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Reflex.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33e8b0a2-103c-4274-94e1-8bbd24b6514a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 40
            };
        }
    }
}
