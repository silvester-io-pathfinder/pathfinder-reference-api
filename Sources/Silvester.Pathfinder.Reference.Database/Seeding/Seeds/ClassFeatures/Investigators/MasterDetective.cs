using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class MasterDetective : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As a master detective, you can solve any case and find all the clues available. If you're pursuing the subject of a lead and you enter a new location that includes another clue toward solving the mystery, the GM informs you of the existence of the clue and its type: an object, person, spell effect, or the like. When you find the clue, the GM informs you that you've done so. If there is more than one clue in the location, the GM chooses one to inform you about. When you find any of the clues in that location, the GM informs you that you've done so, even if it wasn't the clue they'd chosen or there are other clues you haven't found. Your proficiency rank for your investigator class DC increases to master." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificClassDcProficiencyEffect
            {
                Id = Guid.Parse(""),
                ProficiencyId = Proficiencies.Instances.Master.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite
                        {
                            Id = Guid.Parse(""),
                            Comparator = Comparator.GreaterThanOrEqualTo,
                            RequiredLevel = 19
                        }
                    }
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
