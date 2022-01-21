using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class FieldDiscovery : Template
    {
        public static readonly Guid ID = Guid.Parse("6f417c62-f05a-43f7-9891-76cd2f5999f6");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Field Discovery", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("732e8173-c8db-4822-b3f5-82600a4f8967"), Type = TextBlockType.Text, Text = "You learn a special discovery depending on your research field." };
            yield return new TextBlock { Id = Guid.Parse("1050ecb4-2cf0-474e-b506-ca3a3b2f325a"), Type = TextBlockType.Enumeration, Text = "Bomber - When using advanced alchemy to make bombs during your daily preparations, you can use a batch of reagents to create any three bombs instead of just two of the same bomb." };
            yield return new TextBlock { Id = Guid.Parse("3f088fd3-8aa2-4126-97d4-37df2b1b7f37"), Type = TextBlockType.Enumeration, Text = "Chirurgeon - When using advanced alchemy to make elixirs of life during your daily preparations, you can create three elixirs with each batch of reagents instead of two." };
            yield return new TextBlock { Id = Guid.Parse("c2228a66-f91a-414d-bdf8-7bf15e704ac7"), Type = TextBlockType.Enumeration, Text = "Mutagenist - When using advanced alchemy to make mutagens during your daily preparations, you can use a batch of reagents to create any three mutagens instead of just two of the same mutagen." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af80679f-afca-4295-ae89-db31c1a22a20"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 74
            };
        }
    }
}
