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
    public class PoulticePreparation : Template
    {
        public static readonly Guid ID = Guid.Parse("7ce8568f-8b2c-4b75-b2a1-09f044b9822a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Poultice Preparation",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6cc4f6da-77af-4375-b14c-fbf90f2deb88"), Type = TextBlockType.Text, Text = $"When you create an herbal elixir, you can prepare it as a poultice instead. A poultice gains the {ToMarkdownLink<Models.Entities.Trait>("oil", Traits.Instances.Oil.ID)} trait (but remains {ToMarkdownLink<Models.Entities.Trait>("alchemical", Traits.Instances.Alchemical.ID)}, not {ToMarkdownLink<Models.Entities.Trait>("magical", Traits.Instances.Magical.ID)}) and loses the {ToMarkdownLink<Models.Entities.Trait>("elixir", Traits.Instances.Elixir.ID)} and {ToMarkdownLink<Models.Entities.Trait>("ingested", Traits.Instances.Ingested.ID)} traits. You can apply a poultice by {ToMarkdownLink<Models.Entities.Action>("Interacting", Actions.Instances.Interact.ID)} with one hand. When you apply a poultice, in addition to the item's normal effects, the recipient can attempt an immediate flat check to recover from a single source of persistent acid, bleed, or fire damage, with the DC reduction from appropriate assistance." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4f163571-472e-45fe-a995-20d95f330029"), Feats.Instances.HerbalistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39340da2-c3a4-448c-80fb-842922c13888"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
