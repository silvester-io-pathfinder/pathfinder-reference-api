using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorPropertyRunes.Instances
{
    public class GlameredRune : Template
    {
        public static readonly Guid ID = Guid.Parse("0b5a1049-2565-40ac-8364-1a040cc62375");

        protected override ArmorPropertyRune GetRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Glamered",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bfa5187b-92f9-4342-b5cd-9a3f4e0f6fd0"), Type = TextBlockType.Text, Text = "This armor can be disguised with a mere thought." };
        }

        protected override IEnumerable<ArmorPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("3a41d431-c28d-424e-9042-2ac9894ee3bb"),
                Benefits = "This armor can be disguised with a mere thought.",
                ItemLevel = 5,
                Price = 14000,
                PotencyId = Potencies.Instances.Unclassified.ID,
            };
        }

        protected override ArmorPropertyRuneAction? GetAction()
        {
            return new ArmorPropertyRuneAction
            {
                Id = Guid.Parse("8fa28249-b9cf-45b0-a5c9-fc721aa278df"),
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Name = "Envision",
                Effect = "You change the shape and appearance of this armor to appear as ordinary or fine clothes of your imagining. The armor's statistics do not change. Only a creature that is benefiting from true seeing or a similar effect can attempt to disbelieve this illusion, with a DC of 25.",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Illusion.ID;
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
