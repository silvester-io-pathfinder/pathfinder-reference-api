using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteadyOnStone : Template
    {
        public static readonly Guid ID = Guid.Parse("ff13f3a7-5567-46f9-b403-650e1bcda1ec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steady on Stone",
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
            yield return new TextBlock { Id = Guid.Parse("cdbaf6cd-d0c4-46c8-bb6e-ca06ff3f910e"), Type = TextBlockType.Text, Text = "Your connection to the earth makes natural uneven surfaces less of a hindrance for you. You can ignore difficult terrain caused by rubble and uneven ground made of stone and earth. In addition, when you use the Acrobatics skill to (action: Balance) on narrow surfaces or uneven ground made of stone and earth, you aren’t flat-footed, and when you roll a success at one of these Acrobatics checks, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fff9a8f7-86b2-418f-998d-8dbdf7c14a3d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
