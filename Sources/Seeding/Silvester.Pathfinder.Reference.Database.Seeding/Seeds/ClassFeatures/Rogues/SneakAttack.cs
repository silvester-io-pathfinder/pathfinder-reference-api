using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class SneakAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("70e98fed-d534-4d34-b23b-dfa800d80a28");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Sneak Attack", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("412dc680-bbb1-4e83-8015-4e188382db35"), Type = TextBlockType.Text, Text = "When your enemy can�t properly defend itself, you take advantage to deal extra damage. If you Strike a creature that has the flat-footed condition with an agile or finesse melee weapon, an agile or finesse unarmed attack, or a ranged weapon attack, you deal an extra 1d6 precision damage. For a ranged attack with a thrown melee weapon, that weapon must also be agile or finesse." };
            yield return new TextBlock { Id = Guid.Parse("0c6ee205-d501-42d2-bee9-2901a2b1476c"), Type = TextBlockType.Text, Text = "As your rogue level increases, so does the number of damage dice for your sneak attack. Increase the number of dice by one at 5th, 11th, and 17th levels." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4e5f209-345c-4e6f-b29a-c20e27b2a05b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 181
            };
        }
    }
}
