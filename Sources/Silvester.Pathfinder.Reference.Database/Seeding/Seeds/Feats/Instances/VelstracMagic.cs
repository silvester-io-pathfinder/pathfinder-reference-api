using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VelstracMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("4d28cb95-354a-4341-9eba-b0df5061a9fb");

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
            yield return new TextBlock { Id = Guid.Parse("d8553610-0ca0-471f-a2ed-71266cde8ee6"), Type = TextBlockType.Text, Text = "You know there’s so much more to sensation than whips and chains—but whips and chains also have their place. You can cast (spell: telekinetic maneuver) and (spell: web) once per day each as 2nd-level divine innate spells; in both cases, the spells manifest shadowy chains rather than their usual visual signifiers." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("91452f69-a616-44a4-84a4-dc7b765b01d0"), Feats.Instances.Shackleborn.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c1a58ef-6f0c-47ac-80c5-071dd0a0a5c9"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
