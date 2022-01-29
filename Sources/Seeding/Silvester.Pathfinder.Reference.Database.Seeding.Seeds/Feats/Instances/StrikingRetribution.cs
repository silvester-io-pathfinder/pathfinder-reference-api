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
    public class StrikingRetribution : Template
    {
        public static readonly Guid ID = Guid.Parse("4d0474b1-4dc6-4c9f-892a-9db7faa1936f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Striking Retribution",
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
            yield return new TextBlock { Id = Guid.Parse("eeb6b3ea-2108-4c47-ab66-3646b90932a0"), Type = TextBlockType.Text, Text = $"You have an appropriately intense hatred for alghollthus. You gain a +2 circumstance bonus to damage with weapons and unarmed attacks against creatures from the alghollthu family and those that serve alghollthus (the GM determines which creatures serve an alghollthu). In addition, if an alghollthu successfully affects you or one of your allies within 60 feet with an enchantment, your circumstance bonus to damage against that alghollthu increases to +4 for 1 minute." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Azarketi.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1088827-dedd-487b-8e78-fdb4c2b73054"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
