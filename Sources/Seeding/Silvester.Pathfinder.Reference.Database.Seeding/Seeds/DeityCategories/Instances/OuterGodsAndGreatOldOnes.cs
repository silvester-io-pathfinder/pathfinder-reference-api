using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class OuterGodsAndGreatOldOnes : Template
    {
        public static readonly Guid ID = Guid.Parse("cb0c42c1-2f21-4c52-b419-09d55a7b8eca");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            {
                Id = ID, 
                Name = "Outer Gods and Great Old Ones", 
                Description = "The Outer Gods, along with the Great Old Ones with whom the Outer Gods are sometimes confused, are ancient, inscrutable, cosmic beings. The Great Old Ones are titanic monstrosities imprisoned since time immemorial beneath the sea, deep within the world, or on other planets, but the Outer Gods are even less comprehensible. These unfathomable entities lurk within the Dark Tapestry—the vast void between the stars on the Material Plane—and dwarf other deities just as those deities dwarf ordinary mortals. To worship these gods is to acknowledge a cold truth: the universe has no meaning. All the things mortal civilizations hold dear—virtues, deities, great works— are things those mortals have invented to distract them from their own insignificance. History is a comforting lie told because mortals are afraid of the dark. The universe is immeasurably vast, beyond understanding, and cares nothing for life. Ultimately, every creature is alone, unmourned, and unloved. And because life has no meaning or purpose, self-indulgence and nihilism are the only rational responses." 
            };
        }
    }
}
