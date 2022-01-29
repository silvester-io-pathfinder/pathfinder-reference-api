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
    public class MyriadForms : Template
    {
        public static readonly Guid ID = Guid.Parse("d81ceced-e791-492d-9c86-a7e90b24b023");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Myriad Forms",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3cc936ed-e8fd-4b87-a6f0-bacfcadbb63b"), Type = TextBlockType.Text, Text = $"With a bit of self-discovery, you find a new form. You gain the alternate form of a kitsune heritage other than your own, adding it to the options for your {ToMarkdownLink<Models.Entities.Feat>("Change Shape", Feats.Instances.ChangeShapeKitsune.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("adb8dae9-e76d-4dcf-afa2-aa2a3c1750dc"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
