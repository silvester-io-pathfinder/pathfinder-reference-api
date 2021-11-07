using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HairTrigger : Template
    {
        public static readonly Guid ID = Guid.Parse("79478a32-d3bb-4e77-bf38-00b1140308fa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hair Trigger",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your initial deed allows you to Interact to draw a weapon more than once, this feat allows you to replace one of these Interact actions and use the other one to draw a weapon. You can't replace both Interact actions with Strikes, but you can draw a loaded firearm or crossbow with one of the actions and immediately shoot it with the other.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("65f01f12-e42c-4d3f-b8f6-f50c0059358a"), Type = TextBlockType.Text, Text = "No one can react faster than you can pull your trigger. When using your initial deed, instead of (action: Interacting|Interact) to draw a weapon, you can (action: Strike) with a firearm or crossbow you’re already wielding. If this (action: Strike) hits, the target is also flat-footed until the end of your first turn of the encounter." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("5ba652e9-d376-453a-8e69-667fe06a6817"), "Initial deed that allows you to Interact to draw a weapon.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e63136fb-5fd6-4892-be5d-27700b36df41"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
