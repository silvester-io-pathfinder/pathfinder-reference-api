using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class LeafLeshy : Template
    {
        public static readonly Guid ID = Guid.Parse("cc800312-5021-43fc-8d8d-1cfa7176d2af");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Leaf Leshy"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("81a24653-c2cf-4dfb-b302-53a4d2dcb304"), Type = TextBlockType.Text, Text = "Your body is made mostly from natural foliage, and like a leaf tumbling from a tree, you land from falls with particular grace. You take no damage from falling, regardless of the distance you fall." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyFallDistance(Guid.Parse("89ec7c86-073e-495c-88f4-faf2bf9f825a"), ModifierType.Multiply, modifier: 0);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b6d6f868-a2fa-4566-b41c-e7560aa80c17"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 53
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Leshy.ID;
        }
    }
}
