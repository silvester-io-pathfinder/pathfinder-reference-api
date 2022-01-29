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
    public class Idyllkin : Template
    {
        public static readonly Guid ID = Guid.Parse("f1783f9b-30b4-4033-aedf-159b05a9340e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Idyllkin",
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
            yield return new TextBlock { Id = Guid.Parse("5e5966ee-74ce-4a12-ba0c-b80c719f8e52"), Type = TextBlockType.Text, Text = $"Your wild, unique features betray your agathion birthright. Serene celestials from the plane of Nirvana, agathions seek the peaceful path, ensuring a better world for all to coexist. Your halcyon demeanor leads you to search for peaceful resolution to conflict. You gain the trained proficiency rank in Nature. If you would automatically become trained in Nature (from your background or class, for example), you instead become trained in a skill of your choice. You know the {ToMarkdownLink<Models.Entities.Language>("Sylvan", Languages.Instances.Sylvan.ID)} language and gain the {ToMarkdownLink<Models.Entities.Feat>("Natural Medicine", Feats.Instances.NaturalMedicine.ID)} skill feat." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Aasimar.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Lineage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20920730-b5a8-48ff-9ff8-5d7be7592633"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
