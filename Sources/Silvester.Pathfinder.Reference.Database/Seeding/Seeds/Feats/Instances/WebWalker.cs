using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WebWalker : Template
    {
        public static readonly Guid ID = Guid.Parse("736c406b-39b0-4176-9064-935c1c62f755");

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
            yield return new TextBlock { Id = Guid.Parse("791c7542-9c2f-4725-b20a-704f3daf097f"), Type = TextBlockType.Text, Text = "You have plenty of practice navigating webs. You gain a +2 circumstance bonus to saves and AC against the (spell: web) spell, natural webbing, and effects that entrap you in webbing, as well as a +1 circumstance bonus against other effects that snare and entangle you, like the (spell: entangle) spell. Whenever you roll a success on a saving throw against an effect involving a web, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c560e682-8dc5-41c3-97d4-d9c8be430041"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
