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
    public class SuliJann : Template
    {
        public static readonly Guid ID = Guid.Parse("b4fa6ec6-f313-48fb-b313-32136bfe206b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Suli-Jann",
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
            yield return new TextBlock { Id = Guid.Parse("de0ea5c1-9f7e-4b4a-89cf-d290a9dd1055"), Type = TextBlockType.Text, Text = $"Your elemental ancestor was a janni, genies that walk the mortal world and embody all four elements together. You inherited a janni's nature as a wanderer and ability to survive in many types of environment, from the hottest desert to the coldest tundra. You gain the trained proficiency rank in Survival. If you would automatically become trained in Survival (from your background or class, for example), you instead become trained in a skill of your choice. You gain the {ToMarkdownLink<Models.Entities.Feat>("Forager", Feats.Instances.Forager.ID)} skill feat as a bonus feat." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("2ff15f69-1954-40ee-a0de-457533426414"), Traits.Instances.Lineage.ID);
            builder.Add(Guid.Parse("69bf0376-5562-4a88-b1a9-b7a74195d881"), Traits.Instances.Suli.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a497ae1-343a-4fb4-b995-d2255e26f7c3"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
