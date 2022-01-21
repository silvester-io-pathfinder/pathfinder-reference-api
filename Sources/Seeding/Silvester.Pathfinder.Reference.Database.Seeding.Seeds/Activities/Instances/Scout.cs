using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Activities.Instances
{
    public class Scout : Template
    {
        public static readonly Guid ID = Guid.Parse("8051da00-e6aa-4d60-ae2e-25918d153aff");
        
        protected override Activity GetActivity()
        {
            return new Activity
            {
                Id = ID, 
                Name = "Scout",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d7c27174-eeae-44a8-9984-1e9a7a86dc44"), Type = TextBlockType.Text, Text = "You scout ahead and behind the group to watch danger, moving at half speed. At the start of the next encounter, every creature in your party gains a +1 circumstance bonus to their initiative rolls." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Exploration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33002b69-2d94-47d5-a72c-acaf1962342d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 480
            };
        }
    }
}
