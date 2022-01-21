using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ArmorModifications
{
    public class PerfectFortification : Template
    {
        public static readonly Guid ID = Guid.Parse("2758650b-69fe-4dda-bd5a-c4875e91bd13");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Perfect Fortification",
                Description = "You've outfitted your armor with such heavy fortifications that deadly attacks often lose their edge. Each time you're critically hit while wearing the armor, attempt a DC 13 flat check. On a success, it becomes a normal hit. This isn't cumulative with fortification runes or other abilities that reduce critical hits with a flat check. Additionally, you gain resistance 2 + half your level against precision damage.",
                InnovationId = Innovations.Instances.Armor.ID,
                TypeId = InnovationModificationTypes.Instances.Revolutionary.ID
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
                Id = Guid.Parse("8ba0d596-87d8-4d8a-b0d6-c2a06c7e763a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 23
            };
        }
    }
}
