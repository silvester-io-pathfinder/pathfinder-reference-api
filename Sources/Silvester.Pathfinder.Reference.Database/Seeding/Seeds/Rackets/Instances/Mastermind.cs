using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rackets.Instances
{
    public class Mastermind : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Racket GetRacket()
        {
            return new Racket
            {
                Id = ID, 
                Name = "Mastermind",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Where others might use sleight of hand or a silver tongue to achieve their objectives, you rely on your intellect to craft intricate schemes. You likely view your operations as a chess game, always planning 10 steps ahead where others might plan three. You might be a detective determined to solve crimes or a spymaster in the service of a powerful family or nation. If you operate outside the law, you might be an aspiring crime lord or information broker, excellent at directing others toward suitable jobs." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you successfully identify a creature using Recall Knowledge, that creature is flat-footed against your attacks until the start of your next turn; if you critically succeed, it's flat-footed against your attacks for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You're trained in Society and one of the following skills of your choice: Arcana, Nature, Occultism, or Religion. You can choose Intelligence as your key ability score." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Society.ID, ProficiencyId = Proficiencies.Instances.Trained.ID };
            yield return new GainSpecificKeyAbilityOptionEffect { Id = Guid.Parse(""), StatId = Stats.Instances.Intelligence.ID };
            yield return new ChoiceEffect
            {
                Id = Guid.Parse(""),
                Entries = new Effect[]
                {
                    new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Arcana.ID, ProficiencyId = Proficiencies.Instances.Trained.ID},
                    new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Nature.ID, ProficiencyId = Proficiencies.Instances.Trained.ID},
                    new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Occultism.ID, ProficiencyId = Proficiencies.Instances.Trained.ID},
                    new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Religion.ID, ProficiencyId = Proficiencies.Instances.Trained.ID},
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 134
            };
        }
    }
}
