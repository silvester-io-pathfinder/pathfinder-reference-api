using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class EldritchArcher : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Eldritch Archer",
                DedicationFeatId = Feats.Instances.EldritchArcherDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "While many archers see their craft as an art form as much as a means of battle, a small number of archers seek to perfect their skills through magic, and you are among their number. Bolstering your athletic and martial abilities with mystical talents, you achieve rare heights with the bow or crossbow—transforming arrows or bolts into eldritch ammunition, sending arrows zig-zagging nearly unerringly to their target, and manifesting arrows that can deliver spells or even instant death." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "While having some spellcasting ability increases your potential flexibility and power as an eldritch archer, you might learn the secrets of these arts without being independently skilled in spellcasting, instead learning the magic of the bow for its own sake." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 172
            };
        }
    }
}
