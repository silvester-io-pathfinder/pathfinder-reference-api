using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class Stubborn : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Stubborn", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You don't like being told what to do, and you don't give up. Your proficiency rank for Will saves increases to expert. When you fail, but don't critically fail, a Will save against an effect that would give you the controlled condition, you can attempt a second save against the effect at the start of your next turn. On a successful second save, the controlled condition ends, though any other effects remain. As normal, failing this second save doesn't allow you to attempt a third save on the subsequent turn." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSavingThrowProficiencyEffect
            {
                Id = Guid.Parse(""),
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ProficiencyId = Proficiencies.Instances.Expert.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite
                        {
                            Id = Guid.Parse(""),
                            Comparator = Comparator.GreaterThanOrEqualTo,
                            RequiredLevel = 3
                        }
                    }
                }
            };

            //TODO: Add the second try effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
