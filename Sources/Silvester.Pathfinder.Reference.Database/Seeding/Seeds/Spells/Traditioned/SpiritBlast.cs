using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiritBlast : Template
    {
        public static readonly Guid ID = Guid.Parse("05c8ccda-0aaa-4b9e-92d8-219e0a80b395");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spirit Blast",
                Level = 6,
                Range = "30 feet.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c68f8897-c511-4cd9-9d23-cbd9359f23f5"), Type = TextBlockType.Text, Text = "You concentrate ethereal energy and attack a creature’s spirit, dealing 16d6 force damage. Because spirit blast affects the creature’s spirit, it can damage a target projecting its consciousness (such as via project image) or possessing another creature even if the target’s body is elsewhere. The possessed creature isn’t harmed by the blast. The blast doesn’t harm creatures that have no spirit, such as constructs." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b1c1500b-fced-422f-b451-ffc10ab01377"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0f28b3c3-b35a-4c87-81dc-0893380b1528"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Force.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c086b0fb-9b7a-4afe-aa7f-72eca7459c45"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 371
            };
        }
    }
}
