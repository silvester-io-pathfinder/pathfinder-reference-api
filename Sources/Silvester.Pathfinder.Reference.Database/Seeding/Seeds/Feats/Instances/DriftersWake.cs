using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DriftersWake : Template
    {
        public static readonly Guid ID = Guid.Parse("8bca33a2-1b71-4567-9f98-9a429843569d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drifter's Wake",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ef892f42-9c5d-4fcc-8fb0-b9124a575c96"), Type = TextBlockType.Text, Text = "You drift across the battlefield, striking down foes as you go. You (action: Stride), and you can (action: Strike) up to three times at any points during your movement. Each attack must target a different enemy and must be made with a one-handed firearm, crossbow, melee weapon, or unarmed attack. Each attack counts toward your multiple attack penalty, but your multiple attack penalty doesn’t increase until you’ve made all your attacks. Your movement doesn’t trigger reactions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("184565a2-9504-476f-8214-b5e238485212"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
