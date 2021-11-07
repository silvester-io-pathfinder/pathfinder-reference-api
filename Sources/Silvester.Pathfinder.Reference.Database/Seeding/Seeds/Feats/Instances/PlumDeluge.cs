using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PlumDeluge : Template
    {
        public static readonly Guid ID = Guid.Parse("d336d38b-cd6e-4a97-8f95-b8602f8b203d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Plum Deluge",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aa81aa19-7d54-4590-8428-15dba0a25a64"), Type = TextBlockType.Text, Text = "You have learned to saturate an area with poison in imitation of the techniques of your rival, Blue Viper. As part of this ability, you (action: Interact) to draw three vials of the same contact poison and throw them in the air, where they shatter and spread a poisonous deluge affecting a 20-foot burst within 60 feet. All creatures in the burst are automatically exposed to the poison, immediately bypassing any onset time, and must attempt a saving throw against that poison. The three vials must be identical, even if the poison can come in multiple types or different levels." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26488c7c-81ad-40b9-98d0-da785b7843ff"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
