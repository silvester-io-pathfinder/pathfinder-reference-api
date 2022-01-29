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
    public class InspiredStratagem : Template
    {
        public static readonly Guid ID = Guid.Parse("2da879f0-432a-4ce3-b625-1c957b3696b5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inspired Stratagem",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "One of the required allies is about to attempt an attack roll or skill check.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("14666e99-d27a-4302-af7e-290b15f0e960"), Type = TextBlockType.Text, Text = $"You quickly advise your ally, using your earlier planning to make sure luck can't throw a wrench in the cogs of your schemes. The ally rolls the triggering check twice and takes the better of the two results. That ally then becomes temporarily immune to your Inspired Stratagem until your next daily preparations." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fc343120-784b-4f6a-835c-f4e4852338ce"), Traits.Instances.Fortune.ID);
            builder.Add(Guid.Parse("d5776274-0e23-4f29-9139-53dd4919ecad"), Traits.Instances.Linguistic.ID);
            builder.Add(Guid.Parse("933805c3-dd83-4555-9d32-f8652bd7fa92"), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84a3a73d-0663-45e5-8dec-f56085b73dcb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
