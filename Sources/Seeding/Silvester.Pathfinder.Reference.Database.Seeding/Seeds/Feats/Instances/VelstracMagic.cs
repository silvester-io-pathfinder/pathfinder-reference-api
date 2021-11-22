using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VelstracMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("6d812d46-7519-4d91-9e41-45c081a609de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Velstrac Magic",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("398b5d5d-c902-4e50-b79b-f576c02ceca0"), Type = TextBlockType.Text, Text = "You know there's so much more to sensation than whips and chains—but whips and chains also have their place. You can cast (spell: telekinetic maneuver) and (spell: web) once per day each as 2nd-level divine innate spells; in both cases, the spells manifest shadowy chains rather than their usual visual signifiers." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1f25e8b1-9f39-45aa-bc06-149daa4c40c4"), Feats.Instances.Shackleborn.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e2013ae3-b6ca-4589-8189-ebebbb8ddf32"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
