using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Tenets.Instances
{
    public class Evil : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Tenet GetTenet()
        {
            return new Tenet
            {
                Id = ID, 
                Name = "Evil",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The tenets and causes of evil follow the rules provided in the Core Rulebook. While evil characters in general can range from self-serving but loyal allies to the extremes of depravity, evil champions are particularly vile, with a code that requires, enforces, and depends upon their villainous behavior. This means they can be extremely disruptive to a typical game and should be accessible player character options only in appropriate adventures or campaigns where the group collectively decides to embrace them. The tenets and causes of evil are uncommon options. While the feats and actions suitable for evil champions don't separately list access entries, typically if your GM grants you access to evil tenets, you also gain access to champion actions and feats that require those tenets." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "You must never perform acts anathema to your deity or willingly commit a purely good act, such as giving something solely out of charity, casting a good spell, or using a good item." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "You must never put another person's needs before your own, and you must never put your own needs before those of your deity. Though you can perform acts others might consider helpful, it must be done with the expectation that it ultimately furthers your own goals or those of your master." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 116
            };
        }
    }
}
