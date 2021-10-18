using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class MastersForm : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Master's Form", 
                Description = "Your familiar can change shape as a single action, transforming into a humanoid of your ancestry with the same age, gender, and build of its true form, though it always maintains a clearly unnatural remnant of its nature, such as a cat's eyes or a serpent's tongue. This form is always the same each time it uses this ability. This otherwise uses the effects of humanoid form, except the change is purely cosmetic. It only appears humanoid and gains no new capabilities. Your familiar must have the manual dexterity and speech abilities to select this."
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
