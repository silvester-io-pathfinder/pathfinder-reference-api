using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WebWalker : Template
    {
        public static readonly Guid ID = Guid.Parse("76099222-67af-492f-99fb-bb28aa569013");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Web Walker",
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
            yield return new TextBlock { Id = Guid.Parse("77b49d1f-4774-40f4-a801-ac4e921608a4"), Type = TextBlockType.Text, Text = "You have plenty of practice navigating webs. You gain a +2 circumstance bonus to saves and AC against the (spell: web) spell, natural webbing, and effects that entrap you in webbing, as well as a +1 circumstance bonus against other effects that snare and entangle you, like the (spell: entangle) spell. Whenever you roll a success on a saving throw against an effect involving a web, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a09d6ff-2f68-494a-b216-341931bd0925"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
