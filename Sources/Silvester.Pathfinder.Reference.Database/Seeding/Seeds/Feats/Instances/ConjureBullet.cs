using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConjureBullet : Template
    {
        public static readonly Guid ID = Guid.Parse("885bc0bd-5d86-4adb-9f56-4cdaee25c914");

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
            yield return new TextBlock { Id = Guid.Parse("54bcf134-7c94-4c70-84c6-25d36e4ed717"), Type = TextBlockType.Text, Text = "You conjure an ordinary level-0 bolt or bullet out of thin air and then immediately (action: Interact) to load it into your weapon. If the bolt or bullet isn’t fired before the end of your turn, the effect is wasted." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e4548fd-4c7d-4994-8a27-8c1ad612e323"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
