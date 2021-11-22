using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConjureBullet : Template
    {
        public static readonly Guid ID = Guid.Parse("08ae074b-0eeb-4930-bdde-528de857e68a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conjure Bullet",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1adf9b11-3698-4e95-b00d-6d6b1665849e"), Type = TextBlockType.Text, Text = "You conjure an ordinary level-0 bolt or bullet out of thin air and then immediately (action: Interact) to load it into your weapon. If the bolt or bullet isn't fired before the end of your turn, the effect is wasted." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("28865bea-727c-44cf-990d-bf7749da0af3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
