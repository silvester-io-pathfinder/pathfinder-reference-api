using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UncannySuction : Template
    {
        public static readonly Guid ID = Guid.Parse("6464b2a0-72d4-4d1b-9c33-71ed41722724");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Uncanny Suction",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c5901c65-4ad6-4ac2-bfbb-37473aa99bfe"), Type = TextBlockType.Text, Text = $"Your limbs produce strange, sucker-like growths that allow you to adhere to walls, objects, and most other surfaces. You gain a climb Speed equal to your half your land Speed (minimum 5 feet). If you have the {ToMarkdownLink<Models.Entities.Feat>("Quick Climb", Feats.Instances.QuickClimb.ID)} feat, your climb Speed is equal to your land Speed. In addition, you gain a +2 circumstance bonus to your Reflex DC to avoid being {ToMarkdownLink<Models.Entities.SkillAction>("Disarmed", SkillActions.Instances.Disarm.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7a45d8ae-2e86-4978-a354-f6c914c40f6a"), Feats.Instances.OozemorphDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57ab0436-479b-4491-ae1d-c3e91efee7fb"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
