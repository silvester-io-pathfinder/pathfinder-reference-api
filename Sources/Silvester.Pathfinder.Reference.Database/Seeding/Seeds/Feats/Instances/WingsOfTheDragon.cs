using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WingsOfTheDragon : Template
    {
        public static readonly Guid ID = Guid.Parse("6bfe8b3f-9f32-416a-8e29-ff66d7ae8856");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wings of the Dragon",
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
            yield return new TextBlock { Id = Guid.Parse("29840eca-9193-4660-a0bd-7ec507e62afa"), Type = TextBlockType.Text, Text = "You can manifest draconic wings to soar through the air at great speed. You gain the (spell: dragon wings) sorcerer bloodline spell and a focus pool of 1 Focus Point. If you already have a focus pool, increase your number of Focus Points by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1c4a6a87-1192-432a-923e-0f5d08e577f7"), Feats.Instances.DragonDiscipleDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ed68c1c-016e-40f9-a4cb-5d5673b011f5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
