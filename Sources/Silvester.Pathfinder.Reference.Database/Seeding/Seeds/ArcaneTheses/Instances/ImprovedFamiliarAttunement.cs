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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You've long held that fine-tuning the magic that bonds wizard and familiar can improve the mystic connection, compared to the safe yet generic bond most wizards currently use. You've formed such a pact with your familiar, gaining more advantages from it than most wizards. You gain the Familiar wizard feat. Your familiar gains an extra ability, and it gains an additional extra ability when you reach 6th, 12th, and 18th levels. Your connection with your familiar alters your arcane bond class feature so that you store your magical energy in your familiar, rather than an item you own; you also gain the Drain Familiar free action instead of Drain Bonded Item. Drain Familiar can be used any time an ability would allow you to use Drain Bonded Item and functions identically, except that you draw magic from your familiar instead of an item." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.Familiar.ID);

            builder.GainAnyFamiliarAbility(Guid.Parse(""));

            builder.GainAnyFamiliarAbility(Guid.Parse(""))
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 6);
                });

            builder.GainAnyFamiliarAbility(Guid.Parse(""))
               .AddPrerequisites(Guid.Parse(""), prerequisites =>
               {
                   prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 12);
               });

            builder.GainAnyFamiliarAbility(Guid.Parse(""))
               .AddPrerequisites(Guid.Parse(""), prerequisites =>
               {
                   prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 18);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 205
            };
        }
    }
}
