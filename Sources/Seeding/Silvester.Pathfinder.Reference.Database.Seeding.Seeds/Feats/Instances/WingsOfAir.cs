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
    public class WingsOfAir : Template
    {
        public static readonly Guid ID = Guid.Parse("001d4316-66ef-4bcf-9de6-1cad42d6d6d2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wings of Air",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("68ad4a92-317b-49f9-a129-02616e2e25bf"), Type = TextBlockType.Text, Text = $"You can strain to call forth feathered or cloudy wings from your back. Once manifested, these wings remain for 10 minutes. You gain a fly Speed equal to your land Speed while you've manifested your wings." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("470fb4a0-5523-400d-9168-ef2f7d24ade6"), Traits.Instances.Morph.ID);
            builder.Add(Guid.Parse("a976272b-0574-4161-94c5-c1445ad6bc7f"), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse("8164d814-5c6f-4fd2-80b9-2a922d1d4c58"), Traits.Instances.Sylph.ID);
            builder.Add(Guid.Parse("39d140c4-3a0b-42e3-8cdb-d580bbcb5775"), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d257f5b5-fe75-4119-a778-c48d7cb98e24"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
