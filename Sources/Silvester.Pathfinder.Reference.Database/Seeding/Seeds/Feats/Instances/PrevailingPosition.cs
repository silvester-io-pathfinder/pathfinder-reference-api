using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrevailingPosition : Template
    {
        public static readonly Guid ID = Guid.Parse("4bc44457-82cb-468f-a3d7-87417ac75040");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Prevailing Position",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are targeted by an attack or attempt a Reflex saving throw against a damaging effect, and you are in a stance.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8d5d51a-acf1-40c4-9e42-3c2bb77f6632"), Type = TextBlockType.Text, Text = "Your willingness to flow from one stance to another lets you sacrifice their benefits to better protect yourself. You leave the stance you were in, gaining a +4 circumstance bonus to the triggering saving throw or to your AC against the triggering attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("2d1727f8-a461-4806-b96c-cf6e45696263"), "At least one stance feat.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f4a3e6df-3ba6-4473-b919-3dce51b7e171"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
