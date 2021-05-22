using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorPropertyRunes.Instances
{
    public class WingedRune : Template
    {
        public static readonly Guid ID = Guid.Parse("8adaa470-41e9-4308-bd26-d8d3188d02f4");

        protected override ArmorPropertyRune GetRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Winged",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6036a2f4-03fd-44a3-9a76-ece5df9fe42a"), Type = TextBlockType.Text, Text = "This rune is a swirling glyph on the front of the armor. A large pair of transparent, ephemeral wings floats out from the back of the armor." };
        }

        protected override ArmorPropertyRuneAction? GetAction()
        {
            return new ArmorPropertyRuneAction
            {
                Id = Guid.Parse("c3acb77d-f7f9-4724-ba3a-1a595c620e50"),
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                Name = "Command and Interact",
                Effect = "You trace the rune on the front of the breastplate and the armor's ephemeral wings grow tangible, granting you a fly Speed of 25 feet or your land Speed, whichever is slower.",
                Frequency = "Once per hour."
            };
        }

        protected override IEnumerable<ArmorPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("5a9122b7-a6a1-4da6-87ff-de35ec0e88ad"),
                Benefits = "This effect lasts for 5 minutes or until you Dismiss it. Once the effect ends, the wings disappear completely, reappearing in their ephemeral form 1 hour later.",
                ItemLevel = 13,
                Price = 250000,
                PotencyId = Potencies.Instances.Unclassified.ID,
            };

            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("cfae11f9-8180-46c2-a9be-3aad48e03144"),
                Benefits = "Once activated, the wings remain tangible indefinitely. You can Dismiss the activation if you choose, and you don't have to wait an hour to activate the rune again.",
                ItemLevel = 19,
                Price = 3500000,
                PotencyId = Potencies.Instances.Greater.ID,
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8883e2af-50af-44ad-b20e-261a8acc0f34"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 265
            };
        }

    }
}
