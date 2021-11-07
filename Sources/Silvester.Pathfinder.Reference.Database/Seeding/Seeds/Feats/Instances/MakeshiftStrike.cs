using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MakeshiftStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("20b20804-b87f-40d0-a2b3-7abfbd56755d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Makeshift Strike",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f86a0c51-7e13-4845-85d0-d7a55940dd8b"), Type = TextBlockType.Text, Text = "You quickly snatch up whatever’s nearby and then attack with it as an improvised weapon. You (action: Interact) to pick up a nearby object you could use as an improvised weapon. It must be located at around your chest level, such as a mug on a table, rather than an object on the floor. You then either (action: Strike) or make an (feat: Improvised Pummel) with the improvised weapon." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b85c8df5-0b49-4d06-8cb8-171d4fa161ec"), Feats.Instances.WeaponImproviserDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b49cb4c6-45e6-4dea-8320-92da0808620d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
