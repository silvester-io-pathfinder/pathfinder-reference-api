using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CremateUndead : Template
    {
        public static readonly Guid ID = Guid.Parse("3097ba53-35c9-44c9-be34-aaa3d46a7756");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cremate Undead",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1b7c138f-14fc-45c7-853f-1c8cf55c3d2f"), Type = TextBlockType.Text, Text = "Your positive energy sets undead alight. When you use a (spell: heal) spell to damage undead, each undead that takes damage also takes persistent fire damage equal to the spell's level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6329ee71-f212-4455-a098-f866ddf54323"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
