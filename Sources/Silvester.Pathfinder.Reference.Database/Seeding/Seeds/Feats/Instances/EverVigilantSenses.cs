using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EverVigilantSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("517efbe8-60b7-4b0c-825e-a8bde5d7f881");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ever-Vigilant Senses",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e3bc7ebf-ce7f-4303-a43d-3fea81f508c0"), Type = TextBlockType.Text, Text = "Your eidolon has enhanced senses. It gains a +2 circumstance bonus to Perception, and can’t be flanked except by creatures that are higher level than it. It can see invisible creatures and objects; they appear translucent and are concealed. When your eidolon moves within 30 feet of an illusion that can be disbelieved, the GM rolls a secret check to disbelieve it, even if your eidolon didn’t spend an action to (action: Interact)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e43cacd0-56e5-445d-bd0b-57d90a5701ca"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
