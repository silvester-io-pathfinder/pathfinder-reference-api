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
    public class HybridForm : Template
    {
        public static readonly Guid ID = Guid.Parse("c91161b0-68f9-4f66-8c4c-518dfb4fce04");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hybrid Form",
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
            yield return new TextBlock { Id = Guid.Parse("3f2fa96a-468d-4cfb-bf74-00840253e620"), Type = TextBlockType.Text, Text = $"When you {ToMarkdownLink<Models.Entities.Feat>("Change Shape", Feats.Instances.ChangeShapeKitsune.ID)}, you retain elements of your kitsune form, allowing you to speak in a fox form, use kitsune unarmed attacks in a tailless form, or gain a tail in your tailless form to use abilities that require one. You can {ToMarkdownLink<Models.Entities.Feat>("Change Shape", Feats.Instances.ChangeShapeKitsune.ID)} to alter the details of your hybrid form without fully changing into your true form or your alternate form. While in hybrid form, your foxlike features make it obvious that you aren't a normal humanoid." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d75b9747-576f-4a81-87cf-be38fac2aacb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
