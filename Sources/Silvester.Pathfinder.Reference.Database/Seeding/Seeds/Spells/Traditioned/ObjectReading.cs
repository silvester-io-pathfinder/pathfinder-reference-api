using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ObjectReading : Template
    {
        public static readonly Guid ID = Guid.Parse("97490ac8-c0dd-4857-a1c7-e93ecc436a02");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Object Reading",
                Level = 1,
                Range = "Touch.",
                Targets = "1 object.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("023aa018-ad1b-4d43-86bf-5bf127e4fabb"), Type = TextBlockType.Text, Text = "You place a hand on an object to learn a piece of information about an emotional event that occurred involving the object within the past week, determined by the GM. If you cast object reading on the same item multiple times, you can either concentrate on a single event to gain additional pieces of information about that event, or gain a piece of information about another emotional event in the applicable time frame." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f44a9aa7-fb79-48a1-be17-bab79dec1a75"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e2322f5d-2c65-4d75-a23c-31766747235e"), Type = TextBlockType.Text, Text = "You can learn about an event that occurred within the last month." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("90daf34c-9d1e-4cc5-bbd8-6ffa4044a7c6"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2f7ff9da-47f8-415b-b36e-941640ddeaa1"), Type = TextBlockType.Text, Text = "You can learn about an event that occurred within the last year." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("898140df-4e34-4c6e-b5c3-aa20e78c0ebc"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b8e67ece-a57a-43a1-b1cf-34e63d368171"), Type = TextBlockType.Text, Text = "You can learn about an event that occurred within the last decade." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("4ef9202e-4517-460c-a816-b7f0bcb198d4"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("3d0a01e8-ba41-4cb9-9d2a-a988a0b104ec"), Type = TextBlockType.Text, Text = "You can learn about an event that occurred within the last century." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("0cc79235-a53a-4993-9cbd-d2e2fa86d601"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2539b2e0-f4a8-4a15-a515-a724b3d50585"), Type = TextBlockType.Text, Text = "You can learn about an event that occurred within the entirety of the object’s history." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c342e2cf-aec4-4c54-9797-01192f59dcd7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 222
            };
        }
    }
}
