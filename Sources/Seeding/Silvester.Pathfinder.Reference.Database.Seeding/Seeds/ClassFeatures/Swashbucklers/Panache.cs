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
    public class Panache : Template
    {
        public static readonly Guid ID = Guid.Parse("98fa6e44-ecab-408f-9966-605d6e3b09bc");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Panache", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4ffe3361-8142-4d43-add8-f776b1d366fb"), Type = TextBlockType.Text, Text = "You care as much about the way you accomplish something as whether you actually accomplish it in the first place. When you perform an action with particular bravado, you can leverage this moment of verve to perform spectacular, deadly maneuvers. This state of flair is called panache, and you are either in a state of panache or you are not." };
            yield return new TextBlock { Id = Guid.Parse("49e0e4d0-f208-4692-8a3a-de97f79ed810"), Type = TextBlockType.Text, Text = "You gain panache by successfully performing the skill check associated with specific actions that have a bit of flair, including Tumble Through and additional actions determined by your swashbuckler's style. At the GM's discretion, after succeeding at a check to perform a particularly daring action, such as swinging on a chandelier or sliding down a drapery, you also gain panache if your result is high enough (typically the very hard DC for your level, but the GM can choose a different threshold)." };
            yield return new TextBlock { Id = Guid.Parse("06b255f5-b403-4f59-8cba-a78d894afb61"), Type = TextBlockType.Text, Text = "While you have panache, you gain a +5-foot status bonus to your Speeds and gain a +1 circumstance bonus to checks to Tumble Through or to take any actions that give you panache due to your style. The precise strike class feature also causes you to deal extra precision damage while you have panache. Powerful finisher actions, including Confident Finisher can be used only while you have panache and cause you to lose your panache." };
            yield return new TextBlock { Id = Guid.Parse("987cc9d7-c1aa-4d3e-b0cc-9ed1f0a0ad0a"), Type = TextBlockType.Text, Text = "Normally, you gain and use panache only in combat encounters; when an encounter ends, you lose panache." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a371bdfb-6e3e-43e3-afae-f708b2ede465"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 84
            };
        }
    }
}
