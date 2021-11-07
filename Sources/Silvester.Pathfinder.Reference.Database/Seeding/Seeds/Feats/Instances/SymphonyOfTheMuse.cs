using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SymphonyOfTheMuse : Template
    {
        public static readonly Guid ID = Guid.Parse("b38d912b-d148-4600-842b-3f3321c45709");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Symphony of the Muse",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("368d8704-5f8b-4a06-8b3b-eb1f0addf624"), Type = TextBlockType.Text, Text = "You are able to weave countless performances together into a solo symphony. You are no longer limited to a single composition each turn or a single composition at a time; when you use a new composition, all previous compositions’ effects continue for their remaining duration." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2c94a85e-58b4-400c-82b0-0b2eaab904cd"), Feats.Instances.Harmonize.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d3671d6-6fb1-481c-bb62-35881af5ff8a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
