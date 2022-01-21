using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Kinspeech : Template
    {
        public static readonly Guid ID = Guid.Parse("4123490b-7408-4c0a-878c-705d547b37fe");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Kinspeech", 
                Description = "It can understand and speak with animals of the same species. To select this, your familiar must be an animal, it must have the speech ability, and you must be at least 6th level."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("250d8777-97cf-41bf-8ca7-b1c374bfd790"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 218
            };
        }
    }
}
