using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Tenets.Instances
{
    public class Good : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Tenet GetTenet()
        {
            return new Tenet
            {
                Id = ID, 
                Name = "Good",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "You must never perform acts anathema to your deity or willingly commit an evil act, such as murder, torture, or the casting of an evil spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "You must never knowingly harm an innocent, or allow immediate harm to one through inaction when you know you could reasonably prevent it. This tenet doesn't force you to take action against possible harm to innocents at an indefinite time in the future, or to sacrifice your life to protect them." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 106
            };
        }
    }
}
