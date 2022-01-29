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
    public class ParryAndRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("b5e5d27e-a524-4695-aa62-10a23fddf8cf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Parry and Riposte",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c026699b-3188-48a9-af51-57924dc32395"), Type = TextBlockType.Text, Text = $"Your parries and finishers allow you to riposte with the slightest provocation. You can use {ToMarkdownLink<Models.Entities.Feat>("Opportune Riposte", Feats.Instances.OpportuneRiposte.ID)} against an enemy who fails at a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against you (not just critically fails), provided you have both damaged that creature with a {ToMarkdownLink<Models.Entities.Trait>("finisher", Traits.Instances.Finisher.ID)} on your last turn and currently have a circumstance bonus to AC from the {ToMarkdownLink<Models.Entities.Trait>("parry", Traits.Instances.Parry.ID)} weapon trait, {ToMarkdownLink<Models.Entities.Feat>("Dueling Parry", Feats.Instances.DuelingParry.ID)}, or {ToMarkdownLink<Models.Entities.Feat>("Twin Parry", Feats.Instances.TwinParry.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("19ae0505-2143-4bc2-851a-33414933860a"), Feats.Instances.OpportuneRiposte.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("294f8b68-1e0d-4721-a160-cba26bc1ad2e"), Traits.Instances.Swashbuckler.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a9b65a6-2718-4064-b92a-b6ab938098a7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
