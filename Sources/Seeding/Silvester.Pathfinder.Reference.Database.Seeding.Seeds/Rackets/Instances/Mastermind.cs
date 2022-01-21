using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rackets.Instances
{
    public class Mastermind : Template
    {
        public static readonly Guid ID = Guid.Parse("c4cca9c9-7285-4732-a3cc-581e06246281");
        
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
            yield return new TextBlock { Id = Guid.Parse("d24d8781-abae-4b0b-934a-2d6082d3927f"), Type = TextBlockType.Text, Text = "Where others might use sleight of hand or a silver tongue to achieve their objectives, you rely on your intellect to craft intricate schemes. You likely view your operations as a chess game, always planning 10 steps ahead where others might plan three. You might be a detective determined to solve crimes or a spymaster in the service of a powerful family or nation. If you operate outside the law, you might be an aspiring crime lord or information broker, excellent at directing others toward suitable jobs." };
            yield return new TextBlock { Id = Guid.Parse("79f4ea74-5022-4946-be6c-b5184b0d5cc1"), Type = TextBlockType.Text, Text = "If you successfully identify a creature using Recall Knowledge, that creature is flat-footed against your attacks until the start of your next turn; if you critically succeed, it's flat-footed against your attacks for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("f66e713d-d10f-4580-a0a3-732d201d8dce"), Type = TextBlockType.Text, Text = "You're trained in Society and one of the following skills of your choice: Arcana, Nature, Occultism, or Religion. You can choose Intelligence as your key ability score." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("c50aa35c-7b3d-47af-82ed-a8dcb01e2d54"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            builder.GainSpecificKeyAbilityOption(Guid.Parse("de52a428-18c3-48bc-b36c-df84fd9d1578"), Stats.Instances.Intelligence.ID);
            builder.AddOr(Guid.Parse("b985ba94-f47b-4822-a3a5-3ab0fa29c128"), or => 
            {
                or.GainSpecificSkillProficiency(Guid.Parse("14748902-209e-4715-ad3c-66643b7b1c2d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.GainSpecificSkillProficiency(Guid.Parse("0f78fe12-d996-4fcc-a14e-6476edbb14d6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.GainSpecificSkillProficiency(Guid.Parse("11b1e5e2-fcb1-48d2-93ba-1ce1146ce222"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.GainSpecificSkillProficiency(Guid.Parse("65db9f26-9d24-40d3-b41c-1e5bff184d34"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d67646d-8233-4ed8-b5d7-1c627c221633"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 134
            };
        }
    }
}
