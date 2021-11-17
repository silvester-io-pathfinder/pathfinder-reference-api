using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CautiousCuriosity : Template
    {
        public static readonly Guid ID = Guid.Parse("44297999-daf2-4c7b-9be7-bd79adbba3c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cautious Curiosity",
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
            yield return new TextBlock { Id = Guid.Parse("64dc4e62-b333-47bf-ac62-17f3a2fda41e"), Type = TextBlockType.Text, Text = "You’ve learned a few magical techniques for getting yourself both into and out of trouble unnoticed. You gain (spell: misdirection) and (spell: silence) as 2nd-level arcane or occult innate spells. The tradition of these spells must match the tradition you use for your gnome ancestry options. You can cast each spell once per day and can target only yourself." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("132c9e92-05b5-4a02-ac08-083f1e5c4d3d"), "at least one arcane or occult innate spell gained from a gnome heritage or gnome ancestry feat");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c38c7d4d-0669-49f8-bf74-1e10e28cd55a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
