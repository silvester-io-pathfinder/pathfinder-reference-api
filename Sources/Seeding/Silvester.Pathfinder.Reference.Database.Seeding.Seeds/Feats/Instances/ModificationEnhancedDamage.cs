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
    public class ModificationEnhancedDamage : Template
    {
        public static readonly Guid ID = Guid.Parse("fc7cb7b9-3f2d-448b-805e-ab408db873af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Enhanced Damage",
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
            yield return new TextBlock { Id = Guid.Parse("ad519204-2978-40f1-acf3-8f09123348b7"), Type = TextBlockType.Text, Text = $"You've made your innovation more powerful than other weapons of its kind. Increase your innovation's weapon damage die by one step (d4 to d6, d6 to d8, d8 to d10, d10 to d12). As normal, you can't increase your die by more than one size, so this modification isn't cumulative with {ToMarkdownLink<Models.Entities.Feat>("complex simplicity", Feats.Instances.ModificationComplexSimplicity.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83a023b2-56b5-439f-8e5a-adac9823bc4c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
