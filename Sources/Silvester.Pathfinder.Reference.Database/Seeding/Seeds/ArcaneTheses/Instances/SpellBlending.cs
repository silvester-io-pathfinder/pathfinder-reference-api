using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArcaneTheses.Instances
{
    public class SpellBlending : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ArcaneThesis GetArcaneThesis()
        {
            return new ArcaneThesis
            {
                Id = ID, 
                Name = "Spell Blending", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You theorize that spell slots are a shorthand for an underlying energy that powers all spellcasting, and you've found a way to tinker with the hierarchy of spell slots, combining them to fuel more powerful spells." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you make your daily preparations, you can trade two spell slots of the same level for a bonus spell slot of up to 2 levels higher than the traded spell slots. You can exchange as many spell slots as you have available. Bonus spell slots must be of a level you can normally cast, and each bonus spell slot must be of a different spell level. You can also trade any spell slot for two additional cantrips, though you cannot trade more than one spell slot at a time for additional cantrips in this way." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 206
            };
        }
    }
}
