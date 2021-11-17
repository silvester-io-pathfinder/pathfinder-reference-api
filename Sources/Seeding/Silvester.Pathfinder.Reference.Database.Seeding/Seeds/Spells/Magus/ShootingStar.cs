using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShootingStar : Template
    {
        public static readonly Guid ID = Guid.Parse("ea1cc8a6-d074-469e-9569-5a97fe8fd6cf");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shooting Star",
                Level = 1,
                Requirements = "You're wielding a ranged weapon or a thrown weapon.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Magus.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("467522e9-4fd1-4e9e-862e-e21ac4e84309"), Type = TextBlockType.Text, Text = "You let loose a projectile that flies true and leaves the blazing trail of a meteor behind it. Make a ranged Strike, ignoring the target's concealment and reducing the target's cover by one degree for this Strike only (greater to standard, standard to lesser, and lesser to none). If the Strike hits, the meteor trail hangs in the air. This gives the benefits of concealment negation and cover reduction to any attacks made against the creature (by anyone) until the start of your next turn." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Magus.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8237680a-6451-44b9-88d8-1a21f09d1182"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 143
            };
        }
    }
}
