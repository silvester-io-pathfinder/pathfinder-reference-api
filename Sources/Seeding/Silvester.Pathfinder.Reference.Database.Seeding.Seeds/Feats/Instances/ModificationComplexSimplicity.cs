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
    public class ModificationComplexSimplicity : Template
    {
        public static readonly Guid ID = Guid.Parse("ba5d74fd-0dfa-47bf-b37a-3566ad65930d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Complex Simplicity",
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
            yield return new TextBlock { Id = Guid.Parse("9070d78c-583a-4f63-84bd-799f2a844d40"), Type = TextBlockType.Enumeration, Text = $"*Simple Weapon Only**" };
            yield return new TextBlock { Id = Guid.Parse("3d057c68-ef8e-42fa-b662-c867475dc76c"), Type = TextBlockType.Text, Text = $"Increase your innovation's weapon damage die by one step (d4 to d6, d6 to d8, d8 to d10, d10 to d12). In addition, it gains one of the following traits of your choice: {ToMarkdownLink<Models.Entities.Trait>("versatile B", Traits.Instances.Versatile.ID)}, {ToMarkdownLink<Models.Entities.Trait>("versatile P", Traits.Instances.Versatile.ID)}, or {ToMarkdownLink<Models.Entities.Trait>("versatile S", Traits.Instances.Versatile.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7d156b90-1ec4-43e1-85a7-3f23b49e44be"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
