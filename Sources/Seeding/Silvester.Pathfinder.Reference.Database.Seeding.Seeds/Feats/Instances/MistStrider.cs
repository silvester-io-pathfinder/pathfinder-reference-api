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
    public class MistStrider : Template
    {
        public static readonly Guid ID = Guid.Parse("4e8b8c61-e3d9-4a7f-acf0-43fe16cce7f4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mist Strider",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("51f554d4-581a-4bf8-80b2-935bdab1cc50"), Type = TextBlockType.Text, Text = $"You condense the moisture in the air, solidifying it so it can hold your weight. When you use {ToMarkdownLink<Models.Entities.Feat>("Water Strider", Feats.Instances.WaterStrider.ID)}, you can walk on air. You can ascend and descend at a maximum of a 45-degree angle. You still fall at the end of your movement if you don't end on a surface that can support you, as normal for {ToMarkdownLink<Models.Entities.Feat>("Water Strider", Feats.Instances.WaterStrider.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1e027ffa-871f-4014-8eba-ebfed41b2549"), Feats.Instances.WaterStrider.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7cb7d37c-883e-4fee-8cc0-0819ff9ff454"), Traits.Instances.Azarketi.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8ec73fe7-a69c-40ee-99e6-fcbe12013614"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
