using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ArmorModifications
{
    public class MuscularExoskeleton : Template
    {
        public static readonly Guid ID = Guid.Parse("2789687b-3f9e-4f3a-94f3-40bbc57419e7");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Muscular Exoskeleton",
                Description = "Your armor supports your muscles with a carefully crafted exoskeleton. When you send your armor into overdrive, the exoskeleton supplements your feats of athletics as well. When under the effects of Overdrive, you gain a +1 circumstance bonus to Athletics checks; if you're a master in Crafting, this increases to a +2 circumstance bonus.",
                InnovationId = Innovations.Instances.Armor.ID,
                TypeId = InnovationModificationTypes.Instances.Initial.ID
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects (with restriction on Power Suit somehow..).

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f379c45-db17-45b1-9196-3481e8fc10e9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 17
            };
        }
    }
}
