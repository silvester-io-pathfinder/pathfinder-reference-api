using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Spellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Spellcasting", 
                Description = "Choose a spell in your repertoire or that you prepared today that is at least 5 levels lower than your highest-level spell slot. Your familiar can Cast that Spell once per day using your magical tradition, spell attack modifier, and spell DC. If the spell has a drawback that affects the caster, both you and your familiar are affected. You must be able to cast 6th-level spells using spell slots to select this ability."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 146
            };
        }
    }
}
