using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class SignatureSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("28370ce9-3fbe-48bc-a478-144f6153da47");

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
            yield return new TextBlock { Id = Guid.Parse("cf5b78e9-a28d-4e25-a4ee-3279d51a311e"), Type = TextBlockType.Text, Text = "you've learned to cast some of your spells more flexibly. For each spell level you have access to, choose one spell of that level to be a signature spell. You don't need to learn heightened versions of signature spells separately; instead, you can heighten these spells freely. If you've learned a signature spell at a higher level than its minimum, you can also cast all its lower-level versions without learning those separately. If you swap out a signature spell, you can choose a replacement signature spell of the same spell level at which you learned the previous spell. You can also retrain specifically to change a signature spell to a different spell of that level without swapping any spells; this takes as much time as retraining a spell normally does." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add signature spells effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c8618dd-39c0-4bd5-a5f7-6fea390c774e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 193
            };
        }
    }
}
