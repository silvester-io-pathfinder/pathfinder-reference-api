using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ArmorModifications
{
    public class MetallicResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("790a4487-360c-4edc-b9d7-e5e5daffd312");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Metallic Resistance",
                Description = "The metals in your armor are carefully alloyed to ground electricity and protect from acidic chemical reactions. You gain resistance equal to 3 + half your level to acid and electricity damage. When under the effects of Overdrive, the resistance increases by 2.",
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
                Id = Guid.Parse("c0097789-477f-49bf-945e-7541a8480c3f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 17
            };
        }
    }
}
