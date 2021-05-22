using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SecretPage : Template
    {
        public static readonly Guid ID = Guid.Parse("3df0714b-20ce-42da-902c-eb08d5f2fd1d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Secret Page",
                Level = 3,
                CastTime = "1 minute.",
                Range = "Touch.",
                Duration = "Unlimited",
                Targets = "1 page up to 3 square feet in size.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ca0ff2c1-468d-44e9-abb8-643410446353"), Type = TextBlockType.Text, Text = "You change the target’s text to different text entirely. If the text is a spellbook or a scroll, you can change it to show a spell you know of secret page’s level or lower. The replacement spell cannot be cast or used to prepare a spell. You can also transform the text into some other text you have written or have access to. You can specify a password that allows a creature touching the page to change the text back and forth. You must choose the replacement text and the password, if any, when you Cast the Spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bc3acec-afd6-4b48-b56f-24554ca7e9ec"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 367
            };
        }
    }
}
