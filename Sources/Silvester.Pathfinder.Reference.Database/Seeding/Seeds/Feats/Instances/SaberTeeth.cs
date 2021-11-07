using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SaberTeeth : Template
    {
        public static readonly Guid ID = Guid.Parse("bb75defc-6dde-4bc4-80f9-e8aa67b92bf1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Saber Teeth",
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
            yield return new TextBlock { Id = Guid.Parse("ea3ce738-810d-4d85-8cd4-986a390c6936"), Type = TextBlockType.Text, Text = "You have long fangs, natural or augmented. You gain a jaws unarmed attack that deals 1d6 piercing damage. Your jaws are in the brawling group and have the (trait: unarmed) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ee1263e-0268-41cf-b613-9559ae5dc3d9"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
