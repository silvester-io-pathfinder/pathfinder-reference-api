using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Spellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("f32a8f8a-26ce-46af-81fa-e7e1250a7b5b");

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
                Id = Guid.Parse("f8c37509-32a5-4421-8731-e7e35ccd9722"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 146
            };
        }
    }
}
