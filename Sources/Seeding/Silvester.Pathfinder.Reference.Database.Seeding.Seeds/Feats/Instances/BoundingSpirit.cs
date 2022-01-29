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
    public class BoundingSpirit : Template
    {
        public static readonly Guid ID = Guid.Parse("ba29060c-78f4-45f1-a92c-09cc1f3c1aac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bounding Spirit",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8c64ff84-47e2-44de-9072-0f78dcc0454d"), Type = TextBlockType.Text, Text = $"The weapon gains the {ToMarkdownLink<Models.Entities.Trait>("thrown 30 feet", Traits.Instances.Thrown.ID)} trait and has the {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("returning rune", Items.WeaponPropertyRunes.Instances.Returning.ID)} (even if it already has its maximum number of property runes)." };
            yield return new TextBlock { Id = Guid.Parse("d6aec9fb-cbce-4af1-a349-4d686eb7484c"), Type = TextBlockType.Text, Text = $"__Corruption Flaw__ When you make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a thrown or ranged weapon and miss, reroll the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, targeting your ally nearest to the tar" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96dda843-2be2-439b-be6c-68defa906885"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
