using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances
{
    public class Dwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("96a536c5-7fe0-4a25-af8b-881a2892b576");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 20, 
                Name = "Dwarf", 
                BaseHealth = 10, 
                RarityId = Rarities.Instances.Common.ID, 
                SizeId = AncestrySizes.Instances.Medium.ID, 
                Description = "Dwarves have a well-earned reputation as a stoic and stern people, ensconced within citadels and cities carved from solid rock. While some see them as dour and humorless crafters of stone and metal, dwarves and those who have spent time among them understand their unbridled zeal for their work, caring far more about quality than quantity. To a stranger, they can seem untrusting and clannish, but to their friends and family, they are warm and caring, their halls filled with the sounds of laughter and hammers hitting anvils." 
            };
        }

        protected override IEnumerable<Guid> GetLanguages()
        {
            yield return Languages.Instances.Common.ID;
            yield return Languages.Instances.Dwarven.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Dwarf.ID;
        }
    }
}
