using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class MartialArtist : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Martial Artist",
                DedicationFeatId = Feats.Instances.MartialArtistDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have trained in the martial arts, making your unarmed strikes lethal. You seek neither mysticism nor enlightenment, and you don’t view this training as some greater path to wisdom. Yours is the way of the fist striking flesh, the hand turning aside the blade, and the devastating kick taking your enemy down. Your training is focused and practical, and since you have turned every part of your body into a weapon, you never find yourself without one. While you might have learned your techniques in a dojo or school focused on training the body, you might just as easily have learned them in street brawls and bar fights, combining instincts with intense athleticism for a deadly combination." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 182
            };
        }
    }
}
