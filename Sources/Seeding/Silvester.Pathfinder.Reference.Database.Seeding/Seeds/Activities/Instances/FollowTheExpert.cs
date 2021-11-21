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
    public class FollowTheExpert : Template
    {
        public static readonly Guid ID = Guid.Parse("c3ec9969-57d2-49ef-8693-3ae072833ce6");
        
        protected override Activity GetActivity()
        {
            return new Activity
            {
                Id = ID, 
                Name = "Follow the Expert",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f3d97185-b7eb-4711-abc6-c75b5afe76f9"), Type = TextBlockType.Text, Text = "Choose an ally attempting a recurring skill check while exploring, such as climbing, or performing a different exploration tactic that requires a skill check (like Avoiding Notice). The ally must be at least an expert in that skill and must be willing to provide assistance. While Following the Expert, you match their tactic or attempt similar skill checks. Thanks to your ally�s assistance, you can add your level as a proficiency bonus to the associated skill check, even if you�re untrained. Additionally, you gain a circumstance bonus to your skill check based on your ally�s proficiency (+2 for expert, +3 for master, and +4 for legendary)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Exploration.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73196d82-9500-4168-8854-2f732d1c05df"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 479
            };
        }
    }
}
