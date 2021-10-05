using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Morph : Template
    {
        public static readonly Guid ID = Guid.Parse("89277379-cc7a-47de-8dc2-60eea16e9757");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Morph",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("820fde1a-0326-4641-ba15-c9cd38685443"), Type = TextBlockType.Text, Text = "Effects that slightly alter a creature’s form have the morph trait. Any Strikes specifically granted by a morph effect are magical. You can be affected by multiple morph spells at once, but if you morph the same body part more than once, the second morph effect attempts to counteract the first (in the same manner as two polymorph effects, described in that trait)." };
            yield return new TextBlock { Id = Guid.Parse("ac8eed70-000e-4eae-a2c9-b3f546246661"), Type = TextBlockType.Text, Text = "Your morph effects might also end if you are polymorphed and the polymorph effect invalidates or overrides your morph effect. The GM determines which morph effects can be used together and which can’t." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("beb30b27-79ff-44db-b924-2dad2b9b4c16"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
