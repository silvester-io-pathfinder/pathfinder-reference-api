using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class SignatureSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("ca3a1255-2035-4c5e-9bdd-566001ee68f4");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Signature Spells", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("213ad6cd-bf30-43c6-ba98-28e8986d0673"), Type = TextBlockType.Text, Text = "Experience enables you to cast some spells more flexibly. For each spell level you have access to, choose one spell of that level to be a signature spell. You don't need to learn heightened versions of signature spells separately; instead, you can heighten these spells freely. If you've learned a signature spell at a higher level than its minimum, you can also cast all its lower-level versions without learning those separately. If you swap out a signature spell, you can replace it with any spell you could have chosen when you first selected it (i.e., of the same spell level or lower). You can also retrain specifically to change a signature spell to a different spell of that level without swapping any spells; this takes as much time as retraining a spell normally does." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add signature spells effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e94a7d7-d82a-4946-8e30-d64424e291fe"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 71
            };
        }
    }
}
