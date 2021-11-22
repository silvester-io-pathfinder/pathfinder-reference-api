using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LuckyNumber : Template
    {
        public static readonly Guid ID = Guid.Parse("8a58c607-fe57-4a89-923d-917a34c3e043");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Lucky Number",
                Level = 2,
                Duration = "Until the next time you make your daily preparations.",
                CastTime = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39ff845a-36e1-4c68-84f2-616645b27925"), Type = TextBlockType.Text, Text = "When you Cast this Spell, roll 1d20 and make a note of the result. You gain the following reaction; once you use the reaction, the spell ends, and you become temporarily immune to lucky number until the next time you make your daily preparations." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("326e6a7b-b04c-46d4-8299-2c9af03f304b"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Name = "That's My Number!",
                Trigger = "You roll your lucky number as your d20 result on a non-secret attack roll, saving throw, or skill check;",
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("666f3c10-676f-4b81-a913-c65c7b8ab438"), Type = TextBlockType.Text, Text = "You call upon the fortune stored within your lucky number and reroll the triggering check. However, pushing your luck has a price: if your result on the reroll is the same number again, you critically fail, regardless of what degree of success you ordinarily would have received." }
                }
            };
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Contingency.ID;
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ba358a9-c263-483d-a00c-7995fafec73f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 113
            };
        }
    }
}
