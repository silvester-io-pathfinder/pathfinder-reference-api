using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class SpeedRune : Template
    {
        public static readonly Guid ID = Guid.Parse("3ce6bdb7-e2a1-4224-bb8c-d3613973cfbe");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Speed",
                Usage = "Etched onto a weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("c7825ff9-b173-4c02-9d7b-f0f53efc3601"),
                ItemLevel = 16,
                Price = 1000000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("4cbc3872-d879-462c-aa7a-a0afee19dd37"), Type = TextBlockType.Text, Text = "Attacks with a speed weapon are supernaturally swift. While wielding a speed weapon, you gain the quickened condition, but you can use the additional action granted only to make a Strike with the etched weapon."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72f42e77-a941-43c6-9136-eaec11b7e6f5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 585
            };
        }
    }
}
