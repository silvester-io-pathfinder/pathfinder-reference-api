using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OrcWarmaskMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("5e3aaeea-b7d3-48a1-bbda-6e14c5e949d1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Orc Warmask - Magic",
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
            yield return new TextBlock { Id = Guid.Parse("76048425-3233-4baa-bfd8-f0a7481a31c0"), Type = TextBlockType.Text, Text = "The source of your (item: warmask | warmask magic)’s power is from magical energy. You become trained in Arcana and your mask&#39;s magical tradition is (trait: arcane)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4da0e8fc-b12b-4710-b8c4-77c903fb8c57"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
