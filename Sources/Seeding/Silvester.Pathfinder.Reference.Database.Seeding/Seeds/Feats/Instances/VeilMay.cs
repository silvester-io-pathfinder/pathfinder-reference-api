using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VeilMay : Template
    {
        public static readonly Guid ID = Guid.Parse("96d35603-65b4-4fe0-81a4-8b5716e677b1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Veil May",
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
            yield return new TextBlock { Id = Guid.Parse("5113d3fb-14df-4c40-82d7-65dfa01138ae"), Type = TextBlockType.Text, Text = "Born of a blood hag, a fiery blood drinker hidden behind a false skin, you have one blood-red eye and the ability to slough off your appearance in an instant. You gain the (feat: Lie to Me) skill feat, and you can shed a disguise quickly by peeling off the outer layer of your skin. Changing from a disguise used to (action: Impersonate) back to your true appearance is a 3-action activity for you; if you're an expert in Deception, it's a 2-action activity, and if you're legendary in Deception, it takes only a single action. This doesn't allow you to don or remove armor or other equipment any faster, but your physical appearance otherwise returns to its normal state." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82bb5803-6da4-4987-b919-c65f75a7937d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
