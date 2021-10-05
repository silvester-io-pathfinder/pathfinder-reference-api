using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races.Instances
{
    public class Orc : Template
    {
        public static readonly Guid ID = Guid.Parse("903f97e5-6972-4ad2-9377-447b7d6758a3");

        protected override Race GetRace()
        {
            return new Race 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Orc", 
                BaseHealth = 10, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SizeId = RaceSizes.Instances.Medium.ID, 
                Description = "Orcs are forged in the fires of violence and conflict, often from the moment they are born. As they live lives that are frequently cut brutally short, orcs revel in testing their strength against worthy foes, whether by challenging a higher-ranking member of their community for dominance or raiding a neighboring settlement. Many orcs seek glory as soon as they can walk and carry a blade or club, taming wild beasts or hunting deadly monsters." 
            };
        }

        protected override IEnumerable<Guid> GetLanguages()
        {
            yield return Languages.Instances.Common.ID;
            yield return Languages.Instances.Orcish.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Orc.ID;
        }
    }
}
