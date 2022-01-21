using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArcaneTheses.Instances
{
    public class ImprovedFamiliarAttunement : Template
    {
        public static readonly Guid ID = Guid.Parse("bb8328da-0a5a-45cd-9d4a-e4ee1f4c8751");

        protected override ArcaneThesis GetArcaneThesis()
        {
            return new ArcaneThesis
            {
                Id = ID, 
                Name = "Improved Familiar Attunement", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1c3a812b-bd85-431c-8005-63fd95ab30c5"), Type = TextBlockType.Text, Text = "You've long held that fine-tuning the magic that bonds wizard and familiar can improve the mystic connection, compared to the safe yet generic bond most wizards currently use. You've formed such a pact with your familiar, gaining more advantages from it than most wizards. You gain the Familiar wizard feat. Your familiar gains an extra ability, and it gains an additional extra ability when you reach 6th, 12th, and 18th levels. Your connection with your familiar alters your arcane bond class feature so that you store your magical energy in your familiar, rather than an item you own; you also gain the Drain Familiar free action instead of Drain Bonded Item. Drain Familiar can be used any time an ability would allow you to use Drain Bonded Item and functions identically, except that you draw magic from your familiar instead of an item." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("1a3fb82f-1557-40e0-807d-cb28f5aa45ab"), Feats.Instances.Familiar.ID);

            builder.GainAnyFamiliarAbility(Guid.Parse("a4394278-6205-4f7b-82a0-7445ff99ed4f"));

            builder.GainAnyFamiliarAbility(Guid.Parse("afabc2dd-5671-427c-b5bd-5d86fd94c600"))
                .AddPrerequisites(Guid.Parse("14249d9c-82d8-4a02-bc71-8be18d72ca65"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("e636760b-e22e-4630-a6af-ff447b0cc363"), Comparator.GreaterThanOrEqualTo, requiredLevel: 6);
                });

            builder.GainAnyFamiliarAbility(Guid.Parse("9bca3b91-7a64-47ab-91e0-d9d803d2cb6b"))
               .AddPrerequisites(Guid.Parse("278b32bf-5297-4f18-8dc5-35ba0381e2a9"), prerequisites =>
               {
                   prerequisites.HaveSpecificLevel(Guid.Parse("58f574c8-62cf-48fa-b43a-66784b0da240"), Comparator.GreaterThanOrEqualTo, requiredLevel: 12);
               });

            builder.GainAnyFamiliarAbility(Guid.Parse("39f44474-b546-417e-a8ee-fedcd863bc31"))
               .AddPrerequisites(Guid.Parse("954bb4af-8f2b-4157-bde4-58c387124609"), prerequisites =>
               {
                   prerequisites.HaveSpecificLevel(Guid.Parse("27b1be56-31f0-40ff-968e-17b0fb0f19ac"), Comparator.GreaterThanOrEqualTo, requiredLevel: 18);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93093844-53c5-4f86-9f98-ad25db9b2bb0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 205
            };
        }
    }
}
