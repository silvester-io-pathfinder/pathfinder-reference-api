using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonArcana : Template
    {
        public static readonly Guid ID = Guid.Parse("ebca191d-7cdf-41c2-9e00-5b5cdd34f715");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon Arcana",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("533ad7c2-0f61-44f2-9fac-fbf1ef290c6b"), Type = TextBlockType.Text, Text = "You’ve discovered how to add the magic of dragons to your tradition. Add the draconic bloodline’s granted spells to your spell list; you must still learn them or add them to your repertoire as normal. These spells are (spell: shield), (spell: true strike), (spell: resist energy), (spell: haste), (spell: spell immunity), (spell: chromatic wall), (spell: dragon form), (spell: mask of terror), (spell: prismatic wall), and (spell: overwhelming presence)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
            builder.HaveSpecificFeat(Guid.Parse("110d4f4b-ae01-4535-8a4f-606821e68656"), Feats.Instances.DragonDiscipleDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e169b3c-da50-4371-a93f-0876cf23b9a3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
