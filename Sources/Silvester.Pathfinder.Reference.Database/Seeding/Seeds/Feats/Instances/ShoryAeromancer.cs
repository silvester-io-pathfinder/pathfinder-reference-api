using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShoryAeromancer : Template
    {
        public static readonly Guid ID = Guid.Parse("fb201e31-9216-4d66-8002-465ddc44d091");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shory Aeromancer",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c90293f-2bbc-444e-b30c-1a85f52820d6"), Type = TextBlockType.Text, Text = "~ Access: Garundi, Mauxi, or Tian-Yae ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("f92224e7-8876-4e94-9da0-0433c6f6f155"), Type = TextBlockType.Text, Text = "Your ancestors hailed from the flying cities of the Shory, and a few simple tricks have come down through the ages to you. You can cast 4th-level (spell: fly) on yourself as an innate arcane spell once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65024d14-4070-4072-b914-187f4910af9e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
