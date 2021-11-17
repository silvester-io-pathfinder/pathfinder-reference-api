using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class ManualDexterity : Template
    {
        public static readonly Guid ID = Guid.Parse("2601a067-6056-48f4-8a69-4e1c8bfdba2b");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Manual Dexterity",
                Description = "Your construct innovation has articulated hands or similar appendages with significant manual dexterity. It can perform manipulate actions with up to two of its limbs. As normal for a companion, it still can't wield weapons or held items that don't have the companion trait, and it can't activate items.",
                InnovationId = Innovations.Instances.Construct.ID,
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
                Id = Guid.Parse("31dd9e06-f662-4339-b7a8-b1d07ed2e36d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 18
            };
        }
    }
}
