using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class KeenFlair : Template
    {
        public static readonly Guid ID = Guid.Parse("f18092de-dc69-470b-9e4f-5f8989f1bb7b");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Keen Flair", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4ce5ea06-880c-4524-8559-e589887b8c00"), Type = TextBlockType.Text, Text = "You inflict particularly devastating attacks on even well-defended foes. When you Strike with a weapon or unarmed attack with which you have master proficiency, if you roll a 19 on the die and the roll is a success, you critically succeed instead." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69b3decc-5011-4972-85e3-fa6596e22716"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 87
            };
        }
    }
}
