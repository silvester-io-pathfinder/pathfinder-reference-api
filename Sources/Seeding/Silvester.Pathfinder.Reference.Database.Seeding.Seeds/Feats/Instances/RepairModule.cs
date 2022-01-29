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
    public class RepairModule : Template
    {
        public static readonly Guid ID = Guid.Parse("8952c054-912d-492f-bb06-03a5a2dd3395");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Repair Module",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c467d11-6758-4a38-8fa2-b5e088e006b5"), Type = TextBlockType.Text, Text = $"You trigger your body's repair programming, causing your body's nanites to heal your wounds. You gain fast healing equal to half your level for 1 minute. While Repair Module is active, you can't use other abilities that require the use of your nanites." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bb1f45da-259a-4fdf-a4a8-228837998de0"), Traits.Instances.Android.ID);
            builder.Add(Guid.Parse("029cfeba-aa8a-456d-ac3e-d1d3e0078146"), Traits.Instances.Concentrate.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68f28ce0-6f93-4ca5-9a72-ba3ce3bc47e6"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
