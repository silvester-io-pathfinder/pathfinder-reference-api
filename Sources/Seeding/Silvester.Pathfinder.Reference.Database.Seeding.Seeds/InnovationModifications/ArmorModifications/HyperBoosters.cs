using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ArmorModifications
{
    public class HyperBoosters : Template
    {
        public static readonly Guid ID = Guid.Parse("2c75c127-77ae-43ff-8b2d-78e7e3211dab");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Hyper Boosters",
                Description = "You've improved your speed boosters' power through a breakthrough that significantly increases the energy flow without risking exploding. You gain a +10-foot status bonus to your Speed, which increases to a +20-foot status bonus when you're in Overdrive. If you're legendary in Crafting, it instead increases to a +30-foot status bonus when you're in Overdrive. You must have the speed boosters modification to select this modification.",
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
                Id = Guid.Parse("79dd8973-8774-4f8e-a3d9-2f6f435f972a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 21
            };
        }
    }
}
