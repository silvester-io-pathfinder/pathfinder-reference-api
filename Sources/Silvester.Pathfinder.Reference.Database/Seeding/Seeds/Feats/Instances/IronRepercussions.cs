using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IronRepercussions : Template
    {
        public static readonly Guid ID = Guid.Parse("618e382a-3763-40f4-b22b-f7c0cff054fc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Iron Repercussions",
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
            yield return new TextBlock { Id = Guid.Parse("c1bf9a90-c0ff-4761-a939-6cdfae846071"), Type = TextBlockType.Text, Text = "Disobeying your (feat: Iron Command) has lasting consequences." };
            yield return new TextBlock { Id = Guid.Parse("7e81d9a3-2fe3-44e4-9883-c0a36bc6a405"), Type = TextBlockType.Text, Text = "If an enemy refuses to kneel to you, you can deal persistent mental damage instead of normal mental damage. You must decide whether the mental damage will be persistent before your enemy chooses whether to kneel or not. The amount of damage is unchanged." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("384b57ff-3b00-4af0-add2-f639d31958d0"), Causes.Instances.Tyrant.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbefd589-7271-4f33-b52f-c4ecc738710b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
