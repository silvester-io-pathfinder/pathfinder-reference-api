using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class ChampionsCode : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Champion's Code", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You follow a code of conduct, beginning with tenets shared by all champions of an alignment (such as good), and continuing with tenets of your cause. Deities often add additional strictures (for instance, Torag’s champions can’t show mercy to enemies of their people, making it almost impossible for them to follow the redeemer cause). Tenets are listed in order of importance, starting with the most important. If a situation places two tenets in conflict, you aren’t in a no-win situation; instead, follow the more important tenet. For instance, as a paladin, if an evil king asked you if you’re hiding refugees so he could execute them, you could lie to him, since the tenet against lying is less important than preventing harm to innocents. Trying to subvert your code by creating a situation that forces a higher tenet to override a lower tenet (for example, promising not to respect authorities and then, to keep your word, disrespecting authorities) is a violation of the champion code." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you stray from your alignment or violate your code of conduct, you lose your focus pool and divine ally until you demonstrate your repentance by conducting an atone ritual, but you keep any other champion abilities that don’t require those class features. If your alignment shifts but is still one allowed by your deity, your GM might let you retrain your cause while still following the same deity." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainAnyTenetEffect { Id = Guid.Parse("") };
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
