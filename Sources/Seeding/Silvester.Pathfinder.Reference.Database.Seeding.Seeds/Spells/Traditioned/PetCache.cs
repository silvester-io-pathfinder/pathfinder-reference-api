using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PetCache : Template
    {
        public static readonly Guid ID = Guid.Parse("c8c32ec6-c79f-4197-9423-22c9ab174711");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Pet Cache",
                Level = 1,
                Range = "Touch.",
                IsDismissable = true,
                Duration = "8 hours.",
                Targets = "1 willing creature that is your animal companion or familiar.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("37fa3590-08b2-4d8f-ad86-1cd6e301af3b"), Type = TextBlockType.Text, Text = "You open your cloak or create a gap with your hands, drawing the target into a pocket dimension just large enough for its basic comfort. No other creature can enter this extradimensional space, and the target can bring along objects only if they were designed to be worn by a creature of its kind. The space has enough air, food, and water to sustain the target for the duration." };
            yield return new TextBlock { Id = Guid.Parse("6f961c46-c835-473c-9245-89bf5f6b768c"), Type = TextBlockType.Text, Text = "You can Dismiss the spell. The spell also ends if you die or enter an extradimensional space. When the spell ends, the target reappears in the nearest unoccupied space (outside of any extradimensional space you may have entered)." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("f0b6e433-1cc0-40d0-878a-bd69af8bbd64"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("50c1ef6e-cd5d-4300-b240-04252a859f4e"), Traits.Instances.Extradimensional.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89667bfe-ffce-4da6-aa7f-3fda44292bee"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 222
            };
        }
    }
}
