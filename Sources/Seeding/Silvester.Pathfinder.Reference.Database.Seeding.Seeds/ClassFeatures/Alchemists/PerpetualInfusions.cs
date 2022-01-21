using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class PerpetualInfusions : Template
    {
        public static readonly Guid ID = Guid.Parse("c033c4ec-6c3b-4a20-9c40-ffcb7bb79681");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Perpetual Infusions", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("40563776-5503-4204-a0bb-a73ee460ac9c"), Type = TextBlockType.Text, Text = "You have learned how to create perpetual alchemical infusions that can provide a near-infinite supply of certain simple items. You gain the ability to create two 1st-level alchemical items using Quick Alchemy without spending a batch of infused reagents. The items you can select depend on your research field and must be in your formula book." };
            yield return new TextBlock { Id = Guid.Parse("8b492f66-7f62-4b25-a94f-21c7a3283ec9"), Type = TextBlockType.Enumeration, Text = "Bomber - Choose two of the following formulas: lesser acid flask, lesser alchemist�s fire, lesser bottled lightning, lesser frost vial, lesser tanglefoot bag, lesser thunderstone." };
            yield return new TextBlock { Id = Guid.Parse("283aa85e-8b76-4ec2-9dd1-6814eeee95ea"), Type = TextBlockType.Enumeration, Text = "Chirurgeon - Lesser antidote and lesser antiplague." };
            yield return new TextBlock { Id = Guid.Parse("5be347ec-dc87-4999-922c-97773a99342e"), Type = TextBlockType.Enumeration, Text = "Mutagenist - Choose two of the following formulas: lesser bestial mutagen, lesser cognitive mutagen, lesser juggernaut mutagen, lesser quicksilver mutagen, lesser serene mutagen, lesser silvertongue mutagen." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("046c9cad-a45e-4b4d-a8ef-b701c3a5b6bb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 75
            };
        }
    }
}
