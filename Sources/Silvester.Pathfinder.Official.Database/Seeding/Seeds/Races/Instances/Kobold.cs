using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances
{
    public class Kobold : Template
    {
        public static readonly Guid ID = Guid.Parse("a6f1c39a-feb8-4f62-95ce-1b5ffabbbbbf");

        protected override Race GetRace()
        {
            return new Race 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Kobold", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SizeId = RaceSizes.Instances.Small.ID, 
                Description = "Every kobold knows that their slight frame belies true, mighty draconic power. They are ingenious crafters and devoted allies within their warrens, but those who trespass into their territory find them to be inspired skirmishers, especially when they have the backing of a draconic sorcerer or true dragon overlord. However, these reptilian opportunists prove happy to cooperate with other humanoids when it’s to their benefit, combining caution and cunning to make their fortunes in the wider world." 
            };
        }

        protected override IEnumerable<Guid> GetLanguages()
        {
            yield return Languages.Instances.Common.ID;
            yield return Languages.Instances.Draconic.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Kobold.ID;
        }
    }
}
