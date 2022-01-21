using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class PeerlessInventor : Template
    {
        public static readonly Guid ID = Guid.Parse("15a91252-f0ec-49a1-aca0-166d0b8b0afa");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Peerless Inventor", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a807bd2c-46fd-4044-9a0f-a262625c080f"), Type = TextBlockType.Text, Text = "You are constantly inventing, and your skill at crafting is unimpeachable. You gain the Inventor skill feat, even if you don't meet its prerequisites." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.DisableFeatPrerequisites(Guid.Parse("b5b804b8-748f-48f1-9821-5baad6c087ee"), Feats.Instances.Inventor.ID);
            builder.GainSpecificFeat(Guid.Parse("ab1d10fa-acf7-4c66-8dc8-a15e7e23b999"), Feats.Instances.Inventor.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("989a717e-606c-492e-9fc7-3992066f4e9e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 20
            };
        }
    }
}
