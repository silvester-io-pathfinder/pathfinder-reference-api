using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnimalAccomplice : Template
    {
        public static readonly Guid ID = Guid.Parse("4555bcc0-4948-4a97-8409-c74cfd6ed599");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animal Accomplice",
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
            yield return new TextBlock { Id = Guid.Parse("8058bd14-e7f3-4676-9661-056f743df271"), Type = TextBlockType.Text, Text = "You build a rapport with an animal, which becomes magically bonded to you. You gain a familiar using the rules on page 217. The type of animal is up to you, but most gnomes choose animals with a burrow Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5d9fca0-29d5-4e58-ada4-f7f1087b2552"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
