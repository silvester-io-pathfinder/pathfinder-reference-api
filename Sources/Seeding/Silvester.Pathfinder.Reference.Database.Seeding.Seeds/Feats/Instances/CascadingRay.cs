using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CascadingRay : Template
    {
        public static readonly Guid ID = Guid.Parse("76fcd2d7-dfec-47e6-9062-7cdaae2f39cf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cascading Ray",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8e5d6a25-c454-448e-9931-c9b995b8dead"), Type = TextBlockType.Text, Text = $"Magical energy spills out to extend beyond the creature you struck. The flowing energy forms a ray with a range of 60 feet from the creature you damaged. You can't target any of the creatures you damaged with your {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)} with the ray. Make a spell attack roll against the new target's AC, at the same multiple attack penalty as the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. On a hit, the target of the ray takes 1d4 damage per spell level of the same type of energy damage the spell deals (double damage on a critical hit). If you cast the spell in your {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)} from a spell slot, the damage from Cascading Ray increases to 1d8 damage per spell level." };
            yield return new TextBlock { Id = Guid.Parse("20b1f877-af8a-4754-9849-471c384a9e8c"), Type = TextBlockType.Text, Text = $"If the spell deals more than one type of energy damage, you choose only one for the ray. This ray has the {ToMarkdownLink<Models.Entities.Trait>("attack", Traits.Instances.Attack.ID)} trait, the school and tradition traits of the original spell, and the trait matching the damage type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5405aca5-54d8-4882-84ae-eeb98123a773"), Feats.Instances.Spellstrike.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Magus.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1110270-ae00-4507-8e28-df04c8c91d73"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
