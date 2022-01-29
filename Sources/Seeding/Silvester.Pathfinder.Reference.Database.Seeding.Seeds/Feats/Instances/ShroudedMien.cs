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
    public class ShroudedMien : Template
    {
        public static readonly Guid ID = Guid.Parse("8b604d06-6147-421e-8e1c-3bdfadd17783");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shrouded Mien",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("20fff126-e44f-460f-914a-738eb6a534d2"), Type = TextBlockType.Text, Text = $"You're used to dealing with dangerous situations and sinister creatures. You become trained in Deception (or another skill of your choice, if you're already trained in Deception), and you gain the {ToMarkdownLink<Models.Entities.Feat>("Lengthy Diversion", Feats.Instances.LengthyDiversion.ID)} skill feat as a bonus feat." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fetchling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("932f0635-ce20-484b-aee4-12cc4c20a46f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
