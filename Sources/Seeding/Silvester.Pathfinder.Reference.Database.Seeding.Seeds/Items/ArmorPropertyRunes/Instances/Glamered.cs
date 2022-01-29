using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.ArmorPropertyRunes.Instances
{
    public class Glamered : Template
    {
        public static readonly Guid ID = Guid.Parse("0b5a1049-2565-40ac-8364-1a040cc62375");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Glamered",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("bfa5187b-92f9-4342-b5cd-9a3f4e0f6fd0"), "This armor can be disguised with a mere thought.");;
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = Guid.Parse("3a41d431-c28d-424e-9042-2ac9894ee3bb"),
                Name = "Glamered",
                Usage = "Etched onto armor.",
                Level = 5,
                Price = 14000,
                PotencyId = Potencies.Instances.Standard.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("4c68b2fb-5fc8-4a57-b564-e607bfc66910"), "This armor can be disguised with a mere thought.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8fa28249-b9cf-45b0-a5c9-fc721aa278df"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("706d1138-cd1b-440b-a4fe-c0fc756b254f"), "You change the shape and appearance of this armor to appear as ordinary or fine clothes of your imagining. The armor's statistics do not change. Only a creature that is benefiting from true seeing or a similar effect can attempt to disbelieve this illusion, with a DC of 25.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("edb2a22a-a9cd-43f9-adae-4ac6111a46e3"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("6d12d0f8-2419-4540-812e-e356c19f85b3"), Traits.Instances.Illusion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f506995-19fe-46d7-94ef-5ca38f03972c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }
    }
}
