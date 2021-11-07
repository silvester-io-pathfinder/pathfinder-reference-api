using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoneRider : Template
    {
        public static readonly Guid ID = Guid.Parse("9db06ef8-14d6-4835-aaf4-05b8abbbc35a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bone Rider",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("63c66c74-a95e-4c2c-ac7e-e5d52a4f2780"), Type = TextBlockType.Text, Text = "Using your ancestors’ bones, you manifest their spirits around you in a fossilized form, terrifying your foes. You can cast (spell: mask of terror) on yourself as a primal innate spell once per day. When you do, you appear as a skeletal lizardfolk ancestor, twisted in a way that inspires the deepest fears of those who observe you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27141d06-0a64-4038-95b7-127935df4794"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
