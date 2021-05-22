using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class WordOfTruth : Template
    {
        public static readonly Guid ID = Guid.Parse("501214f3-f47e-4efb-9a3f-e1f3acd7b700");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Word of Truth",
                Level = 1,
                Duration = "1 minute.",
                DomainId = Domains.Instances.Truth.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("511b62e8-30aa-4c9f-8a6a-0649506f3f7f"), Type = TextBlockType.Text, Text = "You speak a statement you believe to be true and that is free of any attempt to deceive through twisting words, omission, and so on. The statement must be 25 words or fewer. A symbol of your deity glows above your head, and anyone who sees you and hears your statement knows that you believe it to be true." };
            yield return new TextBlock { Id = Guid.Parse("55050491-0fc7-465d-aaeb-0787cb92fb78"), Type = TextBlockType.Text, Text = "Each time you Sustain this Spell, you can repeat this effect." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eae0635c-6b2d-4a57-b108-f0c122ffd505"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 399
            };
        }
    }
}
