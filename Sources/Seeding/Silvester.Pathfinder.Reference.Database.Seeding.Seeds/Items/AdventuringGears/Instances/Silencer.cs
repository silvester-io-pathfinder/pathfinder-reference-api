using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Silencer : Template
    {
        public static readonly Guid ID = Guid.Parse("32db96d6-7f45-4669-897f-891d54a48ea2");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Silencer",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("147016e5-3b83-4683-aba5-e17064f128a8"), "One of the more prolifically used devices developed in the infamous Alkenstar Gunworks, these small firearm components are capable of muffling most of the weapons' explosive sound when fired. Without a silencer, a firearm's shot makes a loud and distinctive bang, which can easily be heard through doors and thin walls, but firearms equipped with silencers only make a quiet noise when fired. Due to engineering constraints, a silencer can't be attached to any firearm with the scatter trait. Attaching a silencer to a firearm takes 1 minute, and the silencer is consumed the first time a shot is fired through it.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("be36c6e6-5059-4c63-8222-e7f0b8c42907"),
                Name = "Silencer",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 0,
                Price = 10,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a1e9eb8-6a6e-479b-9d48-7d7ac04167c1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 179
            };
        }
    }
}
