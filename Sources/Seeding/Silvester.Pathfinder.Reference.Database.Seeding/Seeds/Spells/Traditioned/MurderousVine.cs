using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MurderousVine : Template
    {
        public static readonly Guid ID = Guid.Parse("a256da0c-5532-4b9b-be57-ff19bf5f553a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Murderous Vine",
                Level = 4,
                Range = "60 feet.",
                Duration = "1 minute.",
                Targets = "1 creature adjacent to a flat surface.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1c44c20b-6417-4e93-90e1-529e71b29662"), Type = TextBlockType.Text, Text = "You summon a slithering, thorny vine that attempts to constrict and crush a foe against a wall or other surface. Make a spell attack roll against the target�s Fortitude DC. On a success, the creature is grabbed and takes 3d6 bludgeoning damage and 2d8 piercing damage. At the end of that creature�s turn, if it�s still grabbed by the vine, it takes 2d6 bludgeoning damage." };
            yield return new TextBlock { Id = Guid.Parse("ad40ba8a-3511-4d35-b2d2-bdcb55ff3bfa"), Type = TextBlockType.Text, Text = "The vine�s Escape DC is equal to your spell DC. A creature can attack the vine in an attempt to break its grip. The vine�s AC is equal to your spell DC, and the vine is destroyed if it takes 20 or more damage. Destroying or escaping from the vines ends the spell." };
            yield return new TextBlock { Id = Guid.Parse("21c1717a-bc2b-4a55-9a1c-33d31f0ed2cb"), Type = TextBlockType.Text, Text = "You can Dismiss the spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c028a6ed-902c-4a53-90dd-1b4d62be5fbb"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("802ece0f-d0e4-4d00-b92f-acef2ca53635"), Type = TextBlockType.Text, Text = "The initial bludgeoning damage increases by 1d6, the initial piercing damage increases by 1d8, and the damage a creature takes for ending its turn grabbed by the vine increases by 1d6." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Plant.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("daeedaba-f8aa-42bc-8d5d-a25a63c55980"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 117
            };
        }
    }
}
