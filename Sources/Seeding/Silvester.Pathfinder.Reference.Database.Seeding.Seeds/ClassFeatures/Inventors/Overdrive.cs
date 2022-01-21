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
    public class Overdrive : Template
    {
        public static readonly Guid ID = Guid.Parse("d69f016c-a6e9-4a77-969a-ebc2565b37c8");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Overdrive", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("05902aeb-9530-41db-8f2b-4f86efe9d1a6"), Type = TextBlockType.Text, Text = "You have a bevy of smaller devices of your own invention, from muscle stimulants to concussive pistons. When it's necessary, you can throw them into overdrive to assist you in combat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("e726065b-a98b-4c97-9c5b-39b2b697e909"), Feats.Instances.Overdrive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f0893b5-9247-481a-82d3-c1d9ef537059"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 16
            };
        }
    }
}
