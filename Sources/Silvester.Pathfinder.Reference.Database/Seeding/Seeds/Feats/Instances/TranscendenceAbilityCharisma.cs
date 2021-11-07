using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TranscendenceAbilityCharisma : Template
    {
        public static readonly Guid ID = Guid.Parse("c2d5d0be-8063-4aac-a8a3-a33e8d9573de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Transcendence Ability - Charisma",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0ba3590b-551e-4d30-9c41-1d75ca101b0d"), Type = TextBlockType.Text, Text = "Your eidolon&#39;s Charisma ability score increases by 2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68b988b4-ac24-4926-b996-7ecdec2bda59"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
