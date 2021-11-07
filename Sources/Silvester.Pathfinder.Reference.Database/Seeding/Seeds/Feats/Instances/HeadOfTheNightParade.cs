using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeadOfTheNightParade : Template
    {
        public static readonly Guid ID = Guid.Parse("62ed8a80-3b18-4af4-8660-a4e1fd011a92");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Head of the Night parade",
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
            yield return new TextBlock { Id = Guid.Parse("ea97a0bc-3edb-4af4-adcd-0c0c19704d30"), Type = TextBlockType.Text, Text = "You remember the revelry of the Night Parade and call them to your aid in a riotous display. You (action: Perform) and cast 8th-level (spell: mad monkeys) three times, except that the spell calls various apparitions such as dancing tsukumogami or drinking oni rather than monkeys. Each casting can produce a different kind of mischief. You can Sustain all three Spells each round using a single (action: Perform) action." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e56987d-6748-4876-ae90-09a60be71002"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
