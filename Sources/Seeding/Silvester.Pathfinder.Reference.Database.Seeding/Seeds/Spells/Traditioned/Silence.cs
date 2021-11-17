using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Silence : Template
    {
        public static readonly Guid ID = Guid.Parse("5903b11d-1660-440b-88f5-36af62e32738");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Silence",
                Level = 2,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9936245d-7832-41e9-9933-5732dd390ade"), Type = TextBlockType.Text, Text = "The target makes no sound, preventing creatures from noticing it using hearing or other senses alone. The target can’t use sonic attacks, nor can it use actions with the auditory trait. This prevents it from casting spells that include verbal components." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("8446dd11-5f2d-4216-ad48-85c285a1977b"), 
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("57b64ace-afe9-4b49-81ad-0e48b0347890"), Type = TextBlockType.Text, Text = "The spell effect emanates from the touched creature, silencing all sound in or passing through a 10-foot radius and preventing any auditory and sonic effects in the affected area. While within the radius, creatures are subject to the same effects as the target. Depending upon the position of the effect, a creature might notice the lack of sound reaching it (blocking off the noise coming from a party, for example)." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("adae39d1-2c5b-472d-b9b7-6fd27f693002"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 369
            };
        }
    }
}
