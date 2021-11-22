using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ExtractPoison : Template
    {
        public static readonly Guid ID = Guid.Parse("168d90c6-adf8-459d-a2a9-386e62e0758b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Extract Poison",
                Level = 2,
                Range = "Touch.",
                Targets = "1 poison on or in an object.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("049c86af-5dde-4836-af5b-3169ecdcfbdf"), Type = TextBlockType.Text, Text = "With the lightest touch, you can siphon the poison from an object and save it for your own later use, making an assassin�s blade or politician�s wine less deadly while you become all the more so. Attempt a counteract check against one poison you�re aware of on or in an object you touch. If you successfully counteract the poison, you negate the object�s toxicity and transfer the poison into a weapon you are holding, coating the weapon with a simple but powerful poison. On your next successful attack with that weapon before the end of your next turn, you add 1d6 poison damage per level of the poison you counteracted. On a critically failed attack roll, you lose the extracted poison from your weapon as normal." };
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
                Id = Guid.Parse("1c19fc04-749a-4511-96b5-b532faf72d26"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 104
            };
        }
    }
}
