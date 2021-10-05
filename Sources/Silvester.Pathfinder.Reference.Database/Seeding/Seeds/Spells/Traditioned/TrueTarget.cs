using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TrueTarget : Template
    {
        public static readonly Guid ID = Guid.Parse("014fc787-f0a9-41ec-a59e-835b07ee0245");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "True Target",
                Level = 7,
                Range = "60 feet.",
                Duration = "Until the start of your next turn.",
                Targets = "4 creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d3ce3d44-56b2-4c5a-963c-1a3918442c81"), Type = TextBlockType.Text, Text = "You delve into the possible futures of the next few seconds to understand all the ways your foe might avoid harm, then cast out a vision of that future to those around you. Designate a creature. The first time each target makes an attack roll against that creature during true target’s duration, the attacker rolls twice and uses the better result. The attacker also ignores circumstance penalties to the attack roll and any flat check required due to the designated creature being concealed or hidden." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Fortune.ID;
            yield return Traits.Instances.Prediction.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69acf376-2d7d-4ac6-8f99-0eeeee9f9a25"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 379
            };
        }
    }
}
