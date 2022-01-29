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
    public class DeificWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("79bdc8af-4ace-467f-8379-aa9f37631401");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Deific Weapon", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a67a301c-ea0c-4523-b530-2aa516f4ec4c"), Type = TextBlockType.Text, Text = "You zealously bear your deity's favored weapon. If it's uncommon, you gain access to it. If it's an unarmed attack with a d4 damage die or a simple weapon, increase the damage die by one step (d4 to d6, d6 to d8, d8 to d10, d10 to d12)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6f1be7f-7dfb-4f9a-9bb3-486a670b4990"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 106
            };
        }
    }
}
