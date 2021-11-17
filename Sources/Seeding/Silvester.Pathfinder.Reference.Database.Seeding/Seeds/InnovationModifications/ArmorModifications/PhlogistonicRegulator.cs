using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ArmorModifications
{
    public class PhlogistonicRegulator : Template
    {
        public static readonly Guid ID = Guid.Parse("0eb22080-d89e-45fb-bd21-5b0c9646e3ba");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Phlogistonic Regulator",
                Description = "A layer of insulation within your armor protects you from rapid temperature fluctuations. You gain resistance equal to half your level to cold and fire damage. When under the effects of Overdrive, the resistance increases by 2. Speed Boosters: You have boosters in your armor that increase your Speed. You gain a +5-foot status bonus to your Speed, which increases to a +10-foot status bonus when under the effects of Overdrive.",
                InnovationId = Innovations.Instances.Armor.ID,
                TypeId = InnovationModificationTypes.Instances.Initial.ID
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
                Id = Guid.Parse("5f746eb5-18d1-47fc-a98d-ea038bb557cb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 17
            };
        }
    }
}