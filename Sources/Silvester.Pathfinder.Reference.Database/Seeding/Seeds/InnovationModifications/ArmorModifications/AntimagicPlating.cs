using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ArmorModifications
{
    public class AntimagicPlating : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Antimagic Plating",
                Description = "Whether you used some clever adaptation of the magic-negating skymetal known as noqual or created magical protections of your own design, you've strengthened your armor against magic. While wearing the armor, you gain a +1 circumstance bonus to all saving throws against spells and to AC against spells. Against spells that target the armor directly (like heat metal), you instead gain a +4 circumstance bonus to all saving throws and to AC.",
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 20
            };
        }
    }
}
