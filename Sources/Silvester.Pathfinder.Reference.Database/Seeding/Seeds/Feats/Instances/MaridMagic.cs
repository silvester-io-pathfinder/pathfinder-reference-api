using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MaridMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("22a6ade7-9c7e-4060-844f-803203844fa1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Marid Magic",
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
            yield return new TextBlock { Id = Guid.Parse("feb57d2e-0b84-466f-97b6-19765e5ccd70"), Type = TextBlockType.Text, Text = "You channel the magic of marids. You can cast (spell: hydraulic push) and (spell: obscuring mist) each once per day as 2nd-level arcane innate spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac1bcfda-2695-4b77-9ebb-227d53902a00"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
