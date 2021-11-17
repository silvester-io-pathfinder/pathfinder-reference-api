using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ReflectiveScales : Template
    {
        public static readonly Guid ID = Guid.Parse("9fb2e5f9-0fe8-4794-b8cf-969c144c5f1c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Reflective Scales",
                Level = 4,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("148e8ceb-3385-4117-9fad-0e564850dbdf"), Type = TextBlockType.Text, Text = "You grow a set of colored glowing scales or scaled armor that stores energy before releasing it in a final burst. When you cast this spell, choose acid, cold, fire, electricity, or poison damage. You gain resistance 5 against that type of damage. The scales� color depends on the damage type you chose and is usually the color of a type of dragon or other creature associated with that damage type, such as red or gold for fire damage." };
            yield return new TextBlock { Id = Guid.Parse("c72c59c1-f43b-461b-bfeb-743a1b854af9"), Type = TextBlockType.Text, Text = "The scales store up energy as they protect you. Keep track of how much damage the scales have prevented. As a 2-action activity that has the concentrate and manipulate traits, you can explode your scales outward in a 20-foot radius around you, dealing 1d6 damage of the chosen type to all creatures in the area for every 10 damage the scales have prevented, to a maximum of 10d6 damage (after preventing 100 damage). Once you do so, the spell ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ed4ff22e-0c8c-490f-ada8-0462e4b77274"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("3d8ddd0d-48a8-4aa8-bbe0-230efddb4942"), Type = TextBlockType.Text, Text = "The resistance increases by 5 and the maximum damage from the scale explosion increases by 5d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f69df87-d63a-4a4b-b2c4-a3eb03007047"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 109
            };
        }
    }
}
