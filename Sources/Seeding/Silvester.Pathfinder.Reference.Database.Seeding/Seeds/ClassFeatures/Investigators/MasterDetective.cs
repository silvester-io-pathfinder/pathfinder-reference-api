using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class MasterDetective : Template
    {
        public static readonly Guid ID = Guid.Parse("b6fc0bc6-729e-4162-8110-df6190243979");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Master Detective", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("634dc162-c5ea-411f-aa83-6cd2761446b3"), Type = TextBlockType.Text, Text = "As a master detective, you can solve any case and find all the clues available. If you're pursuing the subject of a lead and you enter a new location that includes another clue toward solving the mystery, the GM informs you of the existence of the clue and its type: an object, person, spell effect, or the like. When you find the clue, the GM informs you that you've done so. If there is more than one clue in the location, the GM chooses one to inform you about. When you find any of the clues in that location, the GM informs you that you've done so, even if it wasn't the clue they'd chosen or there are other clues you haven't found. Your proficiency rank for your investigator class DC increases to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificClassDcProficiency(Guid.Parse("7ebf3390-4d0a-4bc0-8102-9c36a1ed8920"), Proficiencies.Instances.Master.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21e1ff8e-cf6b-4e27-8de4-d8bd844a2448"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
