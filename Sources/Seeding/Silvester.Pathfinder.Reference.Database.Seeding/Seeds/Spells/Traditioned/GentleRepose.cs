using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GentleRepose : Template
    {
        public static readonly Guid ID = Guid.Parse("e8ad8bb3-0f0f-41ed-a1f1-7d9904ce11fa");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Gentle Repose",
                Level = 2,
                Range = "Touch.",
                Duration = "Until the next time you make your daily preparations.",
                Targets = "1 corpse.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("52bebb48-1118-4e3c-871c-462b380a6e78"), Type = TextBlockType.Text, Text = "The targeted corpse doesn’t decay, nor can it be transformed into an undead. If the corpse is subject to a spell that requires the corpse to have died within a certain amount of time (for example, raise dead), do not count the duration of gentle repose against that time. This spell also prevents ordinary bugs and pests (such as maggots) from consuming the body." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("389f4999-2803-46e5-9b5c-30349e4bf809"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("992a4115-39c3-443d-a7df-028494b19063"), Type = TextBlockType.Text, Text = "The spell’s duration is unlimited, but the spell takes one more action to cast and requires a material component and a cost (embalming fluid worth 6 gp)." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d54a0a7-59d0-4448-bd89-8c1d82dc10ee"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 340
            };
        }
    }
}
