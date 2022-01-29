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
    public class SurpriseAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("4a0f3dc2-0174-465b-ba9b-1bd670b8eb2f");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Surprise Attack", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a47aa06e-3e69-4ff0-89a1-17b1a59cb295"), Type = TextBlockType.Text, Text = "You spring into combat faster than foes can react. On the first round of combat, if you roll Deception or Stealth for initiative, creatures that haven't acted are flat-footed to you." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd1f53af-67af-448a-b5ac-51fd606417a1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 181
            };
        }
    }
}
