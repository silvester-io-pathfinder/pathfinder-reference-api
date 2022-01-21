using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class ChampionsCode : Template
    {
        public static readonly Guid ID = Guid.Parse("5e7c655c-732d-458f-9a7a-d0e40b3b81dc");

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
            yield return new TextBlock { Id = Guid.Parse("762ec5fd-2dc7-44ce-a38b-d3d6ab68c756"), Type = TextBlockType.Text, Text = "You follow a code of conduct, beginning with tenets shared by all champions of an alignment (such as good), and continuing with tenets of your cause. Deities often add additional strictures (for instance, Torag�s champions can�t show mercy to enemies of their people, making it almost impossible for them to follow the redeemer cause). Tenets are listed in order of importance, starting with the most important. If a situation places two tenets in conflict, you aren�t in a no-win situation; instead, follow the more important tenet. For instance, as a paladin, if an evil king asked you if you�re hiding refugees so he could execute them, you could lie to him, since the tenet against lying is less important than preventing harm to innocents. Trying to subvert your code by creating a situation that forces a higher tenet to override a lower tenet (for example, promising not to respect authorities and then, to keep your word, disrespecting authorities) is a violation of the champion code." };
            yield return new TextBlock { Id = Guid.Parse("f985c9d6-75ad-45bb-a7b9-c88f125cfd96"), Type = TextBlockType.Text, Text = "If you stray from your alignment or violate your code of conduct, you lose your focus pool and divine ally until you demonstrate your repentance by conducting an atone ritual, but you keep any other champion abilities that don�t require those class features. If your alignment shifts but is still one allowed by your deity, your GM might let you retrain your cause while still following the same deity." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyTenet(Guid.Parse("9993be09-861e-437a-9288-0d0904f0ceb8"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef6b2e03-c9ef-428e-ae99-12ef9d973642"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 106
            };
        }
    }
}
