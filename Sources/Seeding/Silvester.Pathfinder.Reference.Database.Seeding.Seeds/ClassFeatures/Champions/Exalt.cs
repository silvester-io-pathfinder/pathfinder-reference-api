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
    public class Exalt : Template
    {
        public static readonly Guid ID = Guid.Parse("76adcde1-399a-4251-b31d-d9c583a1a930");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Exalt", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fcb5dbb1-f8d4-4d8c-9882-b3a20b9384a8"), Type = TextBlockType.Text, Text = "Your champion's reaction exalts nearby allies, allowing them to benefit as well." };
            yield return new TextBlock { Id = Guid.Parse("89dabcb7-5e3a-4b03-ae3e-395aeb3a0e79"), Type = TextBlockType.Enumeration, Text = "Paladin - When you use Retributive Strike, each ally within 15 feet of you with the target in their melee reach can spend a reaction to Strike the target with a -5 penalty." };
            yield return new TextBlock { Id = Guid.Parse("d2dd1ba7-3d17-4237-a382-af63dbd5fedd"), Type = TextBlockType.Enumeration, Text = "Redeemer - You protect multiple allies. You can apply the resistance granted by Glimpse of Redemption to yourself and all allies within 15 feet of you, including the triggering ally, except the resistance is reduced by 2 for all." };
            yield return new TextBlock { Id = Guid.Parse("2677f57a-6905-4981-b85d-ccd35d94470a"), Type = TextBlockType.Enumeration, Text = "Liberator - You can help your whole group get into position. When you use Liberating Step, if your ally doesn't attempt to break free of an effect, you and all allies within 15 feet can Step, in addition to the triggering ally." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("441ce52e-0fca-4348-a8c0-b15ee75cc88a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 109
            };
        }
    }
}
