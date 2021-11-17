using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ArmorModifications
{
    public class TensileAbsorption : Template
    {
        public static readonly Guid ID = Guid.Parse("3f8feec9-a4a1-4cec-bb60-a100de72d822");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Tensile Absorption",
                Description = "You've enhanced the tensile capabilities of your armor, enabling it to bend with bludgeoning attacks. While wearing your armor, you gain resistance to bludgeoning damage equal to half your level.",
                InnovationId = Innovations.Instances.Armor.ID,
                TypeId = InnovationModificationTypes.Instances.Breakthrough.ID
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fdef0526-112b-43a9-924c-e6af7fe16dc0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 21
            };
        }
    }
}