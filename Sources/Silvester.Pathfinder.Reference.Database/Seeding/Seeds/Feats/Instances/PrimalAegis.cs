using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrimalAegis : Template
    {
        public static readonly Guid ID = Guid.Parse("dddbd679-29e6-4c92-b2e8-22c47e1ea05c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Primal Aegis",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("911d419e-2612-439e-8cd7-7fa3d75012ee"), Type = TextBlockType.Text, Text = "You surround yourself with a thick field of protective primal energy. You and allies within 30 feet of you gain resistance equal to your Wisdom modifier to acid, cold, electricity, fire, negative, and positive damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79630759-5889-4afd-91f2-70482b047a51"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
